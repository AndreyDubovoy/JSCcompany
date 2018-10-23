namespace Win_Form_DB
{
    partial class FormCabinetFiltrOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gBDate = new System.Windows.Forms.GroupBox();
            this.rBPeriod = new System.Windows.Forms.RadioButton();
            this.rBAllDays = new System.Windows.Forms.RadioButton();
            this.lTo = new System.Windows.Forms.Label();
            this.lFrom = new System.Windows.Forms.Label();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.gBTrade = new System.Windows.Forms.GroupBox();
            this.gBFilterTrade = new System.Windows.Forms.GroupBox();
            this.cBSale = new System.Windows.Forms.CheckBox();
            this.cBBuy = new System.Windows.Forms.CheckBox();
            this.cBAllTrade = new System.Windows.Forms.CheckBox();
            this.gBOrderTrade = new System.Windows.Forms.GroupBox();
            this.rBSumTrade = new System.Windows.Forms.RadioButton();
            this.rBDateTrade = new System.Windows.Forms.RadioButton();
            this.gBBalance = new System.Windows.Forms.GroupBox();
            this.gBFilterBalance = new System.Windows.Forms.GroupBox();
            this.cBDividends = new System.Windows.Forms.CheckBox();
            this.cBComission = new System.Windows.Forms.CheckBox();
            this.cBTrade = new System.Windows.Forms.CheckBox();
            this.cBMoving = new System.Windows.Forms.CheckBox();
            this.cBAllBalance = new System.Windows.Forms.CheckBox();
            this.gBOrderBalance = new System.Windows.Forms.GroupBox();
            this.rBSumBalance = new System.Windows.Forms.RadioButton();
            this.rBDateBalance = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.gBDate.SuspendLayout();
            this.gBTrade.SuspendLayout();
            this.gBFilterTrade.SuspendLayout();
            this.gBOrderTrade.SuspendLayout();
            this.gBBalance.SuspendLayout();
            this.gBFilterBalance.SuspendLayout();
            this.gBOrderBalance.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBDate
            // 
            this.gBDate.Controls.Add(this.rBPeriod);
            this.gBDate.Controls.Add(this.rBAllDays);
            this.gBDate.Controls.Add(this.lTo);
            this.gBDate.Controls.Add(this.lFrom);
            this.gBDate.Controls.Add(this.dateTo);
            this.gBDate.Controls.Add(this.dateFrom);
            this.gBDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBDate.Location = new System.Drawing.Point(12, 12);
            this.gBDate.Name = "gBDate";
            this.gBDate.Size = new System.Drawing.Size(442, 94);
            this.gBDate.TabIndex = 0;
            this.gBDate.TabStop = false;
            this.gBDate.Text = "Date";
            // 
            // rBPeriod
            // 
            this.rBPeriod.AutoSize = true;
            this.rBPeriod.Location = new System.Drawing.Point(6, 56);
            this.rBPeriod.Name = "rBPeriod";
            this.rBPeriod.Size = new System.Drawing.Size(72, 24);
            this.rBPeriod.TabIndex = 5;
            this.rBPeriod.Text = "Period";
            this.rBPeriod.UseVisualStyleBackColor = true;
            // 
            // rBAllDays
            // 
            this.rBAllDays.AutoSize = true;
            this.rBAllDays.Checked = true;
            this.rBAllDays.Location = new System.Drawing.Point(6, 25);
            this.rBAllDays.Name = "rBAllDays";
            this.rBAllDays.Size = new System.Drawing.Size(81, 24);
            this.rBAllDays.TabIndex = 4;
            this.rBAllDays.TabStop = true;
            this.rBAllDays.Text = "All days";
            this.rBAllDays.UseVisualStyleBackColor = true;
            // 
            // lTo
            // 
            this.lTo.AutoSize = true;
            this.lTo.Location = new System.Drawing.Point(334, 22);
            this.lTo.Name = "lTo";
            this.lTo.Size = new System.Drawing.Size(27, 20);
            this.lTo.TabIndex = 3;
            this.lTo.Text = "To";
            // 
            // lFrom
            // 
            this.lFrom.AutoSize = true;
            this.lFrom.Location = new System.Drawing.Point(154, 22);
            this.lFrom.Name = "lFrom";
            this.lFrom.Size = new System.Drawing.Size(46, 20);
            this.lFrom.TabIndex = 2;
            this.lFrom.Text = "From";
            // 
            // dateTo
            // 
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTo.Location = new System.Drawing.Point(271, 53);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(154, 26);
            this.dateTo.TabIndex = 1;
            // 
            // dateFrom
            // 
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFrom.Location = new System.Drawing.Point(102, 53);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(154, 26);
            this.dateFrom.TabIndex = 0;
            // 
            // gBTrade
            // 
            this.gBTrade.Controls.Add(this.gBFilterTrade);
            this.gBTrade.Controls.Add(this.gBOrderTrade);
            this.gBTrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBTrade.Location = new System.Drawing.Point(12, 112);
            this.gBTrade.Name = "gBTrade";
            this.gBTrade.Size = new System.Drawing.Size(200, 284);
            this.gBTrade.TabIndex = 1;
            this.gBTrade.TabStop = false;
            this.gBTrade.Text = "Trade";
            // 
            // gBFilterTrade
            // 
            this.gBFilterTrade.Controls.Add(this.cBSale);
            this.gBFilterTrade.Controls.Add(this.cBBuy);
            this.gBFilterTrade.Controls.Add(this.cBAllTrade);
            this.gBFilterTrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBFilterTrade.Location = new System.Drawing.Point(6, 128);
            this.gBFilterTrade.Name = "gBFilterTrade";
            this.gBFilterTrade.Size = new System.Drawing.Size(182, 150);
            this.gBFilterTrade.TabIndex = 3;
            this.gBFilterTrade.TabStop = false;
            this.gBFilterTrade.Text = "Filter";
            // 
            // cBSale
            // 
            this.cBSale.AutoSize = true;
            this.cBSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBSale.Location = new System.Drawing.Point(6, 101);
            this.cBSale.Name = "cBSale";
            this.cBSale.Size = new System.Drawing.Size(60, 24);
            this.cBSale.TabIndex = 2;
            this.cBSale.Text = "Sale";
            this.cBSale.UseVisualStyleBackColor = true;
            this.cBSale.CheckedChanged += new System.EventHandler(this.cBSale_CheckedChanged);
            // 
            // cBBuy
            // 
            this.cBBuy.AutoSize = true;
            this.cBBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBBuy.Location = new System.Drawing.Point(6, 71);
            this.cBBuy.Name = "cBBuy";
            this.cBBuy.Size = new System.Drawing.Size(55, 24);
            this.cBBuy.TabIndex = 1;
            this.cBBuy.Text = "Buy";
            this.cBBuy.UseVisualStyleBackColor = true;
            this.cBBuy.CheckedChanged += new System.EventHandler(this.cBBuy_CheckedChanged);
            // 
            // cBAllTrade
            // 
            this.cBAllTrade.AutoSize = true;
            this.cBAllTrade.Checked = true;
            this.cBAllTrade.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cBAllTrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBAllTrade.Location = new System.Drawing.Point(6, 25);
            this.cBAllTrade.Name = "cBAllTrade";
            this.cBAllTrade.Size = new System.Drawing.Size(87, 24);
            this.cBAllTrade.TabIndex = 0;
            this.cBAllTrade.Text = "Show all";
            this.cBAllTrade.UseVisualStyleBackColor = true;
            this.cBAllTrade.CheckedChanged += new System.EventHandler(this.cBAllTrade_CheckedChanged);
            // 
            // gBOrderTrade
            // 
            this.gBOrderTrade.Controls.Add(this.rBSumTrade);
            this.gBOrderTrade.Controls.Add(this.rBDateTrade);
            this.gBOrderTrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBOrderTrade.Location = new System.Drawing.Point(6, 25);
            this.gBOrderTrade.Name = "gBOrderTrade";
            this.gBOrderTrade.Size = new System.Drawing.Size(188, 100);
            this.gBOrderTrade.TabIndex = 0;
            this.gBOrderTrade.TabStop = false;
            this.gBOrderTrade.Text = "Order";
            // 
            // rBSumTrade
            // 
            this.rBSumTrade.AutoSize = true;
            this.rBSumTrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBSumTrade.Location = new System.Drawing.Point(6, 55);
            this.rBSumTrade.Name = "rBSumTrade";
            this.rBSumTrade.Size = new System.Drawing.Size(60, 24);
            this.rBSumTrade.TabIndex = 2;
            this.rBSumTrade.Text = "Sum";
            this.rBSumTrade.UseVisualStyleBackColor = true;
            // 
            // rBDateTrade
            // 
            this.rBDateTrade.AutoSize = true;
            this.rBDateTrade.Checked = true;
            this.rBDateTrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBDateTrade.Location = new System.Drawing.Point(6, 25);
            this.rBDateTrade.Name = "rBDateTrade";
            this.rBDateTrade.Size = new System.Drawing.Size(62, 24);
            this.rBDateTrade.TabIndex = 1;
            this.rBDateTrade.TabStop = true;
            this.rBDateTrade.Text = "Date";
            this.rBDateTrade.UseVisualStyleBackColor = true;
            // 
            // gBBalance
            // 
            this.gBBalance.Controls.Add(this.gBFilterBalance);
            this.gBBalance.Controls.Add(this.gBOrderBalance);
            this.gBBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBBalance.Location = new System.Drawing.Point(254, 112);
            this.gBBalance.Name = "gBBalance";
            this.gBBalance.Size = new System.Drawing.Size(200, 337);
            this.gBBalance.TabIndex = 2;
            this.gBBalance.TabStop = false;
            this.gBBalance.Text = "Balance";
            // 
            // gBFilterBalance
            // 
            this.gBFilterBalance.Controls.Add(this.cBDividends);
            this.gBFilterBalance.Controls.Add(this.cBComission);
            this.gBFilterBalance.Controls.Add(this.cBTrade);
            this.gBFilterBalance.Controls.Add(this.cBMoving);
            this.gBFilterBalance.Controls.Add(this.cBAllBalance);
            this.gBFilterBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBFilterBalance.Location = new System.Drawing.Point(12, 128);
            this.gBFilterBalance.Name = "gBFilterBalance";
            this.gBFilterBalance.Size = new System.Drawing.Size(182, 186);
            this.gBFilterBalance.TabIndex = 2;
            this.gBFilterBalance.TabStop = false;
            this.gBFilterBalance.Text = "Filter";
            // 
            // cBDividends
            // 
            this.cBDividends.AutoSize = true;
            this.cBDividends.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBDividends.Location = new System.Drawing.Point(6, 158);
            this.cBDividends.Name = "cBDividends";
            this.cBDividends.Size = new System.Drawing.Size(97, 24);
            this.cBDividends.TabIndex = 5;
            this.cBDividends.Text = "Dividends";
            this.cBDividends.UseVisualStyleBackColor = true;
            this.cBDividends.CheckedChanged += new System.EventHandler(this.cBDividends_CheckedChanged);
            // 
            // cBComission
            // 
            this.cBComission.AutoSize = true;
            this.cBComission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBComission.Location = new System.Drawing.Point(6, 128);
            this.cBComission.Name = "cBComission";
            this.cBComission.Size = new System.Drawing.Size(101, 24);
            this.cBComission.TabIndex = 4;
            this.cBComission.Text = "Comission";
            this.cBComission.UseVisualStyleBackColor = true;
            this.cBComission.CheckedChanged += new System.EventHandler(this.cBComission_CheckedChanged);
            // 
            // cBTrade
            // 
            this.cBTrade.AutoSize = true;
            this.cBTrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBTrade.Location = new System.Drawing.Point(6, 98);
            this.cBTrade.Name = "cBTrade";
            this.cBTrade.Size = new System.Drawing.Size(69, 24);
            this.cBTrade.TabIndex = 3;
            this.cBTrade.Text = "Trade";
            this.cBTrade.UseVisualStyleBackColor = true;
            this.cBTrade.CheckedChanged += new System.EventHandler(this.cBTrade_CheckedChanged);
            // 
            // cBMoving
            // 
            this.cBMoving.AutoSize = true;
            this.cBMoving.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBMoving.Location = new System.Drawing.Point(6, 68);
            this.cBMoving.Name = "cBMoving";
            this.cBMoving.Size = new System.Drawing.Size(78, 24);
            this.cBMoving.TabIndex = 2;
            this.cBMoving.Text = "Moving";
            this.cBMoving.UseVisualStyleBackColor = true;
            this.cBMoving.CheckedChanged += new System.EventHandler(this.cBMoving_CheckedChanged);
            // 
            // cBAllBalance
            // 
            this.cBAllBalance.AutoSize = true;
            this.cBAllBalance.Checked = true;
            this.cBAllBalance.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cBAllBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBAllBalance.Location = new System.Drawing.Point(6, 25);
            this.cBAllBalance.Name = "cBAllBalance";
            this.cBAllBalance.Size = new System.Drawing.Size(87, 24);
            this.cBAllBalance.TabIndex = 1;
            this.cBAllBalance.Text = "Show all";
            this.cBAllBalance.UseVisualStyleBackColor = true;
            this.cBAllBalance.CheckedChanged += new System.EventHandler(this.cBAllBalance_CheckedChanged);
            // 
            // gBOrderBalance
            // 
            this.gBOrderBalance.Controls.Add(this.rBSumBalance);
            this.gBOrderBalance.Controls.Add(this.rBDateBalance);
            this.gBOrderBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBOrderBalance.Location = new System.Drawing.Point(12, 25);
            this.gBOrderBalance.Name = "gBOrderBalance";
            this.gBOrderBalance.Size = new System.Drawing.Size(182, 100);
            this.gBOrderBalance.TabIndex = 1;
            this.gBOrderBalance.TabStop = false;
            this.gBOrderBalance.Text = "Order";
            // 
            // rBSumBalance
            // 
            this.rBSumBalance.AutoSize = true;
            this.rBSumBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBSumBalance.Location = new System.Drawing.Point(6, 55);
            this.rBSumBalance.Name = "rBSumBalance";
            this.rBSumBalance.Size = new System.Drawing.Size(83, 24);
            this.rBSumBalance.TabIndex = 1;
            this.rBSumBalance.Text = "Amount";
            this.rBSumBalance.UseVisualStyleBackColor = true;
            // 
            // rBDateBalance
            // 
            this.rBDateBalance.AutoSize = true;
            this.rBDateBalance.Checked = true;
            this.rBDateBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBDateBalance.Location = new System.Drawing.Point(6, 25);
            this.rBDateBalance.Name = "rBDateBalance";
            this.rBDateBalance.Size = new System.Drawing.Size(62, 24);
            this.rBDateBalance.TabIndex = 0;
            this.rBDateBalance.TabStop = true;
            this.rBDateBalance.Text = "Date";
            this.rBDateBalance.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(293, 468);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 37);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(49, 468);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(113, 37);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FormCabinetFiltrOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 517);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gBBalance);
            this.Controls.Add(this.gBTrade);
            this.Controls.Add(this.gBDate);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCabinetFiltrOrder";
            this.Text = "Cabinet Filtr and Order";
            this.gBDate.ResumeLayout(false);
            this.gBDate.PerformLayout();
            this.gBTrade.ResumeLayout(false);
            this.gBFilterTrade.ResumeLayout(false);
            this.gBFilterTrade.PerformLayout();
            this.gBOrderTrade.ResumeLayout(false);
            this.gBOrderTrade.PerformLayout();
            this.gBBalance.ResumeLayout(false);
            this.gBFilterBalance.ResumeLayout(false);
            this.gBFilterBalance.PerformLayout();
            this.gBOrderBalance.ResumeLayout(false);
            this.gBOrderBalance.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBDate;
        private System.Windows.Forms.RadioButton rBPeriod;
        private System.Windows.Forms.RadioButton rBAllDays;
        private System.Windows.Forms.Label lTo;
        private System.Windows.Forms.Label lFrom;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.GroupBox gBTrade;
        private System.Windows.Forms.GroupBox gBBalance;
        private System.Windows.Forms.GroupBox gBOrderTrade;
        private System.Windows.Forms.RadioButton rBSumTrade;
        private System.Windows.Forms.RadioButton rBDateTrade;
        private System.Windows.Forms.GroupBox gBFilterBalance;
        private System.Windows.Forms.GroupBox gBOrderBalance;
        private System.Windows.Forms.RadioButton rBSumBalance;
        private System.Windows.Forms.RadioButton rBDateBalance;
        private System.Windows.Forms.GroupBox gBFilterTrade;
        private System.Windows.Forms.CheckBox cBSale;
        private System.Windows.Forms.CheckBox cBBuy;
        private System.Windows.Forms.CheckBox cBAllTrade;
        private System.Windows.Forms.CheckBox cBDividends;
        private System.Windows.Forms.CheckBox cBComission;
        private System.Windows.Forms.CheckBox cBTrade;
        private System.Windows.Forms.CheckBox cBMoving;
        private System.Windows.Forms.CheckBox cBAllBalance;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}