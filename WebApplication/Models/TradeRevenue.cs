using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebHolder.Models
{
    public class TradeRevenue
    {
        public long BuyCommonQty { set; get; }
        public decimal BuyCommonAmount { set; get; }
        public long BuyPreferQty { set; get; }
        public decimal BuyPreferAmount { set; get; }
        public long SaleCommonQty { set; get; }
        public decimal SaleCommonAmount { set; get; }
        public long SalePreferQty { set; get; }
        public decimal SalePreferAmount { set; get; }
        public decimal Comission { set; get; }
        public decimal Dividends { set; get; }
    }
}