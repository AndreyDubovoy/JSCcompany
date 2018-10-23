namespace Win_Form_DB
{
    partial class FormCabinet
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
            this.lHolder = new System.Windows.Forms.Label();
            this.dGVTrade = new System.Windows.Forms.DataGridView();
            this.lTrade = new System.Windows.Forms.Label();
            this.gBBalance = new System.Windows.Forms.GroupBox();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnRefill = new System.Windows.Forms.Button();
            this.laccount = new System.Windows.Forms.Label();
            this.lMovement = new System.Windows.Forms.Label();
            this.dGVBalance = new System.Windows.Forms.DataGridView();
            this.gBBisiness = new System.Windows.Forms.GroupBox();
            this.btnTrade = new System.Windows.Forms.Button();
            this.btnRevenue = new System.Windows.Forms.Button();
            this.btnFO = new System.Windows.Forms.Button();
            this.lShares = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTrade)).BeginInit();
            this.gBBalance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBalance)).BeginInit();
            this.gBBisiness.SuspendLayout();
            this.SuspendLayout();
            // 
            // lHolder
            // 
            this.lHolder.AutoSize = true;
            this.lHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHolder.Location = new System.Drawing.Point(12, 9);
            this.lHolder.Name = "lHolder";
            this.lHolder.Size = new System.Drawing.Size(62, 20);
            this.lHolder.TabIndex = 0;
            this.lHolder.Text = "Holder";
            // 
            // dGVTrade
            // 
            this.dGVTrade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVTrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVTrade.Location = new System.Drawing.Point(12, 94);
            this.dGVTrade.Name = "dGVTrade";
            this.dGVTrade.ReadOnly = true;
            this.dGVTrade.RowHeadersVisible = false;
            this.dGVTrade.Size = new System.Drawing.Size(700, 150);
            this.dGVTrade.TabIndex = 1;
            // 
            // lTrade
            // 
            this.lTrade.AutoSize = true;
            this.lTrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTrade.Location = new System.Drawing.Point(12, 71);
            this.lTrade.Name = "lTrade";
            this.lTrade.Size = new System.Drawing.Size(111, 20);
            this.lTrade.TabIndex = 2;
            this.lTrade.Text = "TradeHistory";
            // 
            // gBBalance
            // 
            this.gBBalance.Controls.Add(this.btnWithdraw);
            this.gBBalance.Controls.Add(this.btnRefill);
            this.gBBalance.Controls.Add(this.laccount);
            this.gBBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBBalance.Location = new System.Drawing.Point(718, 12);
            this.gBBalance.Name = "gBBalance";
            this.gBBalance.Size = new System.Drawing.Size(188, 219);
            this.gBBalance.TabIndex = 3;
            this.gBBalance.TabStop = false;
            this.gBBalance.Text = "Balance";
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.Location = new System.Drawing.Point(19, 158);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(134, 35);
            this.btnWithdraw.TabIndex = 2;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnRefill
            // 
            this.btnRefill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefill.Location = new System.Drawing.Point(19, 100);
            this.btnRefill.Name = "btnRefill";
            this.btnRefill.Size = new System.Drawing.Size(134, 35);
            this.btnRefill.TabIndex = 1;
            this.btnRefill.Text = "Refill";
            this.btnRefill.UseVisualStyleBackColor = true;
            this.btnRefill.Click += new System.EventHandler(this.btnRefill_Click);
            // 
            // laccount
            // 
            this.laccount.AutoSize = true;
            this.laccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laccount.Location = new System.Drawing.Point(15, 40);
            this.laccount.Name = "laccount";
            this.laccount.Size = new System.Drawing.Size(69, 20);
            this.laccount.TabIndex = 0;
            this.laccount.Text = "amount";
            // 
            // lMovement
            // 
            this.lMovement.AutoSize = true;
            this.lMovement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMovement.Location = new System.Drawing.Point(12, 257);
            this.lMovement.Name = "lMovement";
            this.lMovement.Size = new System.Drawing.Size(161, 20);
            this.lMovement.TabIndex = 4;
            this.lMovement.Text = "Balance movement";
            // 
            // dGVBalance
            // 
            this.dGVBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVBalance.Location = new System.Drawing.Point(12, 280);
            this.dGVBalance.Name = "dGVBalance";
            this.dGVBalance.ReadOnly = true;
            this.dGVBalance.RowHeadersVisible = false;
            this.dGVBalance.Size = new System.Drawing.Size(700, 159);
            this.dGVBalance.TabIndex = 5;
            this.dGVBalance.Paint += new System.Windows.Forms.PaintEventHandler(this.dGVBalance_Paint);
            // 
            // gBBisiness
            // 
            this.gBBisiness.Controls.Add(this.btnTrade);
            this.gBBisiness.Controls.Add(this.btnRevenue);
            this.gBBisiness.Controls.Add(this.btnFO);
            this.gBBisiness.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBBisiness.Location = new System.Drawing.Point(718, 280);
            this.gBBisiness.Name = "gBBisiness";
            this.gBBisiness.Size = new System.Drawing.Size(188, 159);
            this.gBBisiness.TabIndex = 6;
            this.gBBisiness.TabStop = false;
            this.gBBisiness.Text = "Bisiness";
            // 
            // btnTrade
            // 
            this.btnTrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrade.Location = new System.Drawing.Point(19, 107);
            this.btnTrade.Name = "btnTrade";
            this.btnTrade.Size = new System.Drawing.Size(143, 35);
            this.btnTrade.TabIndex = 5;
            this.btnTrade.Text = "Trade";
            this.btnTrade.UseVisualStyleBackColor = true;
            this.btnTrade.Click += new System.EventHandler(this.btnTrade_Click);
            // 
            // btnRevenue
            // 
            this.btnRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevenue.Location = new System.Drawing.Point(19, 66);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Size = new System.Drawing.Size(143, 35);
            this.btnRevenue.TabIndex = 4;
            this.btnRevenue.Text = "Revenue";
            this.btnRevenue.UseVisualStyleBackColor = true;
            this.btnRevenue.Click += new System.EventHandler(this.btnRevenue_Click);
            // 
            // btnFO
            // 
            this.btnFO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFO.Location = new System.Drawing.Point(19, 25);
            this.btnFO.Name = "btnFO";
            this.btnFO.Size = new System.Drawing.Size(143, 35);
            this.btnFO.TabIndex = 3;
            this.btnFO.Text = "Filter and Order";
            this.btnFO.UseVisualStyleBackColor = true;
            this.btnFO.Click += new System.EventHandler(this.btnFO_Click);
            // 
            // lShares
            // 
            this.lShares.AutoSize = true;
            this.lShares.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lShares.Location = new System.Drawing.Point(12, 38);
            this.lShares.Name = "lShares";
            this.lShares.Size = new System.Drawing.Size(66, 20);
            this.lShares.TabIndex = 7;
            this.lShares.Text = "Shares";
            // 
            // FormCabinet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 451);
            this.Controls.Add(this.lShares);
            this.Controls.Add(this.gBBisiness);
            this.Controls.Add(this.dGVBalance);
            this.Controls.Add(this.lMovement);
            this.Controls.Add(this.gBBalance);
            this.Controls.Add(this.lTrade);
            this.Controls.Add(this.dGVTrade);
            this.Controls.Add(this.lHolder);
            this.MaximizeBox = false;
            this.Name = "FormCabinet";
            this.Text = "Personal сabinet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCabinet_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dGVTrade)).EndInit();
            this.gBBalance.ResumeLayout(false);
            this.gBBalance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBalance)).EndInit();
            this.gBBisiness.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lHolder;
        private System.Windows.Forms.DataGridView dGVTrade;
        private System.Windows.Forms.Label lTrade;
        private System.Windows.Forms.GroupBox gBBalance;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnRefill;
        private System.Windows.Forms.Label lMovement;
        private System.Windows.Forms.DataGridView dGVBalance;
        private System.Windows.Forms.GroupBox gBBisiness;
        private System.Windows.Forms.Button btnTrade;
        private System.Windows.Forms.Button btnRevenue;
        private System.Windows.Forms.Button btnFO;
        private System.Windows.Forms.Label lShares;
        public System.Windows.Forms.Label laccount;
    }
}