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
using Win_Form_DB.DataView;

namespace Win_Form_DB
{
    public partial class FormTradeFiltrOrder : Base
    {
        FormTrade LastForm;
        long CurrentBuy;
        long CurrentSale;

        public FormTradeFiltrOrder(FormTrade lastForm, long currentBuy, long currentSale)
        {
            InitializeComponent();
            LastForm = lastForm;
            CurrentBuy = currentBuy;
            CurrentSale = currentSale;
        }

        private void FormTradeFiltrOrder_Cancel(object sender, EventArgs e)
        {
            Close();
        }

        private void FormTradeFiltrOrder_Save(object sender, EventArgs e)
        {
            LastForm.buyFO.All = rBtnBuyAll.Checked;
            LastForm.buyFO.Complete = rBtnBuyComplete.Checked;
            LastForm.buyFO.Date = rBtnBuyDate.Checked;
            LastForm.buyFO.Price = rBtnBuyPrice.Checked;
            LastForm.buyFO.Name = rBtnBuyName.Checked;
            LastForm.SetBuyFiltrOrder(LastForm.buyFO, CurrentBuy);

            LastForm.saleFO.All = rBtnSaleAll.Checked;
            LastForm.saleFO.Complete = rBtnSaleComplete.Checked;
            LastForm.saleFO.Date = rBtnSaleDate.Checked;
            LastForm.saleFO.Price = rBtnSalePrice.Checked;
            LastForm.saleFO.Name = rBtnSaleName.Checked;
            LastForm.SetSaleFiltrOrder(LastForm.saleFO, CurrentSale);

            Close();
        }

        public void SetParamFiltrOrder(TradeFiltrOrder buyFO, TradeFiltrOrder saleFO)
        {
            rBtnBuyAll.Checked = buyFO.All;
            rBtnBuyComplete.Checked = buyFO.Complete;
            rBtnBuyDate.Checked = buyFO.Date ;
            rBtnBuyPrice.Checked = buyFO.Price ;
            rBtnBuyName.Checked = buyFO.Name;

            rBtnSaleAll.Checked = saleFO.All;
            rBtnSaleComplete.Checked = saleFO.Complete;
            rBtnSaleDate.Checked = saleFO.Date;
            rBtnSalePrice.Checked = saleFO.Price;
            rBtnSaleName.Checked = saleFO.Name;
        }
    }
}
