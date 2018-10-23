using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using JointStockCompany;
using Win_Form_DB.Service;

namespace Win_Form_DB
{
    public partial class FormSettings : Base
    {
        private bool stopSave = false;

        public FormSettings()
        {
            InitializeComponent();
            lName.Text = "Company name: " + FormPrimary.BaseSettingsDictionary["NameCompany"];
            lDateEmission.Text = "Primary emission date: " + FormPrimary.BaseSettingsDictionary["EmissionDate"];
            tBComission.Text = FormPrimary.BaseSettingsDictionary["TradeComission"];
            tBFirstPortion.Text = FormPrimary.gui.FirstHolderPortion.ToString();
            tBNextPortion.Text = FormPrimary.gui.NextHolderPortion.ToString();
            tBQueueLength.Text = FormPrimary.gui.TradeQueueLength.ToString();
            tBCutDays.Text = FormPrimary.gui.CutDaysQuantity.ToString();
            tBPriceQuoteQuan.Text = FormPrimary.gui.PriceQuoteQuantity.ToString();
            cBPortionUse.Checked = FormPrimary.gui.IsPortionUse;
            cBPortionUse_CheckedChanged(cBPortionUse, null);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!stopSave)
            {
                decimal comission = Decimal.Parse(tBComission.Text);
                DataProvider.ChangeSettingsCompany(comission);
                FormPrimary.BaseSettingsDictionary["TradeComission"] = comission.ToString();

                FormPrimary.gui.FirstHolderPortion = Int32.Parse(tBFirstPortion.Text);
                FormPrimary.gui.NextHolderPortion = Int32.Parse(tBNextPortion.Text);
                FormPrimary.gui.TradeQueueLength = Int32.Parse(tBQueueLength.Text);
                FormPrimary.gui.PriceQuoteQuantity = Int32.Parse(tBPriceQuoteQuan.Text);
                FormPrimary.gui.CutDaysQuantity = Int32.Parse(tBCutDays.Text);
                FormPrimary.gui.IsPortionUse = cBPortionUse.Checked;

                System.Configuration.Configuration currentConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                currentConfig.AppSettings.Settings["FirstHolderPortion"].Value = FormPrimary.gui.FirstHolderPortion.ToString();
                currentConfig.AppSettings.Settings["NextHolderPortion"].Value = FormPrimary.gui.NextHolderPortion.ToString();
                currentConfig.AppSettings.Settings["TradeQueueLength"].Value = FormPrimary.gui.TradeQueueLength.ToString();
                currentConfig.AppSettings.Settings["PriceQuoteQuantity"].Value = FormPrimary.gui.PriceQuoteQuantity.ToString();
                currentConfig.AppSettings.Settings["CutDaysQuantity"].Value = FormPrimary.gui.CutDaysQuantity.ToString();
                currentConfig.AppSettings.Settings["IsPortionUse"].Value = FormPrimary.gui.IsPortionUse.ToString();
                currentConfig.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");

                Close();
            }
            else stopSave = false;
        }

        private void tBComission_Validated(object sender, EventArgs e)
        {
            stopSave = !FormPrimary.ValidateValue(tBComission, Decimal.Parse(FormPrimary.BaseSettingsDictionary["TradeComission"]), MessageList.IncorrectValue);
        }

        private void tBFirstPortion_Validated(object sender, EventArgs e)
        {
            stopSave = !FormPrimary.ValidateValue(tBFirstPortion, FormPrimary.gui.FirstHolderPortion, MessageList.IncorrectValue);
        }

        private void tBNextPortion_Validated(object sender, EventArgs e)
        {
            stopSave = !FormPrimary.ValidateValue(tBNextPortion, FormPrimary.gui.NextHolderPortion, MessageList.IncorrectValue);
        }

        private void tBOueueLength_Validated(object sender, EventArgs e)
        {
            stopSave = !FormPrimary.ValidateValue(tBQueueLength, FormPrimary.gui.TradeQueueLength, MessageList.IncorrectValue);
        }

        private void tBCutDays_Validated(object sender, EventArgs e)
        {
            stopSave = !FormPrimary.ValidateValue(tBCutDays, FormPrimary.gui.CutDaysQuantity, MessageList.IncorrectValue);
        }

        private void tBPriceQuoteQuan_Validated(object sender, EventArgs e)
        {
            stopSave = !FormPrimary.ValidateValue(tBPriceQuoteQuan, FormPrimary.gui.PriceQuoteQuantity, MessageList.IncorrectValue);
        }

        private void cBPortionUse_CheckedChanged(object sender, EventArgs e)
        {
            if (cBPortionUse.Checked)
            {
                tBFirstPortion.Enabled = true;
                tBNextPortion.Enabled = true;
            }
            else
            {
                tBFirstPortion.Enabled = false;
                tBNextPortion.Enabled = false;
            }
        }
    }
}
