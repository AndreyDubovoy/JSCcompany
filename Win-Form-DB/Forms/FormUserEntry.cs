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

using Data;
using Win_Form_DB.Service;
using Business;
using JointStockCompany;
using Framework.Utils;
using Win_Form_DB.DataView;

namespace Win_Form_DB
{
    public partial class FormUserEntry : Base
    {
        private FormPrimary MainForm;

        public FormUserEntry(FormPrimary mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
            cBUser.Text = (string)cBUser.Items[0];
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Cursor OldCursor = Cursor.Current;
            try
            {
                Cursor = Cursors.WaitCursor;
                MainForm.UserName = cBUser.Text;
                FormPrimary.LabelMessage(lMessage,MessageList.GetSettings);
                lMessage.Visible = true;
                DataTable settingsTable = DataProvider.GetSettingsTable();
                FormPrimary.BaseSettingsDictionary = new Dictionary<string, string>();
                foreach (DataRow r in settingsTable.Rows)
                {
                    FormPrimary.BaseSettingsDictionary.Add(r.Field<string>("PropertyName").Trim(), r.Field<string>("PropertyValue").Trim());
                }

                DataTable holderDesign = DataProvider.GetDesingTable("Holder");
                Holder.HolderColumnStringLength = new Dictionary<string, int>();
                foreach (DataRow r in holderDesign.Rows)
                {
                    
                    if (!r.IsNull("character_maximum_length"))
                        Holder.HolderColumnStringLength.Add(r.Field<string>("column_name"), r.Field<int>("character_maximum_length"));
                }

                FormPrimary.LabelMessage(lMessage, MessageList.LoadHolders);
                DataTable holdersTable = Holder.GetHolderForMenu();

                MainForm.OperationAllowed();
                MainForm.UserGuid = Guid.NewGuid();
                MainForm.DrawName(FormPrimary.BaseSettingsDictionary["NameCompany"]);

                MainForm.Text = "USER : "+ MainForm.UserName;

                FormPrimary.LabelMessage(lMessage, MessageList.PrepairHolders);
                MainForm.observHolderMenu = new ObservableCollection<HolderMenu>();
                foreach (DataRow t in holdersTable.Rows)
                {
                    MainForm.observHolderMenu.Add(new HolderMenu()
                    {
                       Id = t.Field<int>("idHolder"),
                       FirstName = t.Field<string>("firstName"),
                       SecondName = t.Field<string>("secondName"),
                       CommonShare = t.Field<int>("CommonShareQty"),
                       PreferShare = t.Field<int>("PreferShareQty")
                    });
                }
                Close();
            }
            catch (ExDbException ex)
            {
                MainForm.UserName = "no define";
                FormPrimary.MessageShowDialog(ex.Message);
            }
            Cursor = OldCursor;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormUserEntry_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FormPrimary.BaseSettingsDictionary == null) MainForm.DrawName("Joint-Stock Company");
            else MainForm.DrawName(FormPrimary.BaseSettingsDictionary["NameCompany"]);
        }
    }
}
