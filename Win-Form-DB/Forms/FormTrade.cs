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
using System.Runtime.CompilerServices;
using JointStockCompany;
using Data;
using Win_Form_DB.Service;
using Framework.Utils;
using Win_Form_DB.DataView;
using Business;

namespace Win_Form_DB
{
    public partial class FormTrade : Base, INotifyPropertyChanged
    {
        public FormPrimary FormMain;
        public FormCabinet Cabinet;
        public FormCloseBid formCloseBid;
        public FormDeleteBid formDeleteBid;
        public FormTradeFiltrOrder foForm;

        // delegate for buy and sale bid filtrs
        delegate bool filterDel(Bid cell);
        private filterDel buyDel;
        private filterDel saleDel;
        private bool _filter;
        public TradeFiltrOrder buyFO;
        public TradeFiltrOrder saleFO;

        public int CurrentBuyRow;
        public int CurrentSaleRow;

        public BindingList<PriceQuote> bindingPriceQuote;
        public  ObservableCollection<Bid> observBid;
        public ObservableCollection<Bid> observBuyBid;
        public ObservableCollection<Bid> observSaleBid;
        public Holder SelectedHolder;
        private long currentTrader;
        private string currentShareType;

        Dictionary<string, bool> formEnabled;
        FormCollection openForms;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private bool _isTradeAllowed;

        public bool IsTradeAllowed
        {
            set
            {
                _isTradeAllowed = value;
                OnPropertyChanged();
            }
            get { return _isTradeAllowed; }
        }

        public FormTrade()
        {
            InitializeComponent();
        }

        public FormTrade(FormPrimary formMain, Holder selectedHolder, FormCabinet cabinet)
        {
            InitializeComponent();
            formEnabled = new Dictionary<string, bool>();
            FormPrimary.LockForm(out openForms, formEnabled);
            FormMain = formMain;
            SelectedHolder = selectedHolder;
            Cabinet = cabinet;

            IsTradeAllowed = true;
            btnBuy.DataBindings.Add(new Binding("Enabled", this, "IsTradeAllowed"));
            btnDeleteBid.DataBindings.Add(new Binding("Enabled", this, "IsTradeAllowed"));
            btnFiltrOrder.DataBindings.Add(new Binding("Enabled", this, "IsTradeAllowed"));
            btnNewBid.DataBindings.Add(new Binding("Enabled", this, "IsTradeAllowed"));
            btnSale.DataBindings.Add(new Binding("Enabled", this, "IsTradeAllowed"));

            // Get bids without old close and complete
            DataTable bidTable = Bid.GetBidTable(DateTime.Today.AddDays(-FormPrimary.gui.CutDaysQuantity).ToString("yyyy-MM-dd"));
            observBid = new ObservableCollection<Bid>();
            observBuyBid = new ObservableCollection<Bid>();
            observSaleBid = new ObservableCollection<Bid>();
            

            foreach (DataRow t in bidTable.Rows)
            {
                observBid.Add(Bid.BidFromTable(t));
            }

            buyFO = new TradeFiltrOrder();
            SetBuyFiltrOrder(buyFO, 0);

            saleFO = new TradeFiltrOrder();
            SetSaleFiltrOrder(saleFO, 0);

            GetPriceQuote();
            // Control  do you need refresh quote table
            DataTable checkQuote = PriceQuote.CheckQuotePrice();
            if (checkQuote.Rows.Count == 0 ||
                (checkQuote.Rows.Count == 1 && checkQuote.Rows[0].Field<DateTime>("dateTrade") == DateTime.Today))
            {
                btnRefresh.Enabled = false;
            }
        }

        private void GetPriceQuote()
        {
            DataTable priceQuoteTable = PriceQuote.GetPriceQuoteTable(FormPrimary.gui.PriceQuoteQuantity);
            bindingPriceQuote = new BindingList<PriceQuote>();
            foreach (DataRow t in priceQuoteTable.Rows)
            {
                bindingPriceQuote.Add(PriceQuote.QuoteFromTable(t));
            }
            dGVTradeQuote.DataSource = bindingPriceQuote;
            dGVTradeQuote.Columns["CommonPrice"].HeaderText = "Common Price";
            dGVTradeQuote.Columns["CommonPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dGVTradeQuote.Columns["PreferPrice"].HeaderText = "Preference Price";
            dGVTradeQuote.Columns["PreferPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private bool ClearFiltr(object cell)
        {
            _filter = true;
            return _filter;
        }
 
        private bool buyFiltr(Bid cell)
        {
            if ((string)cell.TradeType.Trim() != "buy") _filter = false;
            return _filter;
        }

        private bool saleFiltr(Bid cell)
        {
            if ((string)cell.TradeType.Trim() != "sale") _filter = false;
            return _filter;
        }

        private bool completeFiltr(Bid cell)
        {
            if ((bool)cell.Complete == true) _filter = false;
            return _filter;
        }

        private void btnFiltrOrder_Click(object sender, EventArgs e)
        {
            foForm?.Close();
            foForm = new FormTradeFiltrOrder(this, observBuyBid[dGVTradeBuy.CurrentRow.Index].IdBid,
                                                   observSaleBid[dGVTradeSale.CurrentRow.Index].IdBid);
            foForm.SetParamFiltrOrder(buyFO, saleFO);
            foForm.Show();
        }

        public void SetBuyFiltrOrder(TradeFiltrOrder buyFO, long bidId)
        {
            buyDel = ClearFiltr;
            buyDel += buyFiltr;
            if (buyFO.Complete) buyDel += completeFiltr;
            string nameOrder = "IdBid";
            if (buyFO.Price) nameOrder = "Price";
            else if (buyFO.Name) nameOrder = "NameTrader";
            else if (buyFO.Date) nameOrder = "Date";
            IEnumerable<Bid> BuyList = observBid.Where(t => buyDel(t)).OrderCollection(nameOrder);
 
            dGVTradeBuy.DataSource = null;
            observBuyBid.Clear();
            int index = 0;
            int i = 0;
            foreach (Bid b in BuyList)
            {
                observBuyBid.Add(b);
                if (b.IdBid == bidId) index = i;
                i++;
            }
            dGVTradeBuy.DataSource = observBuyBid;
            dGVTradeBuy.CurrentCell = dGVTradeBuy[0, index];
            dGVTradeBuy.Columns["TradeType"].Visible = false;
            dGVTradeBuy.Columns["NameUser"].Visible = false;
            dGVTradeBuy.Columns["ShareBidQty"].HeaderText = "Share Qty";
            dGVTradeBuy.Columns["ExecutedShareBidQty"].HeaderText = "Executed Qty";
            dGVTradeBuy.Columns["ShareBidQty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dGVTradeBuy.Columns["ExecutedShareBidQty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dGVTradeBuy.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        public void SetSaleFiltrOrder(TradeFiltrOrder saleFO, long bidId)
        {
            saleDel = ClearFiltr;
            saleDel += saleFiltr;
            if (saleFO.Complete) saleDel += completeFiltr;
            string nameOrder = "IdBid";
            if (saleFO.Price) nameOrder = "Price";
            else if (saleFO.Name) nameOrder = "NameTrader";
            else if (saleFO.Date) nameOrder = "Date";
            IEnumerable<Bid> SaleList = observBid.Where(t => saleDel(t)).OrderCollection(nameOrder);
 
            dGVTradeSale.DataSource = null;
            observSaleBid.Clear();
            int index = 0;
            int i = 0;
            foreach (Bid b in SaleList)
            {
                observSaleBid.Add(b);
                if (b.IdBid == bidId) index = i;
                i++;
            }
            dGVTradeSale.DataSource = observSaleBid;
            dGVTradeSale.CurrentCell = dGVTradeSale[0, index];
            dGVTradeSale.Columns["TradeType"].Visible = false;
            dGVTradeSale.Columns["NameUser"].Visible = false;
            dGVTradeSale.Columns["ShareBidQty"].HeaderText = "Share Qty";
            dGVTradeSale.Columns["ExecutedShareBidQty"].HeaderText = "Executed Qty";
            dGVTradeSale.Columns["ShareBidQty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dGVTradeSale.Columns["ExecutedShareBidQty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dGVTradeSale.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        public int SeachBid (long idBid)
        {
            int i = 0;
            while (observBid[i].IdBid != idBid) i++;
            return i;
        }

        private void btnNewBid_Click(object sender, EventArgs e)
        {
            if (SelectedHolder == null) // We need holders menu
            {
                FormMain.selectHolderForm = new SelectHolder(FormMain, "NewBid");
                FormMain.selectHolderForm.Text = "Select holder";
                FormMain.selectHolderForm.Show();
            }
            else // We don't need holders menu
            {
                FormNewBid formNewBid = new FormNewBid(FormMain, this, SelectedHolder);
                formNewBid.Show();
            }
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            CurrentBuyRow = dGVTradeBuy.CurrentRow.Index;
            currentTrader = (long)dGVTradeBuy.CurrentRow.Cells["idTrader"].Value;
            currentShareType = (string)dGVTradeBuy.CurrentRow.Cells["ShareType"].Value;
            BidClosing(observBuyBid, CurrentBuyRow, "Sale");
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            CurrentSaleRow = dGVTradeSale.CurrentRow.Index;
            currentTrader = (long)dGVTradeSale.CurrentRow.Cells["idTrader"].Value;
            currentShareType = "";
            BidClosing(observSaleBid, CurrentSaleRow, "Buy");
        }
        
        // Filtr for holder menu to skip current trader (can't buy own shares) and holders, which don't have such type shares
        public bool ExcludeTraderAndNoOwner(HolderMenu holder)
        {
            if (holder.Id == currentTrader) return true;
            if (currentShareType == "common" && holder.CommonShare <= 0) return true;
            if (currentShareType == "prefer" && holder.PreferShare <= 0) return true;
            return false;
        }

 
        private void BidClosing(ObservableCollection<Bid> currentList, int currentRow, string typeBid)
        {
            if (currentList[currentRow].Complete || currentList[currentRow].Closed)
            {
                FormPrimary.MessageShowDialog(MessageList.BidCompleteClosed, MessageList.Info);
            }
            else
            {
                    if (SelectedHolder == null) // We need holders menu
                    {
                        FormMain.UnwantedHolder += ExcludeTraderAndNoOwner;
                        if (FormMain.selectHolderForm == null || FormMain.selectHolderForm.IsDisposed)
                            FormMain.selectHolderForm = new SelectHolder(FormMain, typeBid);
                        FormMain.selectHolderForm.Text = "Select holder";
                        FormMain.selectHolderForm.Show();
                    }
                    else // We don't need holders menu
                    {
                        formCloseBid = new FormCloseBid(FormMain,this, SelectedHolder, currentList[currentRow]);
                        if (formCloseBid.InitFormCloseBid()) formCloseBid?.Show();
                    }
            }
        }

        // Show bid with red back color, which control another user
        private void dGVTradeBuy_Paint(object sender, PaintEventArgs e)
        {
            foreach (DataGridViewRow row in dGVTradeBuy.Rows)
            {
                if ((Guid)row.Cells["NameUser"].Value != Guid.Empty)
                {
                    dGVTradeBuy.Rows[row.Index].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void dGVTradeSale_Paint(object sender, PaintEventArgs e)
        {
            foreach (DataGridViewRow row in dGVTradeSale.Rows)
            {
                if ((Guid)row.Cells["NameUser"].Value != Guid.Empty)
                {
                    dGVTradeSale.Rows[row.Index].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void btnDeleteBid_Click(object sender, EventArgs e)
        {
            CurrentBuyRow = dGVTradeBuy.CurrentRow.Index;
            CurrentSaleRow = dGVTradeSale.CurrentRow.Index;
            formDeleteBid?.Close();
            formDeleteBid = new FormDeleteBid(this);
            formDeleteBid.Show();
        }

        // Get and show new quotes
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PriceQuote.SaveNewQuote();
            dGVTradeQuote.DataSource = null;
            GetPriceQuote();
            btnRefresh.Enabled = false;
        }

        private void FormTrade_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FormMain.selectHolderForm != null)
            {
                FormMain.UnwantedHolder -= ExcludeTraderAndNoOwner;
                FormMain.selectHolderForm.Close();
            }

            formCloseBid?.Close();
            foForm?.Close();
            formDeleteBid?.Close();

            if (Cabinet != null)
            {
                Cabinet.Enabled = true;
                Cabinet.RefreshTrade();
            }
            FormPrimary.UnLockForm(openForms, formEnabled, this);
        }
    }
}
