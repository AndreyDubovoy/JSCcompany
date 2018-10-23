using Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebHolder.Filters;
using WebHolder.Models;
using WebHolder.Utils;

namespace WebHolder.Controllers
{
    [ExceptionHandler]
    public class TradeController : BaseController
    {
 
        // GET: Trade
        public ActionResult Index()
        {
            GetCompanySettings();
            if (!GetSession()) return Redirect("/Home/SessionOut");
            ViewBag.Holder = (Holder)mySession["CurrentHolder"];
            AddMySession("PortionTrade", settings.BidsPortion);

            TradeFilterOrder tradeFO = new TradeFilterOrder();
            tradeFO.Buy = "on";
            tradeFO.Sale = "on";
            AddMySession("TradeFilterOrder", tradeFO);
            ViewBag.FilterOrder = tradeFO;

            TradeBox tradeBox = new TradeBox();

            DataTable dtQuote = PriceQuote.GetPriceQuoteTable((int)settings.QuoteQty);
            foreach (DataRow dr in dtQuote.Rows) tradeBox.Quote.Add(PriceQuote.QuoteFromTable(dr));

            DataTable checkQuote = PriceQuote.CheckQuotePrice();
            if (checkQuote.Rows.Count == 0 ||
                (checkQuote.Rows.Count == 1 && checkQuote.Rows[0].Field<DateTime>("dateTrade") == DateTime.Today))
            {
                ViewBag.Refresh = false;
                AddMySession("QuoteRefresh", false);
            }
            else
            {
                ViewBag.Refresh = true;
                AddMySession("QuoteRefresh", true);
            }

            GetAllBids(tradeBox);
            AddMySession("TradeBox", tradeBox);
            SaveSession();
            return View("Index", tradeBox);
        }

        public TradeBox GetShortTrade(List<Bid> FullTrade, int portion)
        {
            int count = FullTrade.Count();
            TradeBox tradeBox = (TradeBox)mySession["TradeBox"];
            if (count > portion)
            {
                ViewBag.NextPortion = true;
                tradeBox.CurrentBids = FullTrade.Take((int)mySession["PortionTrade"]).ToList();
            }
            else
            {
                ViewBag.NextPortion = false;
                tradeBox.CurrentBids = FullTrade;
            }
            AddMySession("TradeBox", tradeBox);
            return tradeBox;
        }

        public ActionResult NextPortion()
        {
            if (!GetSession()) return Redirect("/Home/SessionOut");
            if (Request["NextPortion"] == "Next Portion")
            {
                mySession["PortionTrade"] = (int)mySession["PortionTrade"] + settings.BidsPortion;
                ViewBag.FilterOrder = (TradeFilterOrder)mySession["TradeFilterOrder"];
            }
            else
            {
                List<Bid> FiltredTradeList = GetCurrentBids();

            }
            var tradeBox = GetShortTrade((List<Bid>)mySession["FiltredTradeList"], (int)mySession["PortionTrade"]);
            SaveSession();
            return PartialView("CurrentBids", tradeBox );
        }

        public ActionResult QuoteRefresh()
        {
            if (!GetSession()) return Redirect("/Home/SessionOut");
            TradeBox tradeBox = (TradeBox)mySession["TradeBox"];
            PriceQuote.SaveNewQuote();
            tradeBox.Quote.Clear();
            DataTable dtQuote = PriceQuote.GetPriceQuoteTable((int)settings.QuoteQty);
            foreach (DataRow dr in dtQuote.Rows) tradeBox.Quote.Add(PriceQuote.QuoteFromTable(dr));
            AddMySession("TradeBox", tradeBox);
            AddMySession("QuoteRefresh", false);
            SaveSession();
            ViewBag.Refresh = false;
            return PartialView("Quote", tradeBox);
        }

        [HttpPost]
        public ActionResult SetFilterOrder(TradeFilterOrder TradeFO)
        {
            if (!GetSession()) return Redirect("/Home/SessionOut");
            TradeBox tradeBox;
            SetTradeFilterOrder SetTradeFO = new SetTradeFilterOrder
            {
                tradeFO = TradeFO
            };
            var FiltredTradeList = SetTradeFO.GetTradeFiltrOrder((List<Bid>)mySession["FullList"]);
            tradeBox = GetShortTrade(FiltredTradeList, (int)mySession["PortionTrade"]);
            AddMySession("FiltredTradeList", FiltredTradeList);
            AddMySession("TradeFilterOrder", TradeFO);
            AddMySession("TradeBox", tradeBox);
            SaveSession();
            ViewBag.FilterOrder = TradeFO;
            return PartialView("BidContent", tradeBox);
        }

        public ActionResult DeleteBid(long? id)
        {
            if (!GetSession()) return Redirect("/Home/SessionOut");
            ViewBag.Holder = (Holder)mySession["CurrentHolder"];
            Bid.CloseBid((long)id);
            TradeBox tradeBox = (TradeBox)mySession["TradeBox"];
            tradeBox.myBids.Remove(tradeBox.myBids.Find(b => b.IdBid == id));
            AddMySession("TradeBox", tradeBox);
            SaveSession();
            return PartialView("MyBids", tradeBox);
        }

        [HttpGet]
        public ActionResult NewBid()
        {
            if (!GetSession()) return Redirect("/Home/SessionOut");
            ViewBag.Holder = (Holder)mySession["CurrentHolder"];
            NewBid newBid = new NewBid();
            newBid.Price = ((TradeBox)mySession["TradeBox"]).Quote.FirstOrDefault(t => t.CommonPrice != 0).CommonPrice.ToString().Replace(',', '.');
            ViewBag.NewBid = newBid;
            return PartialView("NewBid");
        }

        [HttpPost]
        public ActionResult NewBid(NewBid newBid)
        {
            if (!GetSession()) return Redirect("/Home/SessionOut");
            ViewBag.Holder = (Holder)mySession["CurrentHolder"];
            decimal price = Decimal.Parse(newBid.Price.Replace('.', ','));
            TradeBox tradeBox = (TradeBox)mySession["TradeBox"];
            if (Request["OK"] == "OK")
            {
                if(newBid.TradeType == "buy")
                {
                    if(newBid.ShareBidQty * price > ((Holder)mySession["CurrentHolder"]).Balance)
                    {
                        ViewBag.Message = " Not enough currency on your balance ";
                        ViewBag.NewBid = newBid;
                        return PartialView("NewBid");
                    }
                }
                else
                {
                    long qtyForSale = tradeBox.myBids.Where(t => t.ShareType == newBid.ShareType).Sum(t => t.ShareBidQty - t.ExecutedShareBidQty);
                    long qtyHolder = (newBid.ShareType == "common" ? ((Holder)mySession["CurrentHolder"]).CommonShare : ((Holder)mySession["CurrentHolder"]).PreferShare);
                    if( qtyHolder < newBid.ShareBidQty + qtyForSale)
                    {
                        ViewBag.Message = " You dont't have enough "+newBid.ShareType+" shares for sale";
                        ViewBag.NewBid = newBid;
                        return PartialView("NewBid"); 
                    }
                }

                Bid bidForSave = new Bid()
                {
                    IdTrader = (long)newBid.IdTrader,
                    Date = DateTime.Today,
                    ShareType = newBid.ShareType,
                    TradeType = newBid.TradeType,
                    ShareBidQty = (long)newBid.ShareBidQty,
                    Price = Bid.DecimalFormat(price),
                    ExecutedShareBidQty = 0
                };
                long newIdBid = Bid.SaveNewBid(bidForSave);
                if (newIdBid != 0)
                {
                    bidForSave.IdBid = newIdBid;
                    tradeBox.myBids.Add(bidForSave);
                }
                SaveSession();
            }
            return PartialView("MyBids", tradeBox); ;
        }

        public ActionResult ShowCurrentBids()
        {
            if (!GetSession()) return Redirect("/Home/SessionOut");
            ViewBag.Holder = (Holder)mySession["CurrentHolder"];
            ViewBag.FilterOrder = (TradeFilterOrder)mySession["TradeFilterOrder"];
            List<Bid> FiltredTradeList = GetCurrentBids();
            var tradeBox = GetShortTrade(FiltredTradeList, (int)mySession["PortionTrade"]);
            SaveSession();
            return PartialView("BidContent", tradeBox);
        }

        public List<Bid> GetCurrentBids()
        {
            SetTradeFilterOrder SetTradeFO = new SetTradeFilterOrder()
            {
                tradeFO = (TradeFilterOrder)mySession["TradeFilterOrder"]
            };
            GetAllBids((TradeBox)mySession["TradeBox"]);
            var FiltredTradeList = SetTradeFO.GetTradeFiltrOrder((List<Bid>)mySession["FullList"]);
            AddMySession("FiltredTradeList", FiltredTradeList);
            return FiltredTradeList;
        }

        public void GetAllBids(TradeBox tradeBox)
        {
            DataTable dtBid = Business.Bid.GetBidTable(DateTime.Today.AddDays(-(double)settings.ShowDayComplete).ToString("yyyy-MM-dd"));
            tradeBox.myBids.Clear();
            tradeBox.CurrentBids.Clear();
            foreach (DataRow dr in dtBid.Rows)
            {
                Bid bid = Bid.BidFromTable(dr);
                if (!bid.Closed)
                {
                    if (bid.IdTrader == ((Holder)mySession["CurrentHolder"]).Id)
                    {
                        if (!bid.Complete) tradeBox.myBids.Add(bid);
                    }
                    else tradeBox.CurrentBids.Add(bid);
                }
            }
            AddMySession("FullList", tradeBox.CurrentBids);
        }

        [HttpGet]
        public ActionResult TradeBid( long? id)
        {
            if (!GetSession()) return Redirect("/Home/SessionOut");
            ViewBag.Holder = (Holder)mySession["CurrentHolder"];
            TradeBox tradeBox = (TradeBox)mySession["TradeBox"];
            Bid CurrentBid = tradeBox.CurrentBids.Find(b => b.IdBid == id);
            long bidQty = CurrentBid.ShareBidQty - CurrentBid.ExecutedShareBidQty;

            if (CurrentBid.TradeType == "sale")
            {
               
                long balanceQty = (long)(((Holder)mySession["CurrentHolder"]).Balance / CurrentBid.Price);
                CurrentBid.ShareBidQty = bidQty > balanceQty ? balanceQty : bidQty;
            }
            else
            {
                long holderQty = CurrentBid.ShareType == "common" ? ((Holder)mySession["CurrentHolder"]).CommonShare : ((Holder)mySession["CurrentHolder"]).PreferShare;
                CurrentBid.ShareBidQty = bidQty > holderQty ? holderQty : bidQty;
            }
            ViewBag.Bid = CurrentBid;
            return PartialView("TradeBid");
        }

        [HttpPost]
        public ActionResult TradeBid(Bid execBid)
        {
            if (!GetSession()) return Redirect("/Home/SessionOut");
            GetCompanySettings();
            TradeBox tradeBox = (TradeBox)mySession["TradeBox"];
            Bid CurrentBid = tradeBox.CurrentBids.Find(b => b.IdBid == execBid.IdBid);
            if (Bid.ReserveBid(CurrentBid.IdBid, (Guid)mySession["UserGuid"], true) == null)
            {
                if (Bid.SaveExecutedBid(CurrentBid, (int)execBid.ShareBidQty, ((Holder)mySession["CurrentHolder"]).Id, companySettings.TradeComission, "webHolder") == null)
                {
                    ViewBag.Message = "The agreement is complete";
                    Holder CurrentHolder = Holder.GetOneHolder(((Holder)mySession["CurrentHolder"]).Id);
                    AddMySession("CurrentHolder", CurrentHolder);
                    SaveSession();
                }
                else ViewBag.Message = "The agreement is rejection";
            }
            else ViewBag.Message = "The bid is used by another user";
            ViewBag.Holder = (Holder)mySession["CurrentHolder"];
            ViewBag.Refresh = (bool)mySession["QuoteRefresh"];
            return PartialView("MainTrade", tradeBox);
        }

        public ActionResult CancelBid()
        {
            if (!GetSession()) return Redirect("/Home/SessionOut");
            List<Bid> FiltredTradeList = (List<Bid>)mySession["FiltredTradeList"];
            var tradeBox = GetShortTrade(FiltredTradeList, (int)mySession["PortionTrade"]);
            return PartialView("CurrentBids", tradeBox);
        }


    }
}