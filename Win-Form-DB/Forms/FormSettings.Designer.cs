namespace Win_Form_DB
{
    partial class FormSettings
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCompany = new System.Windows.Forms.TabPage();
            this.tBComission = new System.Windows.Forms.TextBox();
            this.lComission = new System.Windows.Forms.Label();
            this.lDateEmission = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.tabPageHolderMenu = new System.Windows.Forms.TabPage();
            this.tBQueueLength = new System.Windows.Forms.TextBox();
            this.tBNextPortion = new System.Windows.Forms.TextBox();
            this.tBFirstPortion = new System.Windows.Forms.TextBox();
            this.lQueueLength = new System.Windows.Forms.Label();
            this.lNextPortion = new System.Windows.Forms.Label();
            this.lFirstPortion = new System.Windows.Forms.Label();
            this.tabPageTradeMenu = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tBPriceQuoteQuan = new System.Windows.Forms.TextBox();
            this.lQuoteLength = new System.Windows.Forms.Label();
            this.ldays = new System.Windows.Forms.Label();
            this.tBCutDays = new System.Windows.Forms.TextBox();
            this.lCutDayTrade = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cBPortionUse = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPageCompany.SuspendLayout();
            this.tabPageHolderMenu.SuspendLayout();
            this.tabPageTradeMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCompany);
            this.tabControl1.Controls.Add(this.tabPageHolderMenu);
            this.tabControl1.Controls.Add(this.tabPageTradeMenu);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(406, 286);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageCompany
            // 
            this.tabPageCompany.Controls.Add(this.tBComission);
            this.tabPageCompany.Controls.Add(this.lComission);
            this.tabPageCompany.Controls.Add(this.lDateEmission);
            this.tabPageCompany.Controls.Add(this.lName);
            this.tabPageCompany.Location = new System.Drawing.Point(4, 29);
            this.tabPageCompany.Name = "tabPageCompany";
            this.tabPageCompany.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCompany.Size = new System.Drawing.Size(398, 253);
            this.tabPageCompany.TabIndex = 0;
            this.tabPageCompany.Text = "Company";
            this.tabPageCompany.UseVisualStyleBackColor = true;
            // 
            // tBComission
            // 
            this.tBComission.Location = new System.Drawing.Point(197, 128);
            this.tBComission.Name = "tBComission";
            this.tBComission.Size = new System.Drawing.Size(100, 26);
            this.tBComission.TabIndex = 3;
            this.tBComission.Validated += new System.EventHandler(this.tBComission_Validated);
            // 
            // lComission
            // 
            this.lComission.AutoSize = true;
            this.lComission.Location = new System.Drawing.Point(6, 134);
            this.lComission.Name = "lComission";
            this.lComission.Size = new System.Drawing.Size(160, 20);
            this.lComission.TabIndex = 2;
            this.lComission.Text = "Sale trade comission:";
            // 
            // lDateEmission
            // 
            this.lDateEmission.AutoSize = true;
            this.lDateEmission.Location = new System.Drawing.Point(6, 76);
            this.lDateEmission.Name = "lDateEmission";
            this.lDateEmission.Size = new System.Drawing.Size(167, 20);
            this.lDateEmission.TabIndex = 1;
            this.lDateEmission.Text = "Primary emission date:";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(6, 23);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(124, 20);
            this.lName.TabIndex = 0;
            this.lName.Text = "Company name:";
            // 
            // tabPageHolderMenu
            // 
            this.tabPageHolderMenu.Controls.Add(this.cBPortionUse);
            this.tabPageHolderMenu.Controls.Add(this.tBQueueLength);
            this.tabPageHolderMenu.Controls.Add(this.tBNextPortion);
            this.tabPageHolderMenu.Controls.Add(this.tBFirstPortion);
            this.tabPageHolderMenu.Controls.Add(this.lQueueLength);
            this.tabPageHolderMenu.Controls.Add(this.lNextPortion);
            this.tabPageHolderMenu.Controls.Add(this.lFirstPortion);
            this.tabPageHolderMenu.Location = new System.Drawing.Point(4, 29);
            this.tabPageHolderMenu.Name = "tabPageHolderMenu";
            this.tabPageHolderMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHolderMenu.Size = new System.Drawing.Size(398, 253);
            this.tabPageHolderMenu.TabIndex = 1;
            this.tabPageHolderMenu.Text = "Holder Menu";
            this.tabPageHolderMenu.UseVisualStyleBackColor = true;
            // 
            // tBQueueLength
            // 
            this.tBQueueLength.Location = new System.Drawing.Point(192, 181);
            this.tBQueueLength.Name = "tBQueueLength";
            this.tBQueueLength.Size = new System.Drawing.Size(100, 26);
            this.tBQueueLength.TabIndex = 6;
            this.tBQueueLength.Validated += new System.EventHandler(this.tBOueueLength_Validated);
            // 
            // tBNextPortion
            // 
            this.tBNextPortion.Location = new System.Drawing.Point(192, 135);
            this.tBNextPortion.Name = "tBNextPortion";
            this.tBNextPortion.Size = new System.Drawing.Size(100, 26);
            this.tBNextPortion.TabIndex = 5;
            this.tBNextPortion.Validated += new System.EventHandler(this.tBNextPortion_Validated);
            // 
            // tBFirstPortion
            // 
            this.tBFirstPortion.Location = new System.Drawing.Point(192, 87);
            this.tBFirstPortion.Name = "tBFirstPortion";
            this.tBFirstPortion.Size = new System.Drawing.Size(100, 26);
            this.tBFirstPortion.TabIndex = 4;
            this.tBFirstPortion.Validated += new System.EventHandler(this.tBFirstPortion_Validated);
            // 
            // lQueueLength
            // 
            this.lQueueLength.AutoSize = true;
            this.lQueueLength.Location = new System.Drawing.Point(6, 187);
            this.lQueueLength.Name = "lQueueLength";
            this.lQueueLength.Size = new System.Drawing.Size(147, 20);
            this.lQueueLength.TabIndex = 2;
            this.lQueueLength.Text = "Trade queue length";
            // 
            // lNextPortion
            // 
            this.lNextPortion.AutoSize = true;
            this.lNextPortion.Location = new System.Drawing.Point(6, 141);
            this.lNextPortion.Name = "lNextPortion";
            this.lNextPortion.Size = new System.Drawing.Size(142, 20);
            this.lNextPortion.TabIndex = 1;
            this.lNextPortion.Text = "Next holder portion";
            // 
            // lFirstPortion
            // 
            this.lFirstPortion.AutoSize = true;
            this.lFirstPortion.Location = new System.Drawing.Point(6, 93);
            this.lFirstPortion.Name = "lFirstPortion";
            this.lFirstPortion.Size = new System.Drawing.Size(141, 20);
            this.lFirstPortion.TabIndex = 0;
            this.lFirstPortion.Text = "First holder portion";
            // 
            // tabPageTradeMenu
            // 
            this.tabPageTradeMenu.Controls.Add(this.label1);
            this.tabPageTradeMenu.Controls.Add(this.tBPriceQuoteQuan);
            this.tabPageTradeMenu.Controls.Add(this.lQuoteLength);
            this.tabPageTradeMenu.Controls.Add(this.ldays);
            this.tabPageTradeMenu.Controls.Add(this.tBCutDays);
            this.tabPageTradeMenu.Controls.Add(this.lCutDayTrade);
            this.tabPageTradeMenu.Location = new System.Drawing.Point(4, 29);
            this.tabPageTradeMenu.Name = "tabPageTradeMenu";
            this.tabPageTradeMenu.Size = new System.Drawing.Size(398, 253);
            this.tabPageTradeMenu.TabIndex = 2;
            this.tabPageTradeMenu.Text = "Trade Menu";
            this.tabPageTradeMenu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "last price quotes ";
            // 
            // tBPriceQuoteQuan
            // 
            this.tBPriceQuoteQuan.Location = new System.Drawing.Point(71, 97);
            this.tBPriceQuoteQuan.Name = "tBPriceQuoteQuan";
            this.tBPriceQuoteQuan.Size = new System.Drawing.Size(77, 26);
            this.tBPriceQuoteQuan.TabIndex = 4;
            this.tBPriceQuoteQuan.Validated += new System.EventHandler(this.tBPriceQuoteQuan_Validated);
            // 
            // lQuoteLength
            // 
            this.lQuoteLength.AutoSize = true;
            this.lQuoteLength.Location = new System.Drawing.Point(12, 103);
            this.lQuoteLength.Name = "lQuoteLength";
            this.lQuoteLength.Size = new System.Drawing.Size(53, 20);
            this.lQuoteLength.TabIndex = 3;
            this.lQuoteLength.Text = "Show ";
            // 
            // ldays
            // 
            this.ldays.AutoSize = true;
            this.ldays.Location = new System.Drawing.Point(325, 34);
            this.ldays.Name = "ldays";
            this.ldays.Size = new System.Drawing.Size(42, 20);
            this.ldays.TabIndex = 2;
            this.ldays.Text = "days";
            // 
            // tBCutDays
            // 
            this.tBCutDays.Location = new System.Drawing.Point(233, 28);
            this.tBCutDays.Name = "tBCutDays";
            this.tBCutDays.Size = new System.Drawing.Size(77, 26);
            this.tBCutDays.TabIndex = 1;
            this.tBCutDays.Validated += new System.EventHandler(this.tBCutDays_Validated);
            // 
            // lCutDayTrade
            // 
            this.lCutDayTrade.AutoSize = true;
            this.lCutDayTrade.Location = new System.Drawing.Point(12, 34);
            this.lCutDayTrade.Name = "lCutDayTrade";
            this.lCutDayTrade.Size = new System.Drawing.Size(207, 20);
            this.lCutDayTrade.TabIndex = 0;
            this.lCutDayTrade.Text = "Show complete trade during";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(45, 327);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 32);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(249, 327);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 32);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cBPortionUse
            // 
            this.cBPortionUse.AutoSize = true;
            this.cBPortionUse.Location = new System.Drawing.Point(10, 33);
            this.cBPortionUse.Name = "cBPortionUse";
            this.cBPortionUse.Size = new System.Drawing.Size(165, 24);
            this.cBPortionUse.TabIndex = 7;
            this.cBPortionUse.Text = "Use portion loading";
            this.cBPortionUse.UseVisualStyleBackColor = true;
            this.cBPortionUse.CheckedChanged += new System.EventHandler(this.cBPortionUse_CheckedChanged);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 382);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormSettings";
            this.Text = "Program Settings";
            this.tabControl1.ResumeLayout(false);
            this.tabPageCompany.ResumeLayout(false);
            this.tabPageCompany.PerformLayout();
            this.tabPageHolderMenu.ResumeLayout(false);
            this.tabPageHolderMenu.PerformLayout();
            this.tabPageTradeMenu.ResumeLayout(false);
            this.tabPageTradeMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCompany;
        private System.Windows.Forms.TabPage tabPageHolderMenu;
        private System.Windows.Forms.TextBox tBComission;
        private System.Windows.Forms.Label lComission;
        private System.Windows.Forms.Label lDateEmission;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lQueueLength;
        private System.Windows.Forms.Label lNextPortion;
        private System.Windows.Forms.Label lFirstPortion;
        private System.Windows.Forms.TextBox tBFirstPortion;
        private System.Windows.Forms.TextBox tBQueueLength;
        private System.Windows.Forms.TextBox tBNextPortion;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabPage tabPageTradeMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBPriceQuoteQuan;
        private System.Windows.Forms.Label lQuoteLength;
        private System.Windows.Forms.Label ldays;
        private System.Windows.Forms.TextBox tBCutDays;
        private System.Windows.Forms.Label lCutDayTrade;
        private System.Windows.Forms.CheckBox cBPortionUse;
    }
}