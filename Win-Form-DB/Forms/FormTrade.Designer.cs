namespace Win_Form_DB
{
    partial class FormTrade
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
            this.gBTradeBuy = new System.Windows.Forms.GroupBox();
            this.dGVTradeBuy = new System.Windows.Forms.DataGridView();
            this.gBTradeSale = new System.Windows.Forms.GroupBox();
            this.dGVTradeSale = new System.Windows.Forms.DataGridView();
            this.gBTradeQuote = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dGVTradeQuote = new System.Windows.Forms.DataGridView();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnNewBid = new System.Windows.Forms.Button();
            this.btnDeleteBid = new System.Windows.Forms.Button();
            this.btnFiltrOrder = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.gBTradeBuy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTradeBuy)).BeginInit();
            this.gBTradeSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTradeSale)).BeginInit();
            this.gBTradeQuote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTradeQuote)).BeginInit();
            this.SuspendLayout();
            // 
            // gBTradeBuy
            // 
            this.gBTradeBuy.Controls.Add(this.dGVTradeBuy);
            this.gBTradeBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBTradeBuy.Location = new System.Drawing.Point(12, 12);
            this.gBTradeBuy.Name = "gBTradeBuy";
            this.gBTradeBuy.Size = new System.Drawing.Size(773, 272);
            this.gBTradeBuy.TabIndex = 0;
            this.gBTradeBuy.TabStop = false;
            this.gBTradeBuy.Text = "Bid for sale";
            // 
            // dGVTradeBuy
            // 
            this.dGVTradeBuy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dGVTradeBuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVTradeBuy.Location = new System.Drawing.Point(6, 20);
            this.dGVTradeBuy.MultiSelect = false;
            this.dGVTradeBuy.Name = "dGVTradeBuy";
            this.dGVTradeBuy.ReadOnly = true;
            this.dGVTradeBuy.RowHeadersVisible = false;
            this.dGVTradeBuy.Size = new System.Drawing.Size(761, 225);
            this.dGVTradeBuy.TabIndex = 0;
            this.dGVTradeBuy.Paint += new System.Windows.Forms.PaintEventHandler(this.dGVTradeBuy_Paint);
            // 
            // gBTradeSale
            // 
            this.gBTradeSale.Controls.Add(this.dGVTradeSale);
            this.gBTradeSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBTradeSale.Location = new System.Drawing.Point(12, 303);
            this.gBTradeSale.Name = "gBTradeSale";
            this.gBTradeSale.Size = new System.Drawing.Size(773, 272);
            this.gBTradeSale.TabIndex = 1;
            this.gBTradeSale.TabStop = false;
            this.gBTradeSale.Text = "Bid for buy";
            // 
            // dGVTradeSale
            // 
            this.dGVTradeSale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dGVTradeSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVTradeSale.Location = new System.Drawing.Point(6, 25);
            this.dGVTradeSale.MultiSelect = false;
            this.dGVTradeSale.Name = "dGVTradeSale";
            this.dGVTradeSale.ReadOnly = true;
            this.dGVTradeSale.RowHeadersVisible = false;
            this.dGVTradeSale.Size = new System.Drawing.Size(761, 225);
            this.dGVTradeSale.TabIndex = 0;
            this.dGVTradeSale.Paint += new System.Windows.Forms.PaintEventHandler(this.dGVTradeSale_Paint);
            // 
            // gBTradeQuote
            // 
            this.gBTradeQuote.Controls.Add(this.btnRefresh);
            this.gBTradeQuote.Controls.Add(this.dGVTradeQuote);
            this.gBTradeQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBTradeQuote.Location = new System.Drawing.Point(805, 12);
            this.gBTradeQuote.Name = "gBTradeQuote";
            this.gBTradeQuote.Size = new System.Drawing.Size(315, 272);
            this.gBTradeQuote.TabIndex = 2;
            this.gBTradeQuote.TabStop = false;
            this.gBTradeQuote.Text = "Quote";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(60, 207);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(197, 38);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dGVTradeQuote
            // 
            this.dGVTradeQuote.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dGVTradeQuote.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dGVTradeQuote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVTradeQuote.Location = new System.Drawing.Point(6, 20);
            this.dGVTradeQuote.MultiSelect = false;
            this.dGVTradeQuote.Name = "dGVTradeQuote";
            this.dGVTradeQuote.ReadOnly = true;
            this.dGVTradeQuote.RowHeadersVisible = false;
            this.dGVTradeQuote.Size = new System.Drawing.Size(301, 176);
            this.dGVTradeQuote.TabIndex = 0;
            // 
            // btnBuy
            // 
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.Location = new System.Drawing.Point(865, 416);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(197, 38);
            this.btnBuy.TabIndex = 3;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnNewBid
            // 
            this.btnNewBid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewBid.Location = new System.Drawing.Point(865, 460);
            this.btnNewBid.Name = "btnNewBid";
            this.btnNewBid.Size = new System.Drawing.Size(197, 38);
            this.btnNewBid.TabIndex = 4;
            this.btnNewBid.Text = "New Bid";
            this.btnNewBid.UseVisualStyleBackColor = true;
            this.btnNewBid.Click += new System.EventHandler(this.btnNewBid_Click);
            // 
            // btnDeleteBid
            // 
            this.btnDeleteBid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBid.Location = new System.Drawing.Point(865, 504);
            this.btnDeleteBid.Name = "btnDeleteBid";
            this.btnDeleteBid.Size = new System.Drawing.Size(197, 38);
            this.btnDeleteBid.TabIndex = 5;
            this.btnDeleteBid.Text = "Close Bid";
            this.btnDeleteBid.UseVisualStyleBackColor = true;
            this.btnDeleteBid.Click += new System.EventHandler(this.btnDeleteBid_Click);
            // 
            // btnFiltrOrder
            // 
            this.btnFiltrOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrOrder.Location = new System.Drawing.Point(865, 328);
            this.btnFiltrOrder.Name = "btnFiltrOrder";
            this.btnFiltrOrder.Size = new System.Drawing.Size(197, 38);
            this.btnFiltrOrder.TabIndex = 6;
            this.btnFiltrOrder.Text = "Filter and Order";
            this.btnFiltrOrder.UseVisualStyleBackColor = true;
            this.btnFiltrOrder.Click += new System.EventHandler(this.btnFiltrOrder_Click);
            // 
            // btnSale
            // 
            this.btnSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSale.Location = new System.Drawing.Point(865, 372);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(197, 38);
            this.btnSale.TabIndex = 7;
            this.btnSale.Text = "Sale";
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // FormTrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 587);
            this.Controls.Add(this.btnSale);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnFiltrOrder);
            this.Controls.Add(this.btnDeleteBid);
            this.Controls.Add(this.btnNewBid);
            this.Controls.Add(this.gBTradeQuote);
            this.Controls.Add(this.gBTradeSale);
            this.Controls.Add(this.gBTradeBuy);
            this.MaximizeBox = false;
            this.Name = "FormTrade";
            this.Text = "FormTrade";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTrade_FormClosing);
            this.gBTradeBuy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVTradeBuy)).EndInit();
            this.gBTradeSale.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVTradeSale)).EndInit();
            this.gBTradeQuote.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVTradeQuote)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBTradeBuy;
        private System.Windows.Forms.GroupBox gBTradeSale;
        private System.Windows.Forms.GroupBox gBTradeQuote;
        private System.Windows.Forms.DataGridView dGVTradeQuote;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnNewBid;
        private System.Windows.Forms.Button btnDeleteBid;
        private System.Windows.Forms.Button btnFiltrOrder;
        private System.Windows.Forms.Button btnSale;
        public System.Windows.Forms.DataGridView dGVTradeBuy;
        public System.Windows.Forms.DataGridView dGVTradeSale;
        private System.Windows.Forms.Button btnRefresh;
    }
}