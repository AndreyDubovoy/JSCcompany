using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_Form_DB.DataView
{
    public class HolderMenu
    {
        public long Id { set; get; } = 0;
        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public long CommonShare { set; get; } = 0;
        public long PreferShare { set; get; } = 0;

        public HolderMenu()  { }

    }
}

 
