using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebHolder.Models
{
    public class TradeBox
    {
        public List<Bid> myBids;
        public List<PriceQuote> Quote;
        public List<Bid> CurrentBids;

        public TradeBox()
        {
            myBids = new List<Bid>();
            Quote = new List<PriceQuote>();
            CurrentBids = new List<Bid>();
        }
    }
}