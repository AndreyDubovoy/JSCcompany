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
using Business;
using Win_Form_DB.DataView;

namespace Win_Form_DB
{
    public partial class FormRevenue : Base
    {
        private Holder Holder;
        private ShareCost costFrom;
        public FormCabinet CabinetForm;
        private ShareCost costTo;

        public FormRevenue(FormCabinet cabinetForm, Holder someHolder)
        {
            InitializeComponent();
            Holder = someHolder;
            CabinetForm = cabinetForm;
            dTPTo.Value = DateTime.Today;
            dTPFrom.Value = DateTime.Today.AddDays(-30);
            dTPFrom.MinDate = DateTime.Parse(FormPrimary.BaseSettingsDictionary["EmissionDate"]);
            dTPTo.MinDate = DateTime.Today.AddDays(-30);
            dTPTo.MaxDate = DateTime.Today;
            dTPFrom.MaxDate = DateTime.Today;
            Recount(dTPFrom.Value, dTPTo.Value);
        }

        public void Recount(DateTime dateFrom, DateTime dateTo)
        {
            DataTable dt = ShareTrade.TradePeriod(Holder, dateFrom, dateTo);
            if (dt.Rows.Count == 0)
            {
                lTradeCBA.Text = "0";
                lTradeCBQ.Text = "0";
                lTradeCBP.Text = "0";
                lTradeCSA.Text = "0";
                lTradeCSQ.Text = "0";
                lTradeCSP.Text = "0";
                lTradePBA.Text = "0";
                lTradePBQ.Text = "0";
                lTradePBP.Text = "0";
                lTradePSA.Text = "0";
                lTradePSQ.Text = "0";
                lTradePSP.Text = "0";
                lTradeC.Text = "0";
            }
            else
            {
                lTradeCBA.Text = Math.Round((dt.Rows[0].IsNull("commonBuyAmount") ? 0 : dt.Rows[0].Field<decimal>("commonBuyAmount")),2).ToString();
                lTradeCBQ.Text = (dt.Rows[0].IsNull("commonBuy") ? 0 : dt.Rows[0].Field<int>("commonBuy")).ToString();
                lTradeCBP.Text = Int32.Parse(lTradeCBQ.Text) == 0 ? "0" :
                    Math.Round(Decimal.Parse(lTradeCBA.Text) / Int32.Parse(lTradeCBQ.Text), 2).ToString();
                lTradeCSA.Text = Math.Round((dt.Rows[0].IsNull("commonSaleAmount") ? 0 : dt.Rows[0].Field<decimal>("commonSaleAmount")),2).ToString();
                lTradeCSQ.Text = (dt.Rows[0].IsNull("commonSale") ? 0 : dt.Rows[0].Field<int>("commonSale")).ToString();
                lTradeCSP.Text = Int32.Parse(lTradeCSQ.Text) == 0 ? "0" :
                    Math.Round(Decimal.Parse(lTradeCSA.Text) / Int32.Parse(lTradeCSQ.Text), 2).ToString();
                lTradePBA.Text = Math.Round((dt.Rows[0].IsNull("preferBuyAmount") ? 0 : dt.Rows[0].Field<decimal>("preferBuyAmount")),2).ToString();
                lTradePBQ.Text = (dt.Rows[0].IsNull("preferBuy") ? 0 : dt.Rows[0].Field<int>("preferBuy")).ToString();
                lTradePBP.Text = Int32.Parse(lTradePBQ.Text) == 0 ? "0" :
                    Math.Round(Decimal.Parse(lTradePBA.Text) / Int32.Parse(lTradePBQ.Text), 2).ToString();
                lTradePSA.Text = Math.Round((dt.Rows[0].IsNull("preferSaleAmount") ? 0 : dt.Rows[0].Field<decimal>("preferSaleAmount")),2).ToString();
                lTradePSQ.Text = (dt.Rows[0].IsNull("preferSale") ? 0 : dt.Rows[0].Field<int>("preferSale")).ToString();
                lTradePSP.Text = Int32.Parse(lTradePSQ.Text) == 0 ? "0" :
                    Math.Round(Decimal.Parse(lTradePSA.Text) / Int32.Parse(lTradePSQ.Text), 2).ToString();
                lTradeC.Text = Math.Round((dt.Rows[0].IsNull("comission") ? 0 : dt.Rows[0].Field<decimal>("comission")),2).ToString();
            }

            DataTable dt1 = DivHolder.DividendPeriod(Holder, dateFrom, dateTo);
            if (dt1.Rows.Count == 0) lTradeD.Text = "0";
            else lTradeD.Text = Math.Round((dt1.Rows[0].IsNull("dividend") ? 0 : dt1.Rows[0].Field<decimal>("dividend")),2).ToString();

            lTradeT.Text = Math.Round((Decimal.Parse(lTradeCSA.Text) + Decimal.Parse(lTradePSA.Text)
                          - Decimal.Parse(lTradeCBA.Text) - Decimal.Parse(lTradePBA.Text)
                          + Decimal.Parse(lTradeD.Text) - Decimal.Parse(lTradeC.Text)),2).ToString();

            costFrom = ShareCost.GetCostDate(dateFrom, true, Holder);
            lFromQC.Text = costFrom.Common.ToString();
            lFromQP.Text = costFrom.Prefer.ToString();
            lFromPC.Text = Math.Round(costFrom.PriceCommon,2).ToString();
            lFromPP.Text = Math.Round(costFrom.PricePrefer,2).ToString();
            lFromAC.Text = Math.Round((costFrom.Common * costFrom.PriceCommon),2).ToString();
            lFromAP.Text = Math.Round((costFrom.Prefer * costFrom.PricePrefer),2).ToString();
            lFromT.Text = Math.Round((costFrom.Common * costFrom.PriceCommon + costFrom.Prefer * costFrom.PricePrefer),2).ToString();

            costTo = ShareCost.GetCostDate(dateTo, false, Holder);
            lToQC.Text = costTo.Common.ToString();
            lToQP.Text = costTo.Prefer.ToString();
            lToPC.Text = Math.Round(costTo.PriceCommon,2).ToString();
            lToPP.Text = Math.Round(costTo.PricePrefer,2).ToString();
            lToAC.Text = Math.Round((costTo.Common * costTo.PriceCommon),2).ToString();
            lToAP.Text = Math.Round((costTo.Prefer * costTo.PricePrefer),2).ToString();
            lToT.Text = Math.Round((costTo.Common * costTo.PriceCommon + costTo.Prefer * costTo.PricePrefer),2).ToString();

            lRevenueP.Text = Math.Round((Decimal.Parse(lToT.Text) - Decimal.Parse(lFromT.Text) + Decimal.Parse(lTradeT.Text)),2).ToString();
        }

 

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRecount_Click(object sender, EventArgs e)
        {
            Recount(dTPFrom.Value, dTPTo.Value);
        }

        private void dTPFrom_Validated(object sender, EventArgs e)
        {
            dTPTo.MinDate = dTPFrom.Value;
        }

        private void dTPTo_Validated(object sender, EventArgs e)
        {
            dTPFrom.MaxDate = dTPTo.Value;
        }

        private void FormRevenue_FormClosing(object sender, FormClosingEventArgs e)
        {
            CabinetForm.Enabled = true;
        }
    }
}
