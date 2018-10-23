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
using Framework.Utils;
using Win_Form_DB.Service;
using System.Data.SqlClient;
using Business;

namespace Win_Form_DB
{
    public partial class FormCloseBid : Base
    {
        public Holder SelectedHolder;
        public Holder TradeHolder;
        public FormPrimary MainForm;
        public FormTrade TradeForm;
        public Bid ClosingBid;
        private long maxQuantity;
        private bool stopSet = false;

        public FormCloseBid(FormPrimary mainForm, FormTrade tradeForm, Holder selectedHolder, Bid closingBid)
        {
            InitializeComponent();
            ClosingBid = closingBid;
            MainForm = mainForm;
            TradeForm = tradeForm;
            SelectedHolder = selectedHolder;
            TradeForm.Enabled = false;
        }

        public bool InitFormCloseBid()
        {
            if (SelectedHolder.Id == ClosingBid.IdTrader)
            {
                FormPrimary.MessageShowDialog(MessageList.BuyerSellerSame);
                TradeForm.Enabled = true;
                return false;
            }
            TradeForm.IsTradeAllowed = false;
            SqlException ex = Bid.ReserveBid(ClosingBid.IdBid, MainForm.UserGuid, true);
            if ( ex == null)
            {
                TradeHolder = Holder.GetOneHolder(ClosingBid.IdTrader);
                if (ClosingBid.TradeType == "sale")
                {
                    lNameTrade.Text = ClosingBid.IdTrader.ToString() + ' ' + ClosingBid.NameTrader;
                    lNameBuyer.Text = SelectedHolder.Id.ToString() + ' ' + SelectedHolder.FirstName + ' ' + SelectedHolder.SecondName;
                    lCurrentBalance.Text = SelectedHolder.Balance.ToString();
                    maxQuantity = ClosingBid.ShareBidQty - ClosingBid.ExecutedShareBidQty;
                }
                else
                {
                    lNameTrade.Text = SelectedHolder.Id.ToString() + ' ' + SelectedHolder.FirstName + ' ' + SelectedHolder.SecondName;
                    lNameBuyer.Text = ClosingBid.IdTrader.ToString() + ' ' + ClosingBid.NameTrader;
                    lCurrentBalance.Text = TradeHolder.Balance.ToString();
                    if (ClosingBid.ShareType == "common")
                    {
                        maxQuantity = (ClosingBid.ShareBidQty - ClosingBid.ExecutedShareBidQty) < SelectedHolder.CommonShare ?
                                        ClosingBid.ShareBidQty - ClosingBid.ExecutedShareBidQty : SelectedHolder.CommonShare;
                    }
                    else
                    {
                        maxQuantity = (ClosingBid.ShareBidQty - ClosingBid.ExecutedShareBidQty) < SelectedHolder.PreferShare ?
                                        ClosingBid.ShareBidQty - ClosingBid.ExecutedShareBidQty : SelectedHolder.PreferShare;
                    }
                }
                mTBQuantity.Text = maxQuantity.ToString();
                lShare.Text += ' ' + ClosingBid.ShareType;
                lCurrPrice.Text = ClosingBid.Price.ToString();
                lCurrentSum.Text = (Int32.Parse(mTBQuantity.Text) * ClosingBid.Price).ToString();
                return true;
            }
            else
            {
                FormPrimary.FormExeptionHandler(ex, ex.Message);
                TradeForm.IsTradeAllowed = true;
                TradeForm.Enabled = true;
                Close();
                return false;
            }
        }

        private void mTBQuantity_Validated(object sender, EventArgs e)
        {
            if(!FormPrimary.ValidateValue(mTBQuantity, maxQuantity, MessageList.IncorectShareQuantity))
            {
                stopSet = true;
            }
            if ( Int32.Parse(mTBQuantity.Text) > maxQuantity)
            {
                FormPrimary.MessageShowDialog(MessageList.QuantityIsMore);
                mTBQuantity.Text = maxQuantity.ToString();
                stopSet = true;
            }
            lCurrentSum.Text = (Int32.Parse(mTBQuantity.Text) * ClosingBid.Price).ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SqlException ex = Bid.ReserveBid(ClosingBid.IdBid, MainForm.UserGuid, false);
            if (ex != null) FormPrimary.FormExeptionHandler(ex, ex.Message);
            Close();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            int quantity = Int32.Parse(mTBQuantity.Text);
            if (quantity == 0 || stopSet)
            {
                FormPrimary.MessageShowDialog("Incorrect value");
                stopSet = false;
            }
            else
            {
                if ((ClosingBid.TradeType == "buy" && TradeHolder.Balance >= quantity * ClosingBid.Price)
                      || (ClosingBid.TradeType == "sale" && SelectedHolder.Balance >= quantity * ClosingBid.Price))
                {
                    SqlException ex = Bid.SaveExecutedBid(ClosingBid, quantity, SelectedHolder.Id,
                        Decimal.Parse(FormPrimary.BaseSettingsDictionary["TradeComission"]), MainForm.UserName);
                    if (ex == null)
                    {
                        // Operation has executed
                        FormPrimary.MessageShowDialog(MessageList.AgreementComplete, MessageList.Info);
                        long execQuantity;
                        if (ClosingBid.TradeType == "buy")
                        {
                            execQuantity = (long)TradeForm.dGVTradeBuy.CurrentRow.Cells["ExecutedShareBidQty"].Value + quantity;
                            TradeForm.dGVTradeBuy.CurrentRow.Cells["ExecutedShareBidQty"].Value = execQuantity;
                            if (ClosingBid.ShareBidQty == execQuantity)
                                TradeForm.dGVTradeBuy.CurrentRow.Cells["Complete"].Value = true;
                            TradeForm.dGVTradeBuy.Refresh();
                        }
                        else
                        {
                            execQuantity = (long)TradeForm.dGVTradeSale.CurrentRow.Cells["ExecutedShareBidQty"].Value + quantity;
                            TradeForm.dGVTradeSale.CurrentRow.Cells["ExecutedShareBidQty"].Value = execQuantity;
                            if (ClosingBid.ShareBidQty == execQuantity)
                                TradeForm.dGVTradeSale.CurrentRow.Cells["Complete"].Value = true;
                            TradeForm.dGVTradeSale.Refresh();
                        }
                        TradeForm.observBid[TradeForm.SeachBid(ClosingBid.IdBid)].ExecutedShareBidQty = execQuantity;
                        if (ClosingBid.ShareBidQty == execQuantity)
                            TradeForm.observBid[TradeForm.SeachBid(ClosingBid.IdBid)].Complete = true;
                    }
                    else
                    {
                        // Operation error
                        FormPrimary.MessageShowDialog(MessageList.AgreementRejection);
                        FormPrimary.FormExeptionHandler(ex, ex.Message);
                    }
                    Close();
                }
                else
                {
                    FormPrimary.MessageShowDialog(MessageList.NotEnoughBalance);
                    SqlException ex = Bid.ReserveBid(ClosingBid.IdBid, MainForm.UserGuid, false);
                    if (ex != null) FormPrimary.FormExeptionHandler(ex, ex.Message);
                }
            }

        }

        private void FormCloseBid_FormClosing(object sender, FormClosingEventArgs e)
        {
            SqlException ex = Bid.ReserveBid(ClosingBid.IdBid, MainForm.UserGuid, false);
            if (ex != null) FormPrimary.FormExeptionHandler(ex, ex.Message);
            if (TradeForm.SelectedHolder != null)TradeForm.IsTradeAllowed = true;
            TradeForm.Enabled = true;
        }
    }
}
