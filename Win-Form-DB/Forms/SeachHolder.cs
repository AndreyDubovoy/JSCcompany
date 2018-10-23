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
using JointStockCompany;

namespace Win_Form_DB
{
    public partial class SeachHolder : Base
    {
        public FormPrimary FormMain;
        private AutoCompleteStringCollection firstNamesource;
        private AutoCompleteStringCollection secondNamesource;

        public SeachHolder(FormPrimary formMain)
        {
            InitializeComponent();
            FormMain = formMain;
            firstNamesource = new AutoCompleteStringCollection();
            secondNamesource = new AutoCompleteStringCollection();
            InitStringCollection();

            tBFirstName.AutoCompleteCustomSource = firstNamesource;
            tBFirstName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tBFirstName.AutoCompleteSource = AutoCompleteSource.CustomSource;

            tBSecondName.AutoCompleteCustomSource = secondNamesource;
            tBSecondName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tBSecondName.AutoCompleteSource = AutoCompleteSource.CustomSource;
           
        }

        public void InitStringCollection ()
        {
            firstNamesource.Clear();
            secondNamesource.Clear();
            foreach (HolderMenu h in FormMain.selectHolderForm.filtredObservHolderMenu)
            {
                firstNamesource.Add(h.FirstName);
                secondNamesource.Add(h.SecondName);
            }
        }

        private void tBSecondName_Enter(object sender, EventArgs e)
        {
            string sName = "";
            string fName = "";
            int indexRow = tBSecondName.AutoCompleteCustomSource.IndexOf(tBSecondName.Text);
            if (indexRow >= 0)
            {
                FormMain.selectHolderForm.goToHolder(indexRow, out fName, out sName);
                tBFirstName.Enabled = false;
            }
            else tBFirstName.Enabled = true;
            tBFirstName.Text = fName;
            tBSecondName.Text = sName;
        }

        private void btnGoTo_Click(object sender, EventArgs e)
        {
            string sName = "";
            string fName = "";
            int indexRow = tBSecondName.AutoCompleteCustomSource.IndexOf(tBSecondName.Text);
            if (indexRow >= 0) FormMain.selectHolderForm.goToHolder(indexRow, out fName, out sName);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tBFirstName_Enter(object sender, EventArgs e)
        {
            string sName = "";
            string fName = "";
            int indexRow = tBFirstName.AutoCompleteCustomSource.IndexOf(tBFirstName.Text);
            if (indexRow >= 0)
            {
                FormMain.selectHolderForm.goToHolder(indexRow, out fName, out sName);
                tBSecondName.Enabled = false;
            }
            else tBSecondName.Enabled = true;
            tBFirstName.Text = fName;
            tBSecondName.Text = sName;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tBFirstName.Text = "";
            tBSecondName.Text = "";
            tBFirstName.Enabled = true;
            tBSecondName.Enabled = true;
        }
    }
}
