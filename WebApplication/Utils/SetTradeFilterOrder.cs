using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebHolder.Models;

namespace WebHolder.Utils
{
    public class SetTradeFilterOrder
    {
        public bool _filter;
        delegate bool filterDel(Bid cell);
        private filterDel tradeDel;
        public TradeFilterOrder tradeFO;

        private bool ClearFiltr(object cell)
        {
            _filter = true;
            return _filter;
        }

        private bool buyFiltr(Bid cell)
        {
            if ((string)cell.TradeType.Trim() != "buy") _filter = false;
            return _filter;
        }

        private bool saleFiltr(Bid cell)
        {
            if ((string)cell.TradeType.Trim() != "sale") _filter = false;
            return _filter;
        }

        private bool completeFiltr(Bid cell)
        {
            if ((bool)cell.Complete == true) _filter = false;
            return _filter;
        }

        public List<Bid> GetTradeFiltrOrder(List<Bid> listBid)
        {
            tradeDel = ClearFiltr;
            if (tradeFO.Buy != "on") tradeDel += buyFiltr;
            if (tradeFO.Sale != "on") tradeDel += saleFiltr;
            if (tradeFO.Complete != "on") tradeDel += completeFiltr;

            return listBid.Where(t => tradeDel(t)).OrderCollection(tradeFO.Order == "date" ? "Date" : "Price",
                                    (tradeFO.Order == "date" || tradeFO.Order == "priceDsc" ? true : false)).ToList();
        }
    }
}
