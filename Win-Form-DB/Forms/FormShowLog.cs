using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Win_Form_DB.Service;
using log4net.Repository.Hierarchy;
using log4net;
using log4net.Appender;
using JointStockCompany;

namespace Win_Form_DB.Forms
{
    public partial class FormShowLog : Base
    {
        public FormShowLog()
        {
            InitializeComponent();
            string path = (LogManager.GetCurrentLoggers()[0].Logger.Repository.GetAppenders()[0] as FileAppender).File;
            path = path.Substring(0, path.LastIndexOf('\\') + 1);
            openFileDialog1.InitialDirectory = path;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.FileName = "LogError";
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            try
            {
                using (StreamReader sr = new StreamReader(filename))
                {
                    tBLog.Text = sr.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                FormPrimary.FormExeptionHandler(ex, "Program can't open file");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
