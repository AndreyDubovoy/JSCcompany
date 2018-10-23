using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using JointStockCompany;
using Win_Form_DB.Service;

namespace Win_Form_DB
{
    public partial class Base : Form
    {
        public Base()
        {
            InitializeComponent();
        }

        private void Base_Load(object sender, EventArgs e)
        {
            SetLocationAndSize();
        }

        private void Base_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveLocationAndSize();
        }

        private void SetLocationAndSize()
        {

            if (Program.DictFormConfig != null & Program.DictFormConfig.ContainsKey(Name))
            {
                Location = Program.DictFormConfig[Name].LocationForm;
                if (Program.DictFormConfig[Name].SizeForm.Width>100 & Program.DictFormConfig[Name].SizeForm.Height > 100)
                   Size = Program.DictFormConfig[Name].SizeForm;
            }
            else
            {
                Program.DictFormConfig.Add(Name, new FormConfig(Location, Size));
            }
        }

        private void SaveLocationAndSize()
        {
            if (WindowState == FormWindowState.Normal)
            {
                FormConfig currentConfig = new FormConfig();
                currentConfig.LocationForm = Location;
                if (Size.Height > 100 & Size.Width > 100) currentConfig.SizeForm = Size;
                else currentConfig.SizeForm = Program.DictFormConfig[Name].SizeForm;
                Program.DictFormConfig[Name] = currentConfig;
            }
        }
    }
}
