namespace Win_Form_DB
{
    partial class FormNewBid
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
            this.gBSaleOrBuy = new System.Windows.Forms.GroupBox();
            this.rBBuy = new System.Windows.Forms.RadioButton();
            this.rBSale = new System.Windows.Forms.RadioButton();
            this.gBCommPref = new System.Windows.Forms.GroupBox();
            this.rBPrefer = new System.Windows.Forms.RadioButton();
            this.rBCommon = new System.Windows.Forms.RadioButton();
            this.lQuantity = new System.Windows.Forms.Label();
            this.lPrice = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.mTBQuantity = new System.Windows.Forms.MaskedTextBox();
            this.tBPrice = new System.Windows.Forms.TextBox();
            this.lHolder = new System.Windows.Forms.Label();
            this.lMessage1 = new System.Windows.Forms.Label();
            this.lMessage2 = new System.Windows.Forms.Label();
            this.lCQty = new System.Windows.Forms.Label();
            this.lPQty = new System.Windows.Forms.Label();
            this.gBSaleOrBuy.SuspendLayout();
            this.gBCommPref.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBSaleOrBuy
            // 
            this.gBSaleOrBuy.Controls.Add(this.rBBuy);
            this.gBSaleOrBuy.Controls.Add(this.rBSale);
            this.gBSaleOrBuy.Location = new System.Drawing.Point(12, 48);
            this.gBSaleOrBuy.Name = "gBSaleOrBuy";
            this.gBSaleOrBuy.Size = new System.Drawing.Size(139, 88);
            this.gBSaleOrBuy.TabIndex = 0;
            this.gBSaleOrBuy.TabStop = false;
            this.gBSaleOrBuy.Text = "Sale or Buy";
            // 
            // rBBuy
            // 
            this.rBBuy.AutoSize = true;
            this.rBBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBBuy.Location = new System.Drawing.Point(6, 49);
            this.rBBuy.Name = "rBBuy";
            this.rBBuy.Size = new System.Drawing.Size(106, 24);
            this.rBBuy.TabIndex = 1;
            this.rBBuy.TabStop = true;
            this.rBBuy.Text = "Buy shares";
            this.rBBuy.UseVisualStyleBackColor = true;
            this.rBBuy.Click += new System.EventHandler(this.rBBuy_Click);
            // 
            // rBSale
            // 
            this.rBSale.AutoSize = true;
            this.rBSale.Checked = true;
            this.rBSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBSale.Location = new System.Drawing.Point(6, 19);
            this.rBSale.Name = "rBSale";
            this.rBSale.Size = new System.Drawing.Size(111, 24);
            this.rBSale.TabIndex = 0;
            this.rBSale.TabStop = true;
            this.rBSale.Text = "Sale shares";
            this.rBSale.UseVisualStyleBackColor = true;
            this.rBSale.Click += new System.EventHandler(this.rBSale_Click);
            // 
            // gBCommPref
            // 
            this.gBCommPref.Controls.Add(this.lPQty);
            this.gBCommPref.Controls.Add(this.lCQty);
            this.gBCommPref.Controls.Add(this.rBPrefer);
            this.gBCommPref.Controls.Add(this.rBCommon);
            this.gBCommPref.Location = new System.Drawing.Point(182, 48);
            this.gBCommPref.Name = "gBCommPref";
            this.gBCommPref.Size = new System.Drawing.Size(200, 88);
            this.gBCommPref.TabIndex = 1;
            this.gBCommPref.TabStop = false;
            this.gBCommPref.Text = "Common or Preference";
            // 
            // rBPrefer
            // 
            this.rBPrefer.AutoSize = true;
            this.rBPrefer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBPrefer.Location = new System.Drawing.Point(6, 49);
            this.rBPrefer.Name = "rBPrefer";
            this.rBPrefer.Size = new System.Drawing.Size(105, 24);
            this.rBPrefer.TabIndex = 1;
            this.rBPrefer.Text = "Preference";
            this.rBPrefer.UseVisualStyleBackColor = true;
            this.rBPrefer.Click += new System.EventHandler(this.rBPrefer_Click);
            // 
            // rBCommon
            // 
            this.rBCommon.AutoSize = true;
            this.rBCommon.Checked = true;
            this.rBCommon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBCommon.Location = new System.Drawing.Point(6, 19);
            this.rBCommon.Name = "rBCommon";
            this.rBCommon.Size = new System.Drawing.Size(91, 24);
            this.rBCommon.TabIndex = 0;
            this.rBCommon.TabStop = true;
            this.rBCommon.Text = "Common";
            this.rBCommon.UseVisualStyleBackColor = true;
            this.rBCommon.Click += new System.EventHandler(this.rBCommon_Click);
            // 
            // lQuantity
            // 
            this.lQuantity.AutoSize = true;
            this.lQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lQuantity.Location = new System.Drawing.Point(12, 161);
            this.lQuantity.Name = "lQuantity";
            this.lQuantity.Size = new System.Drawing.Size(112, 20);
            this.lQuantity.TabIndex = 2;
            this.lQuantity.Text = "Share quantity";
            // 
            // lPrice
            // 
            this.lPrice.AutoSize = true;
            this.lPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPrice.Location = new System.Drawing.Point(8, 206);
            this.lPrice.Name = "lPrice";
            this.lPrice.Size = new System.Drawing.Size(90, 20);
            this.lPrice.TabIndex = 3;
            this.lPrice.Text = "Share price";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(174, 309);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 32);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSet
            // 
            this.btnSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSet.Location = new System.Drawing.Point(281, 309);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(101, 32);
            this.btnSet.TabIndex = 5;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // mTBQuantity
            // 
            this.mTBQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTBQuantity.Location = new System.Drawing.Point(163, 155);
            this.mTBQuantity.Mask = "00000";
            this.mTBQuantity.Name = "mTBQuantity";
            this.mTBQuantity.Size = new System.Drawing.Size(85, 26);
            this.mTBQuantity.TabIndex = 6;
            this.mTBQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mTBQuantity.ValidatingType = typeof(int);
            this.mTBQuantity.Validated += new System.EventHandler(this.mTBQuantity_Validated);
            // 
            // tBPrice
            // 
            this.tBPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBPrice.Location = new System.Drawing.Point(163, 200);
            this.tBPrice.Name = "tBPrice";
            this.tBPrice.Size = new System.Drawing.Size(85, 26);
            this.tBPrice.TabIndex = 7;
            this.tBPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tBPrice.Validated += new System.EventHandler(this.tBPrice_Validated);
            // 
            // lHolder
            // 
            this.lHolder.AutoSize = true;
            this.lHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHolder.Location = new System.Drawing.Point(15, 18);
            this.lHolder.Name = "lHolder";
            this.lHolder.Size = new System.Drawing.Size(102, 20);
            this.lHolder.TabIndex = 8;
            this.lHolder.Text = "Some Holder";
            // 
            // lMessage1
            // 
            this.lMessage1.AutoSize = true;
            this.lMessage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMessage1.Location = new System.Drawing.Point(12, 241);
            this.lMessage1.Name = "lMessage1";
            this.lMessage1.Size = new System.Drawing.Size(86, 20);
            this.lMessage1.TabIndex = 9;
            this.lMessage1.Text = "lMessage1";
            // 
            // lMessage2
            // 
            this.lMessage2.AutoSize = true;
            this.lMessage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMessage2.Location = new System.Drawing.Point(12, 270);
            this.lMessage2.Name = "lMessage2";
            this.lMessage2.Size = new System.Drawing.Size(86, 20);
            this.lMessage2.TabIndex = 10;
            this.lMessage2.Text = "lMessage2";
            // 
            // lCQty
            // 
            this.lCQty.AutoSize = true;
            this.lCQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCQty.Location = new System.Drawing.Point(119, 21);
            this.lCQty.Name = "lCQty";
            this.lCQty.Size = new System.Drawing.Size(47, 20);
            this.lCQty.TabIndex = 2;
            this.lCQty.Text = "lCQty";
            // 
            // lPQty
            // 
            this.lPQty.AutoSize = true;
            this.lPQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPQty.Location = new System.Drawing.Point(119, 51);
            this.lPQty.Name = "lPQty";
            this.lPQty.Size = new System.Drawing.Size(46, 20);
            this.lPQty.TabIndex = 3;
            this.lPQty.Text = "lPQty";
            // 
            // FormNewBid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 353);
            this.Controls.Add(this.lMessage2);
            this.Controls.Add(this.lMessage1);
            this.Controls.Add(this.lHolder);
            this.Controls.Add(this.tBPrice);
            this.Controls.Add(this.mTBQuantity);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lPrice);
            this.Controls.Add(this.lQuantity);
            this.Controls.Add(this.gBCommPref);
            this.Controls.Add(this.gBSaleOrBuy);
            this.Name = "FormNewBid";
            this.Text = "New Bid";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNewBid_FormClosing);
            this.gBSaleOrBuy.ResumeLayout(false);
            this.gBSaleOrBuy.PerformLayout();
            this.gBCommPref.ResumeLayout(false);
            this.gBCommPref.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBSaleOrBuy;
        private System.Windows.Forms.RadioButton rBSale;
        private System.Windows.Forms.RadioButton rBBuy;
        private System.Windows.Forms.GroupBox gBCommPref;
        private System.Windows.Forms.RadioButton rBPrefer;
        private System.Windows.Forms.RadioButton rBCommon;
        private System.Windows.Forms.Label lQuantity;
        private System.Windows.Forms.Label lPrice;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.MaskedTextBox mTBQuantity;
        private System.Windows.Forms.TextBox tBPrice;
        private System.Windows.Forms.Label lHolder;
        private System.Windows.Forms.Label lMessage1;
        private System.Windows.Forms.Label lMessage2;
        private System.Windows.Forms.Label lPQty;
        private System.Windows.Forms.Label lCQty;
    }
}