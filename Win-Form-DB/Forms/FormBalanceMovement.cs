using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using JointStockCompany;
using Win_Form_DB.DataView;
using Win_Form_DB.Service;
using Business;

namespace Win_Form_DB
{
    public partial class FormBalanceMovement : Base
    {
        public string Type;
        public long Id;
        public FormCabinet CabinetForm;
         
        public FormBalanceMovement(FormCabinet formCabinet, long id, string type)
        {
            InitializeComponent();
            Id = id;
            Type = type;
            CabinetForm = formCabinet;
            if (type == "Refill")
            {
                Text = "Refill Balance";
                lEnter.Text = MessageList.RefillBalance;
            }
            else
            {
                Text = "Withdraw Balance";
                lEnter.Text = MessageList.WithdrawBalance;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            bool invalidInput = false;
            tBmoving_Validated(tBmoving, null);
            tBCreditCard_Validating(tBCreditCard, null);

            foreach (Control ctrl in grpValidation.Controls)
            {
                if (errorProvider.GetError(ctrl) != "")
                {
                    invalidInput = true;
                    break;
                }
            }

            if (invalidInput)
            {
                FormPrimary.MessageShowDialog(MessageList.InvalidInput);
            }
            else
            {
                Decimal accountMove = Type == "Refill" ? Decimal.Parse(tBmoving.Text) : -Decimal.Parse(tBmoving.Text);
                SqlException ex = Holder.MovingBalance(Id, accountMove);
                if (ex == null)
                {
                    FormPrimary.MessageShowDialog(MessageList.MovingComplete, MessageList.Info);
                    BalanceMovement movement = new BalanceMovement(DateTime.Today, accountMove, "Moving");
                    CabinetForm.RefreshBalance(movement);
                }
                else FormPrimary.FormExeptionHandler(ex, ex.Message);
                Close();
            }
        }

        private void tBmoving_Validated(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            decimal amount;
            if (Decimal.TryParse(tBmoving.Text, out amount) & amount != 0)
            {
                errorProvider.SetError(ctrl, "");
            }
            else
            {
                errorProvider.SetError(ctrl, MessageList.IncorrectValue);
            }
        }

        private void FormBalanceMovement_FormClosing(object sender, FormClosingEventArgs e)
        {
            CabinetForm.Enabled = true;
        }

        private void tBCreditCard_Validating(object sender, CancelEventArgs e)
        {
            Control ctrl = (Control)sender;
            string pattern = "^(\\d{16})$";
            if ( Regex.IsMatch(tBCreditCard.Text, pattern, RegexOptions.IgnoreCase))
            {
                errorProvider.SetError(ctrl, "");
            }
            else
            {
                errorProvider.SetError(ctrl, MessageList.IncorectCreditCard);
            }
        }
    }
}
