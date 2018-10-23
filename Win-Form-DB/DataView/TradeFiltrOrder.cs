using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_Form_DB.DataView
{
    public class TradeFiltrOrder
    {
        public bool All { set; get; } = true;
        public bool Complete { set; get; } = false;
        public bool Price { set; get; } = true;
        public bool Name { set; get; } = false;
        public bool Date { set; get; } = false;
    }
}
