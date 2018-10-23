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

using JointStockCompany;
using Win_Form_DB.Service;
using Win_Form_DB.DataView;
using Business;

namespace Win_Form_DB
{
    public partial class HolderOrderForm : Base
    {
        public FormPrimary FormMain;
        public long LastHolderId;
        public FormHolder HolderForm;
        public SelectHolder SelectForm;

        public HolderOrderForm(Form senderForm, SelectHolder selectForm, long lastHolderId)
        {
            InitializeComponent();
            LastHolderId = lastHolderId;
            SelectForm = selectForm;
            if (senderForm is FormPrimary)
            {
                FormMain = (FormPrimary)senderForm;
                switch (FormMain.CurrentOrderMenu)
                {
                    case HolderOrder.Id: { rBId.Checked = true; break; }
                    case HolderOrder.FirstName: { rBFirstName.Checked = true; break; }
                    case HolderOrder.SecondName: { rBSecondName.Checked = true; break; }
                }
                rBCommon.Visible = false;
                rBPrefer.Visible = false;
            }
            else
            {
                HolderForm = (FormHolder)senderForm;
                switch (HolderForm.CurrentOrder)
                {
                    case HolderOrder.Id: { rBId.Checked = true; break; }
                    case HolderOrder.FirstName: { rBFirstName.Checked = true; break; }
                    case HolderOrder.SecondName: { rBSecondName.Checked = true; break; }
                    case HolderOrder.CommonShare: { rBCommon.Checked = true; break; }
                    case HolderOrder.PreferShare: { rBPrefer.Checked = true; break; }
                }
            }
        }
    

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            FormPrimary.LabelMessage(lMessage, MessageList.PrepairHolders);
            Cursor OldCursor = Cursor.Current;
            Cursor = Cursors.WaitCursor;
            if (HolderForm != null)
            {
                if (rBId.Checked) HolderForm.CurrentOrder = HolderOrder.Id;
                else if (rBFirstName.Checked) HolderForm.CurrentOrder = HolderOrder.FirstName;
                else if (rBSecondName.Checked) HolderForm.CurrentOrder = HolderOrder.SecondName;
                else if (rBCommon.Checked) HolderForm.CurrentOrder = HolderOrder.CommonShare;
                else if (rBPrefer.Checked) HolderForm.CurrentOrder = HolderOrder.PreferShare;
                HolderForm.ShowOrder(HolderForm.CurrentOrder);
                if (FormPrimary.gui.IsPortionUse)
                {
                    HolderForm.GetPortionNearHolder(HolderForm.CurrentHolder);
                    HolderForm.leftHolderRow = 0;
                }
                else
                {
                    HolderForm.SetNewOrder(HolderForm.CurrentHolder);
                }
            }
            else
            {
                SelectForm?.seachHolderForm?.Close();
                IEnumerable<HolderMenu> order = null;
                ObservableCollection<HolderMenu> NewObservHolderMenu = new ObservableCollection<HolderMenu>();

                if (rBId.Checked) FormMain.CurrentOrderMenu = HolderOrder.Id;
                else if (rBFirstName.Checked) FormMain.CurrentOrderMenu = HolderOrder.FirstName;
                else if (rBSecondName.Checked) FormMain.CurrentOrderMenu = HolderOrder.SecondName;
                order = FormMain.selectHolderForm.filtredObservHolderMenu.OrderCollection(FormMain.CurrentOrderMenuString());
                int i = 0;
                int index = 0;
                LastHolderId = (long)FormMain.selectHolderForm.dGVHolder.CurrentRow.Cells["Id"].Value;
                foreach (HolderMenu h in order)
                {
                    NewObservHolderMenu.Add(h);
                    if (h.Id == LastHolderId) index = i;
                    i++;
                }
                FormMain.selectHolderForm.dGVHolder.DataSource = null;
                FormMain.selectHolderForm.filtredObservHolderMenu = NewObservHolderMenu;
                FormMain.selectHolderForm.dGVHolder.DataSource = FormMain.selectHolderForm.filtredObservHolderMenu;
                FormMain.selectHolderForm.dGVHolder.CurrentCell = FormMain.selectHolderForm.dGVHolder[0, index];
            }
            Cursor = OldCursor;
            FormPrimary.LabelMessage(lMessage, "");
        }
    }
}
