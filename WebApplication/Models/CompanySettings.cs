using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebHolder.Models
{
    public class CompanySettings
    {
        public string NameCompany { set; get; }
        public string EmissionDate { set; get; }
        public int CommonShareTotal { set; get; }
        public int PreferShareTotal { set; get; }
        public decimal TradeComission { set; get; }
    }

}