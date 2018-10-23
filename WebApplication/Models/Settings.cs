using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebHolder.Models
{
    public class Settings
    {
        public int? TradePortion { set; get; } = 4;
        public int? BalancePortion { set; get; } = 5;
        public int? BidsPortion { set; get; } = 5;
        public int? QuoteQty { set; get; } = 6;
        public int? ShowDayComplete { set; get; } = 10;
        public int? RevenueDays { set; get; } = 30;
    }
}