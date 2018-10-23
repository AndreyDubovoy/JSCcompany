using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Data;
using JointStockCompany;
using System.Text.RegularExpressions;
using Win_Form_DB.Service;
using Business;
using Win_Form_DB.DataView;

namespace Win_Form_DB
{
    public partial class NewHolder : Base
    {
        public Holder someHolder;
        public FormHolder HolderForm;
        public HolderOrder CurrentOrder;

        public NewHolder(FormHolder holderForm, Holder currentHolder, HolderOrder currentOrder)
        {
            InitializeComponent();
            HolderForm = holderForm;
            CurrentOrder = currentOrder;
            if (currentHolder == null) someHolder = new Holder();
            else
            {
                someHolder = currentHolder;
                this.Text = "Edit Holder";
                tBFirstName.Text = someHolder.FirstName?.Trim();
                tBSecondName.Text = someHolder.SecondName?.Trim();
                tBPhone.Text = someHolder.Phone?.Trim();
                tBMail.Text = someHolder.Email?.Trim();
                tBPhone_Validating(tBPhone, null);
                tBMail_Validating(tBMail, null);
                tBFirstName_Validating(tBFirstName, null);
                tBSecondName_Validating(tBSecondName, null);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool invalidInput = false;
            tBPhone_Validating(tBPhone, null);
            tBMail_Validating(tBMail, null);
            tBFirstName_Validating(tBFirstName, null);
            tBSecondName_Validating(tBSecondName, null);
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
                FormPrimary.LabelMessage(lMessage, MessageList.PrepairHolders);
                Cursor OldCursor = Cursor.Current;
                Cursor = Cursors.WaitCursor;
                someHolder.Phone = tBPhone.Text.Trim() == "" ? null : tBPhone.Text;
                someHolder.Email = tBMail.Text.Trim() == "" ? null : tBMail.Text;
                if (someHolder.Id == 0)
                {
                    someHolder.FirstName = tBFirstName.Text;
                    someHolder.SecondName = tBSecondName.Text;
                    someHolder.Id = Holder.SaveNewHolder(someHolder);
                    if(FormPrimary.gui.IsPortionUse) HolderForm.GetPortionNearHolder(someHolder);
                    else
                    {
                        HolderForm.bindingHolder.Add(someHolder);
                        HolderForm.SetNewOrder(someHolder);
                    }
                    HolderForm.MainForm.observHolderMenu.Add(new HolderMenu()
                    {
                        Id = someHolder.Id,
                        FirstName = someHolder.FirstName,
                        SecondName = someHolder.SecondName,
                        CommonShare = 0,
                        PreferShare = 0
                    });
                }
                else
                {
                    bool IsChangeName = false;
                    bool IsChangeTrade = false;
                    if ((someHolder.FirstName != tBFirstName.Text & CurrentOrder == HolderOrder.FirstName) || 
                        (someHolder.SecondName != tBSecondName.Text & CurrentOrder == HolderOrder.SecondName)) IsChangeName = true;
                    if (someHolder.FirstName != tBFirstName.Text || someHolder.SecondName != tBSecondName.Text) IsChangeTrade = true;
                    someHolder.FirstName = tBFirstName.Text;
                    someHolder.SecondName = tBSecondName.Text;
                    Holder.ChangeHolder(someHolder);

                    if (IsChangeTrade) FormHolder.ChangeNameInTrade(HolderForm.queueTrade, someHolder);

                    if (IsChangeName)
                    {
                        if(FormPrimary.gui.IsPortionUse) HolderForm.GetPortionNearHolder(someHolder);
                        else HolderForm.SetNewOrder(someHolder);
                    }
                    else
                    {
                        int i = 0;
                        while (HolderForm.bindingHolder[i].Id != someHolder.Id) i++;
                        HolderForm.bindingHolder[i] = someHolder;
                    }
                }
                HolderForm.DrawPortion();
                Cursor = OldCursor;
                Close();
            }
        }

        private void tBFirstName_Validating(object sender, CancelEventArgs e)
        {
            Control ctrl = (Control)sender;
            CheckNameControl(ctrl, "FirstName");
        }

        private bool SizeStringControl (string value, string nameColumn, out string substrValue)
        {
            if (value.Trim().Length > Holder.HolderColumnStringLength[nameColumn])
            {
                substrValue = value.Trim().Substring(0, Holder.HolderColumnStringLength[nameColumn]);
                return false;
            }
            substrValue = value.Trim();
            return true;
        }

        private void tBSecondName_Validating(object sender, CancelEventArgs e)
        {
            Control ctrl = (Control)sender;
            CheckNameControl(ctrl, "SecondName");
        }

        private void CheckNameControl(Control ctrl, string name)
        {
            string substrText;
            if (SizeStringControl(ctrl.Text, name, out substrText))
            {
                if (substrText == "")
                {
                    errorProvider.SetError(ctrl, $@"{name} "+ MessageList.NotEmpty);
                }
                else
                {
                    errorProvider.SetError(ctrl, "");
                }
            }
            else
            {
                errorProvider.SetError(ctrl, $@"{name} "+MessageList.TooLong+ $@" {Holder.HolderColumnStringLength[name]} "+MessageList.Characters);
            }
            ctrl.Text = substrText;
        }

        private void tBMail_Validating(object sender, CancelEventArgs e)
        {
            Control ctrl = (Control)sender;
            string substrText;
            if (SizeStringControl(tBMail.Text, "Email", out substrText))
            {
                string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                               @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
                if (substrText == "" || Regex.IsMatch(ctrl.Text, pattern, RegexOptions.IgnoreCase))
                {
                    errorProvider.SetError(ctrl, "");
                }
                else
                {
                    errorProvider.SetError(ctrl, MessageList.IncorrectEmail);
                }
            }
            else
            {
                errorProvider.SetError(ctrl, "Email" +MessageList.TooLong+ $@" {Holder.HolderColumnStringLength["Email"]} "+MessageList.Characters);
            }
            tBMail.Text = substrText;
        }

        private void tBPhone_Validating(object sender, CancelEventArgs e)
        {
            Control ctrl = (Control)sender;
            string substrText;
            if (SizeStringControl(ctrl.Text, "Phone", out substrText))
            {
                string pattern = "^(([0-9]|\\+)(\\d{9})|(\\d{12}))$";

                if (substrText == "" || Regex.IsMatch(tBPhone.Text.Trim(), pattern, RegexOptions.IgnoreCase))
                {
                    errorProvider.SetError(ctrl, "");
                }
                else
                {
                    errorProvider.SetError(ctrl, MessageList.IncorrectPhone);
                }
            }
            else
            {
                errorProvider.SetError(ctrl, "Phone" + MessageList.TooLong + $@" {Holder.HolderColumnStringLength["Phone"]} " + MessageList.Characters);
            }
            ctrl.Text = substrText;
        }

        private void NewHolder_FormClosing(object sender, FormClosingEventArgs e)
        {
            HolderForm.Enabled = true;
        }
    }
}
