using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Win_Form_DB.Service
{
    [Serializable]
    public class FormConfig
    {
        public Point LocationForm { set; get; }
        public Size SizeForm { set; get; }

        public FormConfig() { }

        public FormConfig(Point locationForm, Size sizeForm)
        {
            LocationForm = locationForm;
            SizeForm = sizeForm;
        }
    }
}
