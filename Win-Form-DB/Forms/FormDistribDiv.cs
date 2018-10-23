using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using JointStockCompany;
using Win_Form_DB.Service;
using Business;

namespace Win_Form_DB
{
    public partial class FormDistribDiv : Base
    {
        private decimal distrAmount;
        private decimal distributed;
        private decimal onePrefer;
        private decimal oneCommon;
        private Dividend SomeDiv;
        public FormDividend DividendForm;

        public FormDistribDiv(FormDividend formDividend, Dividend someDiv)
        {
            InitializeComponent();
            SomeDiv = someDiv;
            DividendForm = formDividend;
            lDate.Text += someDiv.Date.ToString();
            lCommon.Text += someDiv.AllCommon.ToString();
            lPrefer.Text += someDiv.AllPrefer.ToString();
            distrAmount = 0;
            onePrefer = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDistribute_Click(object sender, EventArgs e)
        {
            DividendForm.dGVDividend.DataSource = null;
            SomeDiv.AmountRevenue = distributed;
            SomeDiv.AmountOneCommon = oneCommon;
            SomeDiv.AmountOnePrefer = onePrefer;
            DividendForm.InitDGVDividend();
            Dividend.ChangeDiv(SomeDiv);
            Close();
        }

        private void tBDistrAmount_Validated(object sender, EventArgs e)
        {
            if (!Decimal.TryParse(tBDistrAmount.Text, out distrAmount))
            {
                FormPrimary.MessageShowDialog(MessageList.IncorrectValue);
                distrAmount = 0;
                tBDistrAmount.Text = "";
            }
        }

        private void tBOnePrefer_Validated(object sender, EventArgs e)
        {
            if (Decimal.TryParse(tBOnePrefer.Text, out onePrefer))
            {
                onePrefer = Math.Round(onePrefer, 2);
                tBOnePrefer.Text = onePrefer.ToString();
                oneCommon = Math.Round((distrAmount - onePrefer * SomeDiv.AllPrefer) / SomeDiv.AllCommon,2);
                lOneCommon.Text = "Amount for one common:    " + oneCommon.ToString();
                if (oneCommon > 0)
                {
                    distributed = onePrefer * SomeDiv.AllPrefer + oneCommon * SomeDiv.AllCommon;
                    lDistributed.Text = "Distributed amount:   " + (distributed).ToString();
                    btnDistribute.Enabled = true;
                }
                else
                {

                    FormPrimary.MessageShowDialog(MessageList.DistributeAmountNotEnough);
                    btnDistribute.Enabled = false;
                }
            }
            else
            {
                FormPrimary.MessageShowDialog(MessageList.IncorrectValue);
                onePrefer = 0;
                tBOnePrefer.Text = "";
                btnDistribute.Enabled = false;
            }
        }
    }
}
