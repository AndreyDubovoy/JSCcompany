namespace Win_Form_DB
{
    partial class FormCloseBid
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
            this.lNameTrade = new System.Windows.Forms.Label();
            this.lShare = new System.Windows.Forms.Label();
            this.mTBQuantity = new System.Windows.Forms.MaskedTextBox();
            this.lPrice = new System.Windows.Forms.Label();
            this.gBSeller = new System.Windows.Forms.GroupBox();
            this.lCurrPrice = new System.Windows.Forms.Label();
            this.gBBuyer = new System.Windows.Forms.GroupBox();
            this.lCurrentSum = new System.Windows.Forms.Label();
            this.lCurrentBalance = new System.Windows.Forms.Label();
            this.lSum = new System.Windows.Forms.Label();
            this.lBalance = new System.Windows.Forms.Label();
            this.lNameBuyer = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.gBSeller.SuspendLayout();
            this.gBBuyer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lNameTrade
            // 
            this.lNameTrade.AutoSize = true;
            this.lNameTrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameTrade.Location = new System.Drawing.Point(6, 16);
            this.lNameTrade.Name = "lNameTrade";
            this.lNameTrade.Size = new System.Drawing.Size(51, 20);
            this.lNameTrade.TabIndex = 0;
            this.lNameTrade.Text = "Name";
            // 
            // lShare
            // 
            this.lShare.AutoSize = true;
            this.lShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShare.Location = new System.Drawing.Point(6, 47);
            this.lShare.Name = "lShare";
            this.lShare.Size = new System.Drawing.Size(52, 20);
            this.lShare.TabIndex = 1;
            this.lShare.Text = "Share";
            // 
            // mTBQuantity
            // 
            this.mTBQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTBQuantity.Location = new System.Drawing.Point(166, 41);
            this.mTBQuantity.Mask = "00000";
            this.mTBQuantity.Name = "mTBQuantity";
            this.mTBQuantity.Size = new System.Drawing.Size(85, 26);
            this.mTBQuantity.TabIndex = 7;
            this.mTBQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mTBQuantity.ValidatingType = typeof(int);
            this.mTBQuantity.Validated += new System.EventHandler(this.mTBQuantity_Validated);
            // 
            // lPrice
            // 
            this.lPrice.AutoSize = true;
            this.lPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPrice.Location = new System.Drawing.Point(6, 79);
            this.lPrice.Name = "lPrice";
            this.lPrice.Size = new System.Drawing.Size(44, 20);
            this.lPrice.TabIndex = 8;
            this.lPrice.Text = "Price";
            // 
            // gBSeller
            // 
            this.gBSeller.Controls.Add(this.lCurrPrice);
            this.gBSeller.Controls.Add(this.lNameTrade);
            this.gBSeller.Controls.Add(this.mTBQuantity);
            this.gBSeller.Controls.Add(this.lPrice);
            this.gBSeller.Controls.Add(this.lShare);
            this.gBSeller.Location = new System.Drawing.Point(12, 12);
            this.gBSeller.Name = "gBSeller";
            this.gBSeller.Size = new System.Drawing.Size(329, 121);
            this.gBSeller.TabIndex = 9;
            this.gBSeller.TabStop = false;
            this.gBSeller.Text = "Seller";
            // 
            // lCurrPrice
            // 
            this.lCurrPrice.AutoSize = true;
            this.lCurrPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCurrPrice.Location = new System.Drawing.Point(180, 79);
            this.lCurrPrice.Name = "lCurrPrice";
            this.lCurrPrice.Size = new System.Drawing.Size(45, 20);
            this.lCurrPrice.TabIndex = 9;
            this.lCurrPrice.Text = "Sum";
            // 
            // gBBuyer
            // 
            this.gBBuyer.Controls.Add(this.lCurrentSum);
            this.gBBuyer.Controls.Add(this.lCurrentBalance);
            this.gBBuyer.Controls.Add(this.lSum);
            this.gBBuyer.Controls.Add(this.lBalance);
            this.gBBuyer.Controls.Add(this.lNameBuyer);
            this.gBBuyer.Location = new System.Drawing.Point(12, 139);
            this.gBBuyer.Name = "gBBuyer";
            this.gBBuyer.Size = new System.Drawing.Size(329, 139);
            this.gBBuyer.TabIndex = 10;
            this.gBBuyer.TabStop = false;
            this.gBBuyer.Text = "Buyer";
            // 
            // lCurrentSum
            // 
            this.lCurrentSum.AutoSize = true;
            this.lCurrentSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCurrentSum.Location = new System.Drawing.Point(180, 106);
            this.lCurrentSum.Name = "lCurrentSum";
            this.lCurrentSum.Size = new System.Drawing.Size(45, 20);
            this.lCurrentSum.TabIndex = 5;
            this.lCurrentSum.Text = "Sum";
            // 
            // lCurrentBalance
            // 
            this.lCurrentBalance.AutoSize = true;
            this.lCurrentBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCurrentBalance.Location = new System.Drawing.Point(180, 61);
            this.lCurrentBalance.Name = "lCurrentBalance";
            this.lCurrentBalance.Size = new System.Drawing.Size(45, 20);
            this.lCurrentBalance.TabIndex = 4;
            this.lCurrentBalance.Text = "Sum";
            // 
            // lSum
            // 
            this.lSum.AutoSize = true;
            this.lSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSum.Location = new System.Drawing.Point(0, 106);
            this.lSum.Name = "lSum";
            this.lSum.Size = new System.Drawing.Size(131, 20);
            this.lSum.TabIndex = 3;
            this.lSum.Text = "Sum for Payment";
            // 
            // lBalance
            // 
            this.lBalance.AutoSize = true;
            this.lBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBalance.Location = new System.Drawing.Point(6, 61);
            this.lBalance.Name = "lBalance";
            this.lBalance.Size = new System.Drawing.Size(67, 20);
            this.lBalance.TabIndex = 2;
            this.lBalance.Text = "Balance";
            // 
            // lNameBuyer
            // 
            this.lNameBuyer.AutoSize = true;
            this.lNameBuyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameBuyer.Location = new System.Drawing.Point(6, 16);
            this.lNameBuyer.Name = "lNameBuyer";
            this.lNameBuyer.Size = new System.Drawing.Size(92, 20);
            this.lNameBuyer.TabIndex = 1;
            this.lNameBuyer.Text = "NameBuyer";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(234, 305);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 36);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSet
            // 
            this.btnSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSet.Location = new System.Drawing.Point(12, 305);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(107, 36);
            this.btnSet.TabIndex = 12;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // FormCloseBid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 353);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gBBuyer);
            this.Controls.Add(this.gBSeller);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCloseBid";
            this.Text = "FormCloseBid";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCloseBid_FormClosing);
            this.gBSeller.ResumeLayout(false);
            this.gBSeller.PerformLayout();
            this.gBBuyer.ResumeLayout(false);
            this.gBBuyer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lNameTrade;
        private System.Windows.Forms.Label lShare;
        private System.Windows.Forms.MaskedTextBox mTBQuantity;
        private System.Windows.Forms.Label lPrice;
        private System.Windows.Forms.GroupBox gBSeller;
        private System.Windows.Forms.GroupBox gBBuyer;
        private System.Windows.Forms.Label lSum;
        private System.Windows.Forms.Label lBalance;
        private System.Windows.Forms.Label lNameBuyer;
        private System.Windows.Forms.Label lCurrentSum;
        private System.Windows.Forms.Label lCurrentBalance;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label lCurrPrice;
    }
}