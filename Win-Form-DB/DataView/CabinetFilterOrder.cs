using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_Form_DB.DataView
{
    public class CabinetFilterOrder
    {
        public bool AllDate { set; get; } = true;
        public DateTime DateFrom { set; get; } = DateTime.Today;
        public DateTime DateTo { set; get; } = DateTime.Today;
        public bool TradeOrderDate { set; get; } = true;
        public bool BalanceOrderDate { set; get; } = true;
        public bool TradeFilterAll { set; get; } = true;
        public bool TradeFilterBuy { set; get; }
        public bool TradeFilterSale { set; get; }
        public bool BalanceFilterAll { set; get; } = true;
        public bool BalanceFilterMoving { set; get; }
        public bool BalanceFilterTrade { set; get; }
        public bool BalanceFilterComission { set; get; }
        public bool BalanceFilterDividends { set; get; }
    }
}
