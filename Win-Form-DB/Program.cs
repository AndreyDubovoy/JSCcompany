using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Win_Form_DB;
using System.Xml.Serialization;

using Win_Form_DB.Service;
using Framework.Utils;
using Business;

namespace JointStockCompany
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static XmlSerializableDictionary<string, FormConfig> DictFormConfig ; // Collection of user parametrs forms
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.UnhandledException +=
           (sender, args) => HandleUnhandledException(args.ExceptionObject as Exception);
            Application.ThreadException +=
                (sender, args) => HandleUnhandledException(args.Exception);

            Logger.InitLogger();

            // read XML with form parametrs
            DictFormConfig = new XmlSerializableDictionary<string, FormConfig>();
            XmlSerializer formatter = new XmlSerializer(typeof(XmlSerializableDictionary<string, FormConfig>));
            using (FileStream fs = new FileStream("formConfig.xml", FileMode.OpenOrCreate))
            {
                if (fs.Length != 0)
                    DictFormConfig = (XmlSerializableDictionary<string, FormConfig>)formatter.Deserialize(fs);
                else DictFormConfig = new XmlSerializableDictionary<string, FormConfig>();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPrimary());

            using (FileStream fs = new FileStream("formConfig.xml", FileMode.Truncate))
            {
                formatter.Serialize(fs, DictFormConfig);
            }
        }

        static void HandleUnhandledException(Exception e)
        {
            // show report sender and close the app 
            try
            {
                FormPrimary.FormExeptionHandler(e, "Some fatal error. Please, inform administrator");
                Application.Exit();
            }
            catch (Exception exc)
            {
                try
                {
                    MessageBox.Show("Fatal Non-UI Error. Could not write the error to the event log. Reason: "
                                     + exc.Message, "Fatal Non-UI Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                finally
                {
                    Application.Exit();
                }
            }
        }
    }
}
