using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebHolder.Models
{
    public class BalanceFilterOrder
    {
        public string AllDate { set; get; } = "true";
        public string DateFrom { set; get; } = DateTime.Today.ToString("yyyy-MM-dd");
        public string DateFromData { set; get; } = DateTime.Today.ToShortDateString();
        public string DateTo { set; get; } = DateTime.Today.ToString("yyyy-MM-dd");
        public string DateToData { set; get; } = DateTime.Today.ToShortDateString();
        public string OrderDate { set; get; } = "true";
        public string Moving { set; get; }
        public string Trade { set; get; }
        public string Comission { set; get; }
        public string Dividends { set; get; }
    }
}