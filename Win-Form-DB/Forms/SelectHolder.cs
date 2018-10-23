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
using Data;
using Business;
using System.Collections.ObjectModel;
using Win_Form_DB.Service;
using Win_Form_DB.DataView;

namespace Win_Form_DB
{
    public partial class SelectHolder : Base
    {
        public static  int CurrentRow;
        public string Sender;
        public ObservableCollection<HolderMenu> filtredObservHolderMenu;
        private FormCloseBid formCloseBid;
        private FormNewBid formNewBid;
        public SeachHolder seachHolderForm;
        public HolderOrderForm selectHolderOrder;
        public FormPrimary FormMain;


        public SelectHolder(FormPrimary formMain,string sender)
        {
            InitializeComponent();
            Sender = sender;
            FormMain = formMain;
            if (Sender == "Buy" || Sender == "Sale" || Sender == "NewBid") FormMain.tradeForm.IsTradeAllowed = false;

            if (FormMain.UnwantedHolder != null)
            {
                IEnumerable<HolderMenu> FiltredList = null;
                FiltredList = FormMain.observHolderMenu.Where(t => !FormMain.UnwantedHolder(t));
                filtredObservHolderMenu = new ObservableCollection<HolderMenu>();
                foreach (HolderMenu b in FiltredList) filtredObservHolderMenu.Add(b);
            }
            else
            {
                filtredObservHolderMenu = FormMain.observHolderMenu;
            }
            dGVHolder.DataSource = filtredObservHolderMenu;
            dGVHolder.Columns["CommonShare"].Visible = false;
            dGVHolder.Columns["PreferShare"].Visible = false;
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            seachHolderForm?.Close();
            seachHolderForm = new SeachHolder(FormMain);
            CurrentRow = dGVHolder.CurrentRow.Index;
            seachHolderForm.Show();
        }

        public void goToHolder(int holderIndex,out string fName, out string sName)
        {
            dGVHolder.CurrentCell = dGVHolder[0, holderIndex];
            fName = (string)dGVHolder[1, holderIndex].Value;
            sName = (string)dGVHolder[2, holderIndex].Value;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            CurrentRow = dGVHolder.CurrentRow.Index;
            Holder selectedHolder = Holder.GetOneHolder(filtredObservHolderMenu[CurrentRow].Id);
            switch (Sender)
            {
                case "Cabinet":
                    {
                        Enabled = false;
                        FormCabinet formCabinet = new FormCabinet(FormMain,selectedHolder, this);
                        formCabinet.Show();
                        break;
                    }
                case "NewBid":
                    {
                        FormMain.tradeForm.IsTradeAllowed = false;
                        formNewBid?.Close();
                        formNewBid = new FormNewBid(FormMain, FormMain.tradeForm, selectedHolder);
                        formNewBid.Show();
                        break;
                    }
                case "Buy":
                    {
                        if (selectedHolder.Id == FormMain.tradeForm.observSaleBid[FormMain.tradeForm.CurrentSaleRow].IdTrader)
                        {
                            FormPrimary.MessageShowDialog(MessageList.BuyerSellerSame);
                            break;
                        }
                        formCloseBid?.Close();
                        formCloseBid = new FormCloseBid(FormMain, FormMain.tradeForm,selectedHolder, FormMain.tradeForm.observSaleBid[FormMain.tradeForm.CurrentSaleRow]);
                        if (formCloseBid.InitFormCloseBid()) formCloseBid.Show();
                        break;
                    }
                case "Sale":
                    {
                        if (selectedHolder.Id == FormMain.tradeForm.observBuyBid[FormMain.tradeForm.CurrentBuyRow].IdTrader)
                        {
                            FormPrimary.MessageShowDialog(MessageList.BuyerSellerSame);
                            break;
                        }
                        formCloseBid?.Close();
                        formCloseBid = new FormCloseBid(FormMain, FormMain.tradeForm, selectedHolder, FormMain.tradeForm.observBuyBid[FormMain.tradeForm.CurrentBuyRow]);
                        if (formCloseBid.InitFormCloseBid()) formCloseBid?.Show();
                        break;
                    }
            }
        }

        private void SelectHolder_FormClosing(object sender, FormClosingEventArgs e)
        {
     
            if (Sender == "Cabinet")  FormMain.Enabled = true;
            formCloseBid?.Close();
            formNewBid?.Close();
            seachHolderForm?.Close();
            selectHolderOrder?.Close();
            if (FormMain.tradeForm != null) FormMain.tradeForm.IsTradeAllowed = true;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            selectHolderOrder?.Close();
            selectHolderOrder = new HolderOrderForm(FormMain, this, filtredObservHolderMenu[CurrentRow].Id);
            selectHolderOrder.Show();
        }
    }
}
