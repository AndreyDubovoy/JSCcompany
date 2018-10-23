using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebHolder.Models
{
    public class NewBid
    {
        public long? IdBid { set; get; }
        public long? IdTrader { set; get; }
        public string TradeType { set; get; } = "buy"; // "buy" or "sale"
        public long? ShareBidQty { set; get; } = 1;
        public string ShareType { set; get; } = "common";// "common" or "prefer"
        public string Price { set; get; }
    }
}