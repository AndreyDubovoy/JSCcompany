using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Configuration;
using System.Runtime.CompilerServices;

using Win_Form_DB.Service;
using Win_Form_DB.DataView;
using Win_Form_DB;
using System.Drawing;
using Win_Form_DB.Forms;
using Data;
using Business;

namespace JointStockCompany
{
    public partial class FormPrimary : Base
    {
        public static Dictionary<string, string> BaseSettingsDictionary;
//        public static Dictionary<string, int> HolderColumnStringLength;
        public static ConfigSettings gui;
//        public static string connectionString;

        public FormHolder holdersForm;
        public FormTrade tradeForm;
        public FormDividend dividendForm;
        public FormSettings settingsForm;
        public FormShowLog formShowLog;
        public SelectHolder selectHolderForm;

        public ObservableCollection<HolderMenu> observHolderMenu; // Holder list with information minimum for menu
        public Predicate<HolderMenu> UnwantedHolder;
        public HolderOrder CurrentOrderMenu;
        public string UserName;
        public Guid UserGuid;

        public FormPrimary()
        {
            InitializeComponent();

            gui = new ConfigSettings();
            gui.FirstHolderPortion = Int32.Parse(ConfigurationManager.AppSettings["FirstHolderPortion"]);
            gui.NextHolderPortion = Int32.Parse(ConfigurationManager.AppSettings["NextHolderPortion"]);
            gui.TradeQueueLength = Int32.Parse(ConfigurationManager.AppSettings["TradeQueueLength"]);
            gui.PriceQuoteQuantity = Int32.Parse(ConfigurationManager.AppSettings["PriceQuoteQuantity"]);
            gui.CutDaysQuantity = Int32.Parse(ConfigurationManager.AppSettings["CutDaysQuantity"]);
            gui.IsPortionUse = Boolean.Parse(ConfigurationManager.AppSettings["IsPortionUse"]);
            DataProvider.connectionString = ConfigurationManager.AppSettings["ConnString"];

            NotOperationAllowed();

            Show();

            FormUserEntry formUserEntry = new FormUserEntry(this);
            formUserEntry.ShowDialog();
        }

        public void OperationAllowed ()
        {
            dividendsMenuItem.Enabled = true;
            holdersMenuItem.Enabled = true;
            tradeMenuItem.Enabled = true;
            CabinetMenuItem.Enabled = true;
            settingsMenuItem.Enabled = true;
        }

        public void NotOperationAllowed()
        {
            dividendsMenuItem.Enabled = false;
            holdersMenuItem.Enabled = false;
            tradeMenuItem.Enabled = false;
            CabinetMenuItem.Enabled = false;
            settingsMenuItem.Enabled = false;
        }

        public void DrawName(string name)
        {
            Font font = new Font(FontFamily.GenericSansSerif, 48, FontStyle.Bold);
            Size size = TextRenderer.MeasureText(name, font);
            lNameCompany.Font = font;
            lNameCompany.Location = new Point(
                     Size.Width > size.Width ? (Size.Width - size.Width) / 2 : 1,
                     Size.Height > size.Height+10 ? (Size.Height - size.Height) / 2+ 10 : 10);
            lNameCompany.Text = name;
        }

        public static void MessageShow(string text, string typeTitle = MessageList.Error)
        {
            MyMessageBox message = new MyMessageBox();
            message.Showing(text, typeTitle);
        }

        public static void MessageShowDialog(string text, string typeTitle = MessageList.Error)
        {
            MyMessageBox message = new MyMessageBox();
            message.ShowingDialog(text, typeTitle);
        }

        public static void FormExeptionHandler(Exception ex, string message)
        {
            LogExeption.ExeptionHandler(ex); 
            FormPrimary.MessageShowDialog(message);
        }

        public static void LockForm(out FormCollection openForms, Dictionary<string, bool> formEnabled)
        {
            openForms = Application.OpenForms;
            formEnabled.Clear();
            foreach (Form f in openForms)
            {
                formEnabled.Add(f.Name, f.Enabled);
                f.Enabled = false;
            }
        }

        public static void UnLockForm(FormCollection openForms, Dictionary<string, bool> formEnabled,Form currentForm)
        {
            foreach (Form f in openForms)
            {
                if (f.Name != currentForm.Name) f.Enabled = formEnabled[f.Name];
            }
        }

        public static void LabelMessage(Label label, string message)
        {
            label.Text = message;
            label.Refresh();
        }

        public string CurrentOrderMenuString()
        {
            return CurrentOrderMenu.ToString();
        }
           

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            FormUserEntry formUserEntry = new FormUserEntry(this);
            formUserEntry.ShowDialog();
        }

        private void holdersMenuItem_Click(object sender, EventArgs e)
        {
            Enabled = false;
            holdersForm = new FormHolder(this);
            holdersForm.Text = "Holder List";
            holdersForm.Show();
        }

        private void tradeMenuItem_Click(object sender, EventArgs e)
        {
            tradeForm = new FormTrade(this, null, null);
            tradeForm.Text = "Share transactions";
            tradeForm.Show();
        }

        private void CabinetMenuItem_Click(object sender, EventArgs e)
        {
            Enabled = false;
            selectHolderForm = new SelectHolder(this, "Cabinet");
            selectHolderForm.Text = "Select holder";
            selectHolderForm.Show();
        }

        private void dividendsMenuItem_Click(object sender, EventArgs e)
        {
            Enabled = false;
            dividendForm = new FormDividend(this);
            dividendForm.Show();
        }

        private void settingsMenuItem_Click(object sender, EventArgs e)
        {
            settingsForm?.Close();
            settingsForm = new FormSettings();
            settingsForm.Show();
        }
 
        private void closeMenuItem_Click(object sender, EventArgs e)
        {
            NotOperationAllowed();
            UserName = "no define";
            Text = "USER : " + UserName;
            DrawName("Joint-Stock Company");
        }

        public static bool ValidateValue(TextBoxBase validatedBox, object defaultValue, string errorMessage)
        // Control value in any TextBox and MaskedTextBox
        {
            bool IsCorrect = false;
            if (defaultValue is Int32 || defaultValue is long) IsCorrect = Int32.TryParse(validatedBox.Text, out int result);
            else if (defaultValue is Decimal) IsCorrect = Decimal.TryParse(validatedBox.Text, out decimal result);
            if (!IsCorrect)
            {
                MessageShowDialog(errorMessage);
                validatedBox.Text = defaultValue.ToString();
            }
            return IsCorrect;
        }

        private void showLogMenuItem_Click(object sender, EventArgs e)
        {
            formShowLog?.Close();
            formShowLog = new FormShowLog();
            formShowLog.Show();
        }
    }
}
