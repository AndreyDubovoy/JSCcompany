using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace Win_Form_DB.Service
{
     public class ConfigSettings
    {
        public ConfigSettings() { }
 
        public int FirstHolderPortion { set; get; }
        public int NextHolderPortion { set; get; }
        public int TradeQueueLength { set; get; }
        public int PriceQuoteQuantity { set; get; }
        public int CutDaysQuantity { set; get; }
        public bool IsPortionUse { set; get; }
    }
}
