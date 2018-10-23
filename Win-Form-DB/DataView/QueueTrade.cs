using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using Business;

namespace Win_Form_DB.DataView
{
    public class QueueTrade
    {
        public long IdTrade { set; get; }
        public BindingList<ShareTrade> TradeList { set; get; }

        public QueueTrade ( long idTrade, BindingList<ShareTrade> tradeList)
        {
            IdTrade = idTrade;
            TradeList = tradeList;
        }
    }
}
