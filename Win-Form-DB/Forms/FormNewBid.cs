using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using JointStockCompany;
using Data;
using Win_Form_DB.Service;
using Business;

namespace Win_Form_DB
{
 
    public partial class FormNewBid : Base
    {
        public Holder SelectedHolder;
        private FormTrade TradeForm;
        private FormPrimary MainForm;
        private bool stopSet = false;
        private decimal lastPrice;
        private long lastQuantity;

        public FormNewBid(FormPrimary mainForm, FormTrade tradeForm,Holder selectedHolder)
        {
            InitializeComponent();
            SelectedHolder= selectedHolder;
            TradeForm = tradeForm;
            MainForm = mainForm;
            TradeForm.IsTradeAllowed = false;
            lHolder.Text = selectedHolder.FirstName.Trim() + " " +selectedHolder.SecondName.Trim() + "  Id " +selectedHolder.Id;
            lastQuantity = SelectedHolder.CommonShare - CheckBids(rBCommon.Checked, rBSale.Checked);
            lastQuantity = lastQuantity < 0 ? 0 : lastQuantity;
            mTBQuantity.Text = lastQuantity.ToString();
            lastPrice = TradeForm.bindingPriceQuote.First(t => t.CommonPrice != 0).CommonPrice;
            tBPrice.Text = lastPrice.ToString();
            lCQty.Text = selectedHolder.CommonShare.ToString();
            lPQty.Text = selectedHolder.PreferShare.ToString();
        }

        private void rBCommon_Click(object sender, EventArgs e)
        {
            lastQuantity = SelectedHolder.CommonShare - CheckBids(rBCommon.Checked, rBSale.Checked);
            lastQuantity = lastQuantity < 0 ? 0 : lastQuantity;
            mTBQuantity.Text = lastQuantity.ToString();
            lastPrice = TradeForm.bindingPriceQuote.First(t => t.CommonPrice != 0).CommonPrice;
            tBPrice.Text = lastPrice.ToString();
        }

        private void rBPrefer_Click(object sender, EventArgs e)
        {
            lastQuantity = SelectedHolder.PreferShare - CheckBids(rBCommon.Checked, rBSale.Checked);
            lastQuantity = lastQuantity < 0 ? 0 : lastQuantity;
            mTBQuantity.Text = lastQuantity.ToString();
            lastPrice = TradeForm.bindingPriceQuote.First(t => t.PreferPrice != 0).PreferPrice;
            tBPrice.Text = lastPrice.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if (stopSet)
            {
                stopSet = false;
                return;
            }
            if (Int32.Parse(mTBQuantity.Text) == 0)
            {
                FormPrimary.MessageShowDialog(MessageList.ShareQtyNotZero);
                return;
            }
            if (rBSale.Checked)
            {
                if(rBCommon.Checked)
                {
                   if(!ControlQuantityShare("common", SelectedHolder.CommonShare)) return;
                }
                else
                {
                    if (!ControlQuantityShare("prefer", SelectedHolder.PreferShare)) return;
                }
            }
            Bid newBid = new Bid()
            {
                IdBid = 0,
                IdTrader = SelectedHolder.Id,
                NameTrader = SelectedHolder.FirstName.Trim() + ' ' + SelectedHolder.SecondName.Trim(),
                TradeType = rBBuy.Checked ? "buy" : "sale",
                Date = DateTime.Today,
                ShareBidQty = Int32.Parse(mTBQuantity.Text),
                ShareType = rBCommon.Checked ? "common" : "prefer",
                Price = Decimal.Parse(tBPrice.Text),
                ExecutedShareBidQty = 0,
                Complete = false,
                NameUser = Guid.Empty,
                Closed = false
            };

           newBid.IdBid =  Bid.SaveNewBid(newBid);
           TradeForm.observBid.Add(newBid);
           if (rBBuy.Checked) TradeForm.SetBuyFiltrOrder(TradeForm.buyFO, newBid.IdBid);
                 else TradeForm.SetSaleFiltrOrder(TradeForm.saleFO, newBid.IdBid);
           Close();
        }

        private bool ControlQuantityShare(string typeShare, long quantShare)
        {
            int quantTextBox;
            if (!Int32.TryParse(mTBQuantity.Text, out quantTextBox))
            {
                FormPrimary.MessageShowDialog(MessageList.IncorectShareQuantity);
                return false;
            }
            long totalShareBid = 0;
            foreach (Bid b in TradeForm.observBid)
                    if (b.TradeType == "sale" && b.IdTrader == SelectedHolder.Id && b.ShareType == typeShare && !b.Closed)
                    totalShareBid += b.ShareBidQty - b.ExecutedShareBidQty;
            if (quantShare - ShareForBid(SelectedHolder.Id, typeShare, "sale") < quantTextBox)
            {
                FormPrimary.MessageShowDialog(MessageList.SharesNotEnough);
                return false;
            }
            return true;
        }

        private long ShareForBid(long idHolder, string typeShare, string typeTrade)
        {
            long totalShareBid = 0;
            foreach (Bid b in TradeForm.observBid)
                if (b.TradeType == typeTrade && b.IdTrader == idHolder && b.ShareType == typeShare && !b.Closed)
                    totalShareBid += b.ShareBidQty - b.ExecutedShareBidQty;
            return totalShareBid;
        }

        private void mTBQuantity_Validated(object sender, EventArgs e)
        {
            if (!FormPrimary.ValidateValue(mTBQuantity, lastQuantity, MessageList.IncorectShareQuantity))
            {
                 stopSet = true;
            }
            else if (Int32.Parse(mTBQuantity.Text) == 0)
            {
                FormPrimary.MessageShowDialog(MessageList.ShareQtyNotZero);
                stopSet = true;
            }
            else stopSet = false;
        }

        private void tBPrice_Validated(object sender, EventArgs e)
        {
            stopSet = !FormPrimary.ValidateValue(tBPrice, lastPrice, MessageList.IncorrectPrice);
        }

        private void FormNewBid_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (TradeForm.SelectedHolder != null) TradeForm.IsTradeAllowed = true;
        }

        private void rBSale_Click(object sender, EventArgs e)
        {
            if (rBCommon.Checked) lastQuantity = SelectedHolder.CommonShare - CheckBids(rBCommon.Checked, rBSale.Checked);
            else lastQuantity = SelectedHolder.PreferShare - CheckBids(rBCommon.Checked, rBSale.Checked);
            lastQuantity = lastQuantity < 0 ? 0 : lastQuantity;
            mTBQuantity.Text = lastQuantity.ToString();
        }

        private void rBBuy_Click(object sender, EventArgs e)
        {
            if (rBCommon.Checked) lastQuantity = SelectedHolder.CommonShare - CheckBids(rBCommon.Checked, rBSale.Checked);
            else lastQuantity = SelectedHolder.PreferShare - CheckBids(rBCommon.Checked, rBSale.Checked);
            mTBQuantity.Text = lastQuantity.ToString();
            lMessage1.Text = "You have bids for buy";
        }

        private long CheckBids (bool isCommon, bool isSale)
        {
            long saleQty = 0;
            if (isSale)
            {
                lMessage1.Text = MessageList.BidForSale;
                if (isCommon)
                {
                    saleQty = ShareForBid(SelectedHolder.Id, "common", "sale");
                    lMessage2.Text = "common shares:     " + saleQty.ToString();
                }
                else
                {
                    saleQty = ShareForBid(SelectedHolder.Id, "prefer", "sale");
                    lMessage2.Text = "preference shares: " + saleQty.ToString();
                }
            }
            else
            {
                lMessage1.Text = MessageList.BidForBuy;
                if (isCommon)
                {
                    long buyQty = ShareForBid(SelectedHolder.Id, "common", "buy");
                    lMessage2.Text = MessageList.CommonShares+ buyQty.ToString();
                }
                else
                {
                    long buyQty = ShareForBid(SelectedHolder.Id, "prefer", "buy");
                    lMessage2.Text = MessageList.PreferShares + buyQty.ToString();
                }
            }
            return saleQty;
        }

    }
}
