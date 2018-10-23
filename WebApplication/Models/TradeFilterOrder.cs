using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebHolder.Models
{
    public class TradeFilterOrder
    {
        public string Sale { set; get; }
        public string Buy { set; get; }
        public string Complete { set; get; } 
        public string Order { set; get; } = "date";
    }
}