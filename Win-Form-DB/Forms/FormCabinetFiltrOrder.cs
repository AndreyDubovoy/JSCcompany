using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Win_Form_DB.DataView;

namespace Win_Form_DB
{
    public partial class FormCabinetFiltrOrder : Base
    {
        FormCabinet CabinetForm;

        public FormCabinetFiltrOrder(FormCabinet cabinetForm)
        {
            InitializeComponent();
            CabinetForm = cabinetForm;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void SetParamFiltrOrder(CabinetFilterOrder cabinetFO)
        {
            rBAllDays.Checked = CabinetForm.CabinetFO.AllDate;
            rBPeriod.Checked = !CabinetForm.CabinetFO.AllDate;
            dateFrom.Value = CabinetForm.CabinetFO.DateFrom;
            dateTo.Value = CabinetForm.CabinetFO.DateTo;

            cBAllTrade.Checked = CabinetForm.CabinetFO.TradeFilterAll;
            cBBuy.Checked = CabinetForm.CabinetFO.TradeFilterBuy;
            cBSale.Checked = CabinetForm.CabinetFO.TradeFilterSale;
            if (CabinetForm.CabinetFO.TradeOrderDate)
                rBDateTrade.Checked = true;
            else
                rBSumTrade.Checked = true;

            cBAllBalance.Checked = CabinetForm.CabinetFO.BalanceFilterAll;
            cBComission.Checked = CabinetForm.CabinetFO.BalanceFilterComission;
            cBDividends.Checked = CabinetForm.CabinetFO.BalanceFilterDividends;
            cBMoving.Checked = CabinetForm.CabinetFO.BalanceFilterMoving;
            cBTrade.Checked = CabinetForm.CabinetFO.BalanceFilterTrade;
            if (CabinetForm.CabinetFO.BalanceOrderDate)
                rBDateBalance.Checked = true;
            else
                rBSumBalance.Checked = true;
        }

        private void cBAllTrade_CheckedChanged(object sender, EventArgs e)
        {
            if (cBAllTrade.Checked)
            {
                cBBuy.Checked = false;
                cBSale.Checked = false;
            }
        }

        private void cBBuy_CheckedChanged(object sender, EventArgs e)
        {
            if (cBBuy.Checked) cBAllTrade.Checked = false;
        }

        private void cBSale_CheckedChanged(object sender, EventArgs e)
        {
           if (cBSale.Checked) cBAllTrade.Checked = false;
        }

        private void cBAllBalance_CheckedChanged(object sender, EventArgs e)
        {
            if (cBAllBalance.Checked)
            {
                cBComission.Checked = false;
                cBDividends.Checked = false;
                cBMoving.Checked = false;
                cBTrade.Checked = false;
            }
        }

        private void cBMoving_CheckedChanged(object sender, EventArgs e)
        {
            if (cBMoving.Checked) cBAllBalance.Checked = false;
        }

        private void cBTrade_CheckedChanged(object sender, EventArgs e)
        {
            if (cBTrade.Checked) cBAllBalance.Checked = false;
        }

        private void cBComission_CheckedChanged(object sender, EventArgs e)
        {
            if (cBComission.Checked) cBAllBalance.Checked = false;
        }

        private void cBDividends_CheckedChanged(object sender, EventArgs e)
        {
            if (cBDividends.Checked) cBAllBalance.Checked = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            CabinetForm.CabinetFO.AllDate = rBAllDays.Checked;
            CabinetForm.CabinetFO.DateFrom = dateFrom.Value;
            CabinetForm.CabinetFO.DateTo = dateTo.Value;
            CabinetForm.CabinetFO.TradeFilterAll = cBAllTrade.Checked;
            CabinetForm.CabinetFO.TradeFilterBuy = cBBuy.Checked;
            CabinetForm.CabinetFO.TradeFilterSale = cBSale.Checked;
            CabinetForm.CabinetFO.TradeOrderDate = rBDateTrade.Checked;
            CabinetForm.CabinetFO.BalanceFilterAll = cBAllBalance.Checked;
            CabinetForm.CabinetFO.BalanceFilterComission = cBComission.Checked;
            CabinetForm.CabinetFO.BalanceFilterDividends = cBDividends.Checked;
            CabinetForm.CabinetFO.BalanceFilterMoving = cBMoving.Checked;
            CabinetForm.CabinetFO.BalanceFilterTrade = cBTrade.Checked;
            CabinetForm.CabinetFO.BalanceOrderDate = rBDateBalance.Checked;

            CabinetForm.SetBalanceFiltrOrder(CabinetForm.CabinetFO);
            CabinetForm.SetTradeFiltrOrder(CabinetForm.CabinetFO);
        }
    }
}
