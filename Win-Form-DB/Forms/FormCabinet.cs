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
using Win_Form_DB.DataView;
using Win_Form_DB.Service;
using Business;

namespace Win_Form_DB
{
    public partial class FormCabinet : Base
    {
        private BindingList<ShareTrade> bindingTrade; // full trade
        private List<ShareTrade> listTradeFiltred; // filtred trade
        private List<BalanceMovement> listMove; // full Balance movement
        private List<BalanceMovement> listMoveFiltred; // filtred Balance movement

        private Holder Holder;
        public FormPrimary FormMain;
        public SelectHolder FormSelect;

        public FormCabinetFiltrOrder FormFO;
        public CabinetFilterOrder CabinetFO;

        // delegate for trade and Balance movement filtrs
        delegate bool filterBalanceDel(BalanceMovement Balance);
        delegate bool filterTradeDel(ShareTrade trade);
        private filterBalanceDel accountDel;
        private filterTradeDel tradeDel;
        private bool _filter;

        public FormCabinet(FormPrimary formMain, Holder holder, SelectHolder formSelect)
        {
            InitializeComponent();
            Holder = holder;
            FormMain = formMain;
            FormSelect = formSelect;
            bindingTrade = new BindingList<ShareTrade>();
            listMove = new List<BalanceMovement>();
            ShareTrade.GetTrade(holder, bindingTrade);
            lHolder.Text = holder.FirstName.Trim() + ' ' + holder.SecondName.Trim() + " Id = " + holder.Id.ToString();
            laccount.Text = holder.Balance.ToString();
            lShares.Text = "Shares: Common " + holder.CommonShare.ToString() + "  Preference " + holder.PreferShare.ToString();
            DataTable Balance = BalanceMovement.GetBalanceMovement(holder.Id);
            BalanceMovement someMove = new BalanceMovement();

            foreach (DataRow t in Balance.Rows)
            {
                someMove = new BalanceMovement(t.Field<DateTime>("Date"),Math.Round(t.Field<decimal>("Amount"),2), t.Field<string>("Comment").Trim());
                listMove.Add(someMove);
            }
            CabinetFO = new CabinetFilterOrder();
            SetBalanceFiltrOrder(CabinetFO);
            SetTradeFiltrOrder(CabinetFO);
         }

        public void RefreshBalance(BalanceMovement someMove)
        {
            dGVBalance.DataSource = null;
            listMove.Add(someMove);
            SetBalanceFiltrOrder(CabinetFO);
            Holder.Balance += someMove.Amount;
            laccount.Text = Holder.Balance.ToString();
        }

        private bool ClearFiltr(object cell)
        {
            _filter = true;
            return _filter;
        }

        private bool buyFiltr(ShareTrade trade)
        {
            if (trade.IdPurchaser == Holder.Id) _filter = false;
            return _filter;
        }

        private bool saleFiltr(ShareTrade trade)
        {
            if (trade.IdSeller == Holder.Id) _filter = false;
            return _filter;
        }

        private bool tradeDateFiltr(ShareTrade trade)
        {
            if (trade.DateTrade < CabinetFO.DateFrom || trade.DateTrade > CabinetFO.DateTo) _filter = false;
            return _filter;
        }

        private bool accountDateFiltr(BalanceMovement Balance)
        {
            if (Balance.Date < CabinetFO.DateFrom || Balance.Date > CabinetFO.DateTo) _filter = false;
            return _filter;
        }

        private bool movingFiltr(BalanceMovement Balance)
        {
            if (Balance.Comment.Trim() == "Moving") _filter = false;
            return _filter;
        }

        private bool tradeFiltr(BalanceMovement Balance)
        {
            if (Balance.Comment.Trim() == "Sale" || Balance.Comment.Trim() == "Purchase") _filter = false;
            return _filter;
        }

        private bool comissionFiltr(BalanceMovement Balance)
        {
            if (Balance.Comment.Trim() == "Comission") _filter = false;
            return _filter;
        }

        private bool dividendsFiltr(BalanceMovement Balance)
        {
            if (Balance.Comment.Trim() == "Dividends") _filter = false;
            return _filter;
        }

        public void SetBalanceFiltrOrder(CabinetFilterOrder cabinetFO)
        {
            accountDel = ClearFiltr;
            if (!cabinetFO.AllDate) accountDel += accountDateFiltr;
            if (!cabinetFO.BalanceFilterAll)
            {
                if (cabinetFO.BalanceFilterComission) accountDel += comissionFiltr;
                if (cabinetFO.BalanceFilterDividends) accountDel += dividendsFiltr;
                if (cabinetFO.BalanceFilterMoving) accountDel += movingFiltr;
                if (cabinetFO.BalanceFilterTrade) accountDel += tradeFiltr;
            }

            listMoveFiltred = listMove.Where(t => accountDel(t)).OrderCollection(cabinetFO.BalanceOrderDate ? "Date" : "Amount").ToList();
            dGVBalance.DataSource = listMoveFiltred;
            dGVBalance.Columns["Amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        public void SetTradeFiltrOrder(CabinetFilterOrder cabinetFO)
        {
            tradeDel = ClearFiltr;
            if (!cabinetFO.AllDate) tradeDel += tradeDateFiltr;
            if (!cabinetFO.TradeFilterAll)
            {
                if (cabinetFO.TradeFilterBuy) tradeDel += buyFiltr;
                if (cabinetFO.TradeFilterSale) tradeDel += saleFiltr;
            }
            var listFiltred = bindingTrade.Where(t => tradeDel(t));
            listTradeFiltred = cabinetFO.TradeOrderDate ? listFiltred.OrderBy(t => t.DateTrade).ToList() :
                                                          listFiltred.OrderBy(t => t.ShareQty*t.Price).ToList();
            dGVTrade.DataSource = listTradeFiltred;
            dGVTrade.Columns["idSeller"].HeaderText = "Id Seller";
            dGVTrade.Columns["idPurchaser"].HeaderText = "Id Purchaser";
            dGVTrade.Columns["ShareQty"].HeaderText = "Share Quantity";
            dGVTrade.Columns["ShareQty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dGVTrade.Columns["NameSeller"].HeaderText = "Name Seller";
            dGVTrade.Columns["NamePurchaser"].HeaderText = "Name Purchaser";
            dGVTrade.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        public void RefreshTrade()
        {
            ShareTrade.GetTrade(Holder, bindingTrade);
            SetTradeFiltrOrder(CabinetFO);
        }

        private void dGVBalance_Paint(object sender, PaintEventArgs e)
        {
            foreach (DataGridViewRow row in dGVBalance.Rows)
            {
                if ((decimal)row.Cells["Amount"].Value < 0)
                {
                   dGVBalance.Rows[row.Index].Cells["Amount"].Style.BackColor = Color.Red;
                }
            }
        }

        private void btnTrade_Click(object sender, EventArgs e)
        {
            FormTrade tradeForm = new FormTrade(FormMain, Holder, this);
            tradeForm.Text = "Share transactions for "+Holder.FirstName+" "+Holder.SecondName;
            tradeForm.Show();
        }

        private void btnFO_Click(object sender, EventArgs e)
        {
            FormFO?.Close();
            FormFO = new FormCabinetFiltrOrder(this);
            FormFO.SetParamFiltrOrder(CabinetFO);
            FormFO.Show();
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            Enabled = false;
            FormRevenue formRevenue = new FormRevenue(this, Holder);
            formRevenue.Show();
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            Enabled = false;
            FormBalanceMovement formBalanceMovement = new FormBalanceMovement(this, Holder.Id, "Refill");
            formBalanceMovement.Show();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            Enabled = false;
            FormBalanceMovement formBalanceMovement = new FormBalanceMovement(this, Holder.Id, "Withdraw");
            formBalanceMovement.Show();
        }

        private void FormCabinet_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormMain.Enabled = true;
            FormSelect.Close();
            FormFO?.Close();
        }
    }
}