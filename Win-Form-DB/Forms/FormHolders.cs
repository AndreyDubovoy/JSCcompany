using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using JointStockCompany;
using Data;

using Win_Form_DB.DataView;
using Win_Form_DB.Service;
using Business;

namespace Win_Form_DB
{
    public partial class FormHolder : Base
    {
        public HolderOrder CurrentOrder = HolderOrder.Id;
        public int CurrentPortionData;
        public Holder CurrentHolder;
        public FormPrimary MainForm ;
        public NewHolder newHolderForm;
        public HolderOrderForm holdersOrderForm;

        private int rowIndex;
        public int leftHolderRow = 0;

        private BindingList<ShareTrade> bindingTrade; // Collection for one trade history
        public  BindingList<Holder> bindingHolder;
        public Queue<QueueTrade> queueTrade; // Collection for some trade historys

        public FormHolder()
        {
            InitializeComponent();
        }

        public FormHolder(FormPrimary formMain)
        {
            InitializeComponent();
            Cursor OldCursor = Cursor.Current;
            Cursor = Cursors.WaitCursor;
            MainForm = formMain;
            ShowOrder(CurrentOrder);
            DataTable portionHolder = new DataTable();
            bindingHolder = new BindingList<Holder>();
            if (FormPrimary.gui.IsPortionUse)
            {
                portionHolder = Holder.GetHolderTable(FormPrimary.gui.FirstHolderPortion);
            }
            else
            {
                FormPrimary.LabelMessage(MainForm.lMessage, MessageList.LoadHolders);
                portionHolder = Holder.GetHolderTable(0);
                gridHolder.Scroll -= gridHolder_Scroll;
 
            }
            FormPrimary.LabelMessage(MainForm.lMessage, MessageList.PrepairHolders);
            foreach (DataRow t in portionHolder.Rows)  bindingHolder.Add(Holder.TableToBindingHolder(t));

            gridHolder.AutoResizeColumns();
            gridHolder.DataSource = bindingHolder;
            SetGridHolderParam();
            CurrentPortionData = bindingHolder.Count;
            lqty.Text = CurrentPortionData.ToString();

            bindingTrade = new BindingList<ShareTrade>();
            queueTrade = new Queue<QueueTrade>();
            timerTrade.Interval = 1000;
            FormPrimary.LabelMessage(MainForm.lMessage, "");
            Cursor = OldCursor;
        }

        public void ShowOrder(HolderOrder someOrder)
        {
            lOrder.Text = "Current order: " + someOrder.ToString();
        }

        private void SetGridHolderParam()
        {
            gridHolder.Columns["commonShare"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridHolder.Columns["PreferShare"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridHolder.Columns["Balance"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void gridHolder_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            leftHolderRow = e.RowIndex;
        }

        private void  gridHolder_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            CurrentHolder = bindingHolder[rowIndex];
            lHolder.Text = "Current holder: " + CurrentHolder.FirstName.Trim() + " " + CurrentHolder.SecondName.Trim();
            timerTrade.Enabled = true;
        }

         public  void GetPortionTrade(Holder lastHolder) 
        {
           // Control UP or DOWN we move cursor on FIRST or LAST row in dataGrid
            if ((rowIndex == CurrentPortionData - 1 || rowIndex == 0) & rowIndex != leftHolderRow & FormPrimary.gui.IsPortionUse)
            {
                string UpDown = rowIndex == 0 ? "DESC" : "ASC";
                GetNextPortion(FormPrimary.gui.NextHolderPortion, lastHolder, CurrentOrder, UpDown);
            }

            bindingTrade = new BindingList<ShareTrade>();
            bool foundTrade = false;
            for (int i = 0; i < queueTrade.Count; i++) // Control for current trade history in our queue
            {
                if (queueTrade.ElementAt(i).IdTrade == lastHolder.Id)
                {
                    bindingTrade = queueTrade.ElementAt(i).TradeList;
                    int ii = queueTrade.ElementAt(i).TradeList.Count;
                    foundTrade = true;
                    i = queueTrade.Count;
                }
            }
            if (!foundTrade) // Save current trade history in our queue
            {
                ShareTrade.GetTrade(lastHolder, bindingTrade);
                queueTrade.Enqueue(new QueueTrade(lastHolder.Id, bindingTrade));
                if (queueTrade.Count > FormPrimary.gui.TradeQueueLength ) queueTrade.Dequeue();
            }
            gridTrade.DataSource = bindingTrade;
            gridTrade.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridTrade.Columns["ShareQty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        // Get new trade history from data base
 

        public void GetPortionNearHolder(Holder someHolder)
        {
            leftHolderRow = 0;
            gridHolder.DataSource = null;
            bindingHolder.Clear();
            bindingHolder.Add(someHolder);
            gridHolder.DataSource = bindingHolder;
            SetGridHolderParam();
            CurrentPortionData = 1;
            int portionDESC;
            portionDESC = GetNextPortion(FormPrimary.gui.FirstHolderPortion / 2, someHolder, CurrentOrder, "DESC");
            GetNextPortion(FormPrimary.gui.FirstHolderPortion - CurrentPortionData, someHolder, CurrentOrder, "ASC");
            if (CurrentPortionData < FormPrimary.gui.FirstHolderPortion)
            {
               portionDESC = GetNextPortion(FormPrimary.gui.FirstHolderPortion - CurrentPortionData, bindingHolder[0], CurrentOrder, "DESC");
            }
            gridHolder.Select();
            if (portionDESC >0) gridHolder.FirstDisplayedScrollingRowIndex = 1;
        }

        public int GetNextPortion(int portion, Holder currentHolder,  HolderOrder currentOrder, string upDown)
        {
            gridHolder.Enabled = false;
            leftHolderRow = 0;
            DataTable portionHolder = new DataTable();
            Holder someHolder;
            portionHolder = Holder.GetHolderTableNextPortion(portion, currentHolder, currentOrder, upDown);
            foreach (DataRow t in portionHolder.Rows)
            {
                someHolder = Holder.TableToBindingHolder(t);
                if (upDown == "DESC")
                {
                    bindingHolder.Insert(0, someHolder);
                    CurrentPortionData += 1;
                }
                else
                {
                    bindingHolder.Add(someHolder);
                    CurrentPortionData += 1;
                }
            }
            lqty.Text = CurrentPortionData.ToString();
            lqty.Refresh();
            gridHolder.Enabled = true;
            gridHolder.Select();
            return portionHolder.Rows.Count;
        }

 

        private void btnNewHolder_Click(object sender, EventArgs e)
        {
            Enabled = false;
            newHolderForm?.Close();
            newHolderForm = new NewHolder (this,null,CurrentOrder);
            newHolderForm.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            holdersOrderForm?.Close();
            holdersOrderForm = new HolderOrderForm(this,null,CurrentHolder.Id);
            holdersOrderForm.Show();
         }

        private void timerTrade_Tick(object sender, EventArgs e) // Get and show trade history for current holder
        {
            GetPortionTrade(CurrentHolder);
            timerTrade.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Enabled = false;
            newHolderForm?.Close();
            newHolderForm = new NewHolder(this, bindingHolder[gridHolder.CurrentRow.Index],CurrentOrder);
            newHolderForm.Show();
        }

        private void FormHolder_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.Enabled = true;
            newHolderForm?.Close();
            holdersOrderForm?.Close();
        }

        private void gridHolder_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                Int32 lengthListHolders = bindingHolder.Count();
                if (e.NewValue == 0)
                {
                    if (GetNextPortion(FormPrimary.gui.NextHolderPortion, bindingHolder.First(), CurrentOrder, "DESC") > 0)
                        gridHolder.FirstDisplayedScrollingRowIndex = 1;
                }
                else if (e.NewValue == lengthListHolders-gridHolder.DisplayedRowCount(false))
                {
                    GetNextPortion(FormPrimary.gui.NextHolderPortion, bindingHolder.Last(), CurrentOrder, "ASC");
                }
            }
        }

        public void DrawPortion()
        {
            CurrentPortionData += 1;
            lqty.Text = CurrentPortionData.ToString();
        }

        public void SetNewOrder(Holder currentHolder)
        {
            IEnumerable<Holder> order = bindingHolder.OrderCollection(CurrentOrder.ToString());
            BindingList<Holder> NewBindingHolder = new BindingList<Holder>();
            int index = 0;
            //   BindingList<Holder> NewBindingHolder = (BindingList<Holder>)OrderCollectionWithIndex(HolderForm.bindingHolder, HolderForm.CurrentOrder, (h) => h.Id == HolderForm.CurrentHolder.Id, out index);
            int i = 0;
            foreach (Holder h in order)
            {
                NewBindingHolder.Add(h);
                if (h.Id == currentHolder.Id) index = i;
                i++;
            }
            gridHolder.DataSource = null;
            bindingHolder = NewBindingHolder;
            gridHolder.DataSource = bindingHolder;
            gridHolder.CurrentCell = gridHolder[0, index];
        }

        public static void ChangeNameInTrade(Queue<QueueTrade> queueTrade , Holder changedHolder)
        {
            string newName = changedHolder.FirstName + " " + changedHolder.SecondName;
            foreach (QueueTrade qt in queueTrade)
            {
                foreach (ShareTrade st in qt.TradeList)
                {
                    if (st.IdPurchaser == changedHolder.Id) st.NamePurchaser = newName;
                    if (st.IdSeller == changedHolder.Id) st.NameSeller = newName;
                }
            }
        }
    }
}
