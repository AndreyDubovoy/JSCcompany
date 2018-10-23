using Business;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using WebHolder.Models;

namespace WebHolder.Utils
{
    public class SetBalanceFilterOrder
    {
        public BalanceFilterOrder balanceFO;
        public bool _filter;
        delegate bool filterBalanceDel(BalanceMovement Balance);
        private filterBalanceDel accountDel;

        private bool ClearFiltr(object cell)
        {
            _filter = true;
            return _filter;
        }

        private bool accountDateFiltr(BalanceMovement Balance)
        {
            if (Balance.Date < ControlDate(balanceFO.DateFrom, true) ||  Balance.Date > ControlDate(balanceFO.DateTo, false)) _filter = false;
            return _filter;
        }

        private bool movingFiltr(BalanceMovement Balance)
        {
            if (Balance.Comment.Trim() == "Moving") _filter = false;
            return _filter;
        }

        private bool tradeFiltr(BalanceMovement Balance)
        {
            if (Balance.Comment.Trim() == "Sale" || Balance.Comment.Trim() == "Purchase") _filter = false;
            return _filter;
        }

        private bool comissionFiltr(BalanceMovement Balance)
        {
            if (Balance.Comment.Trim() == "Comission") _filter = false;
            return _filter;
        }

        private bool dividendsFiltr(BalanceMovement Balance)
        {
            if (Balance.Comment.Trim() == "Dividends") _filter = false;
            return _filter;
        }

        public List<BalanceMovement> GetBalanceFiltrOrder(List <BalanceMovement> listMove)
        {
            accountDel = ClearFiltr;
            if (!(balanceFO.AllDate == "true")) accountDel += accountDateFiltr;
                if (balanceFO.Comission == "on") accountDel += comissionFiltr;
                if (balanceFO.Dividends == "on") accountDel += dividendsFiltr;
                if (balanceFO.Moving == "on") accountDel += movingFiltr;
                if (balanceFO.Trade == "on") accountDel += tradeFiltr;

            return listMove.Where(t => accountDel(t)).OrderCollection(balanceFO.OrderDate == "true" ? "Date" : "Amount", true).ToList();
        }

        public DateTime ControlDate(string date, bool isFrom)
        {
            DateTime Date;
            if (!DateTime.TryParseExact(date, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out Date)) Date = DateTime.Today;
            
            if (isFrom)
            {
                balanceFO.DateFrom = Date.ToString("yyyy-MM-dd");
                balanceFO.DateFromData = Date.ToShortDateString();
            } 
            else
            {
                balanceFO.DateTo = Date.ToString("yyyy-MM-dd");
                balanceFO.DateToData = Date.ToShortDateString();
            }
                
            return Date;
        }
    }
}