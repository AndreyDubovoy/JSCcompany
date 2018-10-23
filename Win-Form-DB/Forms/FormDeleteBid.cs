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
    public partial class FormDeleteBid : Base
    {
        private FormTrade TradeForm;
        private Bid CurrentBid;

        public FormDeleteBid(FormTrade tradeForm)
        {
            InitializeComponent();
            TradeForm = tradeForm;
            TradeForm.IsTradeAllowed = false;
            rBforSale.Checked = true;
        }

        private void rB_CheckedChanged(object sender, EventArgs e)
        {
            if (rBforSale.Checked == true)
            {
                CurrentBid = TradeForm.observBuyBid[TradeForm.CurrentBuyRow];
                lidSale.Text = "Id Bid = " + TradeForm.observBuyBid[TradeForm.CurrentBuyRow].IdBid.ToString();
            }
            else
            {
                CurrentBid = TradeForm.observSaleBid[TradeForm.CurrentSaleRow];
                lidBuy.Text = "Id Bid = " + TradeForm.observSaleBid[TradeForm.CurrentSaleRow].IdBid.ToString();
            }
            DrawCurrentBid(CurrentBid);
        }

        private void DrawCurrentBid(Bid currentBid)
        {
            lDate.Text = currentBid.Date.ToString();
            lHolder.Text = "Trader Id = " + currentBid.IdTrader.ToString() + " " + currentBid.NameTrader;
            lShare.Text = "Share type : " + currentBid.ShareType;
            lPrice.Text = "Price : " + currentBid.Price.ToString();
            lFullQuantity.Text = "Full quantity : " + currentBid.ShareBidQty.ToString();
            lExecutedQuantity.Text = "Executed quantity : " + currentBid.ExecutedShareBidQty.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (CurrentBid.Complete || CurrentBid.Closed)
            {
                FormPrimary.MessageShowDialog(MessageList.BidClosed, MessageList.Info);
            }
            else
            {
                Bid.CloseBid(CurrentBid.IdBid);
                TradeForm.observBid[TradeForm.SeachBid(CurrentBid.IdBid)].Closed = true;
                if (rBforSale.Checked == true)
                {
                    TradeForm.dGVTradeBuy.CurrentRow.Cells["Closed"].Value = true;
                    TradeForm.dGVTradeBuy.Refresh();
                }
                else
                {
                    TradeForm.dGVTradeSale.CurrentRow.Cells["Closed"].Value = true;
                    TradeForm.dGVTradeSale.Refresh();
                }
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormDeleteBid_FormClosing(object sender, FormClosingEventArgs e)
        {
            TradeForm.IsTradeAllowed = true;
        }
    }
}
