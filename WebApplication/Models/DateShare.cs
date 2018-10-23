using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebHolder.Models
{
    public class DateShare : ShareCost
    {
        public string Date { set; get; }
        public string Name { set; get; }

        public DateShare (ShareCost shareCost, string date, string name)
        {
            Common = shareCost.Common;
            PriceCommon = Math.Round(shareCost.PriceCommon,2);
            Prefer = shareCost.Prefer;
            PricePrefer = Math.Round(shareCost.PricePrefer,2);
            Date = date;
            Name = name;
        }

    }
}