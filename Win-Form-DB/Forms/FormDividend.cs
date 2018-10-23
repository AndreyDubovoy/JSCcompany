using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class FormDividend : Base
    {
        public ObservableCollection<Dividend> observDiv;
        public ObservableCollection<DivHolder> observDivHolder;
        private FormDistribDiv formDistribDiv;
        private FormPrimary MainForm;

        public FormDividend(FormPrimary mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
            DataTable divTable = Dividend.GetDividendTable(0); // "0" - Get dividend table for all dividend ID
            observDiv = new ObservableCollection<Dividend>();
            observDivHolder = new ObservableCollection<DivHolder>();
            ConvertDividendToObserv(divTable);
            InitDGVDividend();
            timerDivHolder.Interval = 1000;
        }

        public void InitDGVDividend()
        {
            dGVDividend.DataSource = observDiv;
            dGVDividend.Columns["AmountOnePrefer"].HeaderText = "One prefer";
            dGVDividend.Columns["AmountOneCommon"].HeaderText = "One common";
            dGVDividend.Columns["AmountRevenue"].HeaderText = "Amount Revenue";
            dGVDividend.Columns["AmountOnePrefer"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dGVDividend.Columns["AmountOneCommon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dGVDividend.Columns["AmountRevenue"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dGVDividend.Columns["AllCommon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dGVDividend.Columns["AllPrefer"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        public void ConvertDividendToObserv (DataTable dt)
        {
            foreach (DataRow t in dt.Rows)
            {
                observDiv.Add(new Dividend()
                {
                    Id = t.Field<int>("idDiv"),
                    Date = t.Field<DateTime>("date"),
                    AllCommon = t.Field<int>("AllCommonShareQty"),
                    AllPrefer = t.Field<int>("AllPreferShareQty"),
                    AmountRevenue = Math.Round(t.Field<decimal>("AmountRevenue"), 2),
                    AmountOnePrefer = Math.Round(t.Field<decimal>("AmountOnePrefer"), 2),
                    AmountOneCommon = Math.Round(t.Field<decimal>("AmountOneCommon"), 2),
                    Complete = t.Field<int>("Complete") != 0
                });
            }
        }

        public void GetDivHolder(Dividend someDiv) // Get Holder list for current dividend ID
        {
            DataTable DivHolderTable = DivHolder.GetDivHolderTable(someDiv.Id);
            dGVDivHolder.DataSource = null;
            observDivHolder.Clear();
            foreach (DataRow t in DivHolderTable.Rows)
            {
                observDivHolder.Add(new DivHolder()
                {
                    IdHolder = t.Field<int>("idHolder"),
                    Name = t.Field<string>("firstName").Trim() + ' ' + t.Field<string>("secondName").Trim(),
                    AmountCommon = Math.Round(t.Field<int>("CommonShareQty") * someDiv.AmountOneCommon, 2),
                    AmountPrefer = Math.Round(t.Field<int>("PreferShareQty") * someDiv.AmountOnePrefer, 2)
                });
                
            }
            dGVDivHolder.DataSource = observDivHolder;
            dGVDivHolder.Columns["AmountPrefer"].HeaderText = "Amount prefer";
            dGVDivHolder.Columns["AmountCommon"].HeaderText = "Amount common";
            dGVDivHolder.Columns["AmountPrefer"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dGVDivHolder.Columns["AmountCommon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void dGVDividend_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            timerDivHolder.Enabled = true;
        }

        private void timerDivHolder_Tick(object sender, EventArgs e)
        {
            if (dGVDividend.CurrentRow != null)
            GetDivHolder(observDiv[dGVDividend.CurrentRow.Index]);
            timerDivHolder.Enabled = false;
            if (dGVDividend.CurrentRow == null || observDiv[dGVDividend.CurrentRow.Index].Complete)
            {
                btnDistribute.Enabled = false;
                btnRefillBalance.Enabled = false;
            }
            else
            {
                btnDistribute.Enabled = true;
                btnRefillBalance.Enabled = true;
            }
        }

        private void btnFixList_Click(object sender, EventArgs e) // Create new dividend list
        {
            FormNewList formNewList = new FormNewList(this,MessageList.FormHolderList1,
                                                           MessageList.FormHolderList2,
                                                                "NewDiv",null);
            formNewList.Show();
        }

        private void btnDistribute_Click(object sender, EventArgs e) // Calculate dividend amount on one share
        {
                formDistribDiv = new FormDistribDiv(this, observDiv[dGVDividend.CurrentRow.Index]);
                formDistribDiv.Show();
        }

        private void btnRefillBalance_Click(object sender, EventArgs e) // Refill dividend on holder Balance
        {
            if (observDiv[dGVDividend.CurrentRow.Index].Complete)
            {
                FormPrimary.MessageShowDialog(MessageList.DividendDistributed);
            }
            else
            {
                FormNewList formNewList = new FormNewList(this, MessageList.DistributeDividends1,
                                                                 MessageList.DistributeDividends2,
                                                    "RefillBalance", observDiv[dGVDividend.CurrentRow.Index]);
                formNewList.Show();
            }
        }

        private void FormDividend_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.Enabled = true;
        }
    }
}
