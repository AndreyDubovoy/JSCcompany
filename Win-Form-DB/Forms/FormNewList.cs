using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JointStockCompany;
using Win_Form_DB.Service;
using Business;

namespace Win_Form_DB
{
    public partial class FormNewList : Base
    {
        public string Procedure;
        public Dividend CurrentDiv;
        private FormDividend DividendForm;

        Dictionary<string, bool> formEnabled;
        FormCollection openForms;

        public FormNewList(FormDividend formDividend, string line1, string line2, string procedure, Dividend currentDiv )
        // procedure value "NewDiv" -  Create new holder list
        // procedure value "RefillBalance" - Refill dividend on holder accounts
        {
            InitializeComponent();
            formEnabled = new Dictionary<string, bool>();
            FormPrimary.LockForm(out openForms, formEnabled);
            lconfirm.Text = line1;
            lconfirm1.Text = line2;
            Procedure = procedure;
            CurrentDiv = currentDiv;
            DividendForm = formDividend;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Cursor OldCursor = Cursor.Current;
            Cursor = Cursors.WaitCursor;
            FormPrimary.LabelMessage(lMessage, MessageList.WaitSomeTime);
            if (Procedure == "NewDiv") // Create new holder list
            {
                long newId;
                DataTable dt;
                SqlException ex;
                newId = Dividend.SaveNewDiv(out ex);
                if (newId != 0)
                {
                    FormPrimary.MessageShowDialog(MessageList.DividendListCreated, MessageList.Info);
                    DividendForm.dGVDividend.DataSource = null;
                    dt = Dividend.GetDividendTable(newId);
                    DividendForm.ConvertDividendToObserv(dt);
                    DividendForm.InitDGVDividend();
                    DividendForm.dGVDividend.CurrentCell = DividendForm.dGVDividend[0, DividendForm.observDiv.Count - 1];
                }
                else
                {
                    FormPrimary.FormExeptionHandler(ex, MessageList.DividendListRejection);
                }
             }
            else // Refill dividend on holder accounts
            {
                SqlException ex = Holder.SaveDividendToBalance(CurrentDiv);
                if (ex == null)
                {
                    FormPrimary.MessageShowDialog(MessageList.DistributionComplete, MessageList.Info);
                    DividendForm.dGVDividend.DataSource = null;
                    CurrentDiv.Complete = true;
                    DividendForm.InitDGVDividend();
                }
                else FormPrimary.FormExeptionHandler(ex, MessageList.DistributionRejection);
            }
            Cursor = OldCursor;
            Close();
        }

        private void FormNewList_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormPrimary.UnLockForm(openForms, formEnabled, this);
        }
    }
}
