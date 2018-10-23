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

namespace Win_Form_DB.Service
{
    public partial class MyMessageBox : Form
    {

        public MyMessageBox()
        {
            InitializeComponent();
        }

        public void Showing(string message, string title = MessageList.Error)
        {
            InitMessage(message, title);
            Show();
        }

        public void ShowingDialog(string message, string title = MessageList.Error)
        {
            InitMessage(message, title);
            ShowDialog();
        }

        public void InitMessage(string message, string title)
        {
            Text = title;
            lMessage.Text = message;
            if (title == MessageList.Error) lMessage.ForeColor = Color.Red;
            Font font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular);
            Size size = TextRenderer.MeasureText(message, font);
            this.Size = new Size((size.Width > 200 ? size.Width + 80 : 300), 300);
            btnOK.Location = new Point(this.Size.Width / 2 - 50, 200);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
             Close();
        }
    }
}
