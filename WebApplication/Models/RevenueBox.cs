using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebHolder.Models
{
    public class RevenueBox
    {
        public DateShare DateShareFrom { set; get; }
        public DateShare DateShareTo { set; get; }
        public TradeRevenue TradeRevenue { set; get; }
        public decimal Revenue { set; get; }
    }
}