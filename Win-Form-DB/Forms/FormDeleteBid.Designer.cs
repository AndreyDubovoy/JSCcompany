namespace Win_Form_DB
{
    partial class FormDeleteBid
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
            this.gBTradeType = new System.Windows.Forms.GroupBox();
            this.lidBuy = new System.Windows.Forms.Label();
            this.lidSale = new System.Windows.Forms.Label();
            this.rBforBuy = new System.Windows.Forms.RadioButton();
            this.rBforSale = new System.Windows.Forms.RadioButton();
            this.gBCurrentBid = new System.Windows.Forms.GroupBox();
            this.lExecutedQuantity = new System.Windows.Forms.Label();
            this.lFullQuantity = new System.Windows.Forms.Label();
            this.lPrice = new System.Windows.Forms.Label();
            this.lDate = new System.Windows.Forms.Label();
            this.lShare = new System.Windows.Forms.Label();
            this.lHolder = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gBTradeType.SuspendLayout();
            this.gBCurrentBid.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBTradeType
            // 
            this.gBTradeType.Controls.Add(this.lidBuy);
            this.gBTradeType.Controls.Add(this.lidSale);
            this.gBTradeType.Controls.Add(this.rBforBuy);
            this.gBTradeType.Controls.Add(this.rBforSale);
            this.gBTradeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBTradeType.Location = new System.Drawing.Point(12, 12);
            this.gBTradeType.Name = "gBTradeType";
            this.gBTradeType.Size = new System.Drawing.Size(267, 108);
            this.gBTradeType.TabIndex = 0;
            this.gBTradeType.TabStop = false;
            this.gBTradeType.Text = "TradeType";
            // 
            // lidBuy
            // 
            this.lidBuy.AutoSize = true;
            this.lidBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lidBuy.Location = new System.Drawing.Point(171, 69);
            this.lidBuy.Name = "lidBuy";
            this.lidBuy.Size = new System.Drawing.Size(50, 20);
            this.lidBuy.TabIndex = 4;
            this.lidBuy.Text = "IdBuy";
            // 
            // lidSale
            // 
            this.lidSale.AutoSize = true;
            this.lidSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lidSale.Location = new System.Drawing.Point(171, 29);
            this.lidSale.Name = "lidSale";
            this.lidSale.Size = new System.Drawing.Size(55, 20);
            this.lidSale.TabIndex = 3;
            this.lidSale.Text = "IdSale";
            // 
            // rBforBuy
            // 
            this.rBforBuy.AutoSize = true;
            this.rBforBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBforBuy.Location = new System.Drawing.Point(6, 65);
            this.rBforBuy.Name = "rBforBuy";
            this.rBforBuy.Size = new System.Drawing.Size(122, 24);
            this.rBforBuy.TabIndex = 2;
            this.rBforBuy.Text = "Trade for Buy";
            this.rBforBuy.UseVisualStyleBackColor = true;
            // 
            // rBforSale
            // 
            this.rBforSale.AutoSize = true;
            this.rBforSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBforSale.Location = new System.Drawing.Point(6, 25);
            this.rBforSale.Name = "rBforSale";
            this.rBforSale.Size = new System.Drawing.Size(127, 24);
            this.rBforSale.TabIndex = 1;
            this.rBforSale.Text = "Trade for Sale";
            this.rBforSale.UseVisualStyleBackColor = true;
            this.rBforSale.CheckedChanged += new System.EventHandler(this.rB_CheckedChanged);
            // 
            // gBCurrentBid
            // 
            this.gBCurrentBid.Controls.Add(this.lExecutedQuantity);
            this.gBCurrentBid.Controls.Add(this.lFullQuantity);
            this.gBCurrentBid.Controls.Add(this.lPrice);
            this.gBCurrentBid.Controls.Add(this.lDate);
            this.gBCurrentBid.Controls.Add(this.lShare);
            this.gBCurrentBid.Controls.Add(this.lHolder);
            this.gBCurrentBid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBCurrentBid.Location = new System.Drawing.Point(12, 126);
            this.gBCurrentBid.Name = "gBCurrentBid";
            this.gBCurrentBid.Size = new System.Drawing.Size(274, 243);
            this.gBCurrentBid.TabIndex = 1;
            this.gBCurrentBid.TabStop = false;
            this.gBCurrentBid.Text = "Current Bid";
            // 
            // lExecutedQuantity
            // 
            this.lExecutedQuantity.AutoSize = true;
            this.lExecutedQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lExecutedQuantity.Location = new System.Drawing.Point(6, 199);
            this.lExecutedQuantity.Name = "lExecutedQuantity";
            this.lExecutedQuantity.Size = new System.Drawing.Size(136, 20);
            this.lExecutedQuantity.TabIndex = 2;
            this.lExecutedQuantity.Text = "Executed quantity";
            // 
            // lFullQuantity
            // 
            this.lFullQuantity.AutoSize = true;
            this.lFullQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFullQuantity.Location = new System.Drawing.Point(6, 165);
            this.lFullQuantity.Name = "lFullQuantity";
            this.lFullQuantity.Size = new System.Drawing.Size(94, 20);
            this.lFullQuantity.TabIndex = 2;
            this.lFullQuantity.Text = "Full quantity";
            // 
            // lPrice
            // 
            this.lPrice.AutoSize = true;
            this.lPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPrice.Location = new System.Drawing.Point(6, 131);
            this.lPrice.Name = "lPrice";
            this.lPrice.Size = new System.Drawing.Size(44, 20);
            this.lPrice.TabIndex = 2;
            this.lPrice.Text = "Price";
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDate.Location = new System.Drawing.Point(6, 32);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(44, 20);
            this.lDate.TabIndex = 3;
            this.lDate.Text = "Date";
            // 
            // lShare
            // 
            this.lShare.AutoSize = true;
            this.lShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShare.Location = new System.Drawing.Point(6, 95);
            this.lShare.Name = "lShare";
            this.lShare.Size = new System.Drawing.Size(52, 20);
            this.lShare.TabIndex = 2;
            this.lShare.Text = "Share";
            // 
            // lHolder
            // 
            this.lHolder.AutoSize = true;
            this.lHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHolder.Location = new System.Drawing.Point(6, 61);
            this.lHolder.Name = "lHolder";
            this.lHolder.Size = new System.Drawing.Size(102, 20);
            this.lHolder.TabIndex = 2;
            this.lHolder.Text = "Name Holder";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(22, 379);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 38);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(175, 379);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 38);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormDeleteBid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 429);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gBCurrentBid);
            this.Controls.Add(this.gBTradeType);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormDeleteBid";
            this.Text = "Closing  Current Bid";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDeleteBid_FormClosing);
            this.gBTradeType.ResumeLayout(false);
            this.gBTradeType.PerformLayout();
            this.gBCurrentBid.ResumeLayout(false);
            this.gBCurrentBid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBTradeType;
        private System.Windows.Forms.RadioButton rBforBuy;
        private System.Windows.Forms.RadioButton rBforSale;
        private System.Windows.Forms.GroupBox gBCurrentBid;
        private System.Windows.Forms.Label lExecutedQuantity;
        private System.Windows.Forms.Label lFullQuantity;
        private System.Windows.Forms.Label lPrice;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.Label lShare;
        private System.Windows.Forms.Label lHolder;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lidBuy;
        private System.Windows.Forms.Label lidSale;
    }
}