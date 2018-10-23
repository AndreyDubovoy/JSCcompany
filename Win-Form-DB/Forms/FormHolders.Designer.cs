namespace Win_Form_DB
{
    partial class FormHolder
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
            this.components = new System.ComponentModel.Container();
            this.gridHolder = new System.Windows.Forms.DataGridView();
            this.gridTrade = new System.Windows.Forms.DataGridView();
            this.btnNewHolder = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.timerTrade = new System.Windows.Forms.Timer(this.components);
            this.lTradeHistory = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lHolderList = new System.Windows.Forms.Label();
            this.lHolder = new System.Windows.Forms.Label();
            this.lOrder = new System.Windows.Forms.Label();
            this.lqty = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridHolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTrade)).BeginInit();
            this.SuspendLayout();
            // 
            // gridHolder
            // 
            this.gridHolder.AllowUserToAddRows = false;
            this.gridHolder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHolder.Location = new System.Drawing.Point(12, 40);
            this.gridHolder.MultiSelect = false;
            this.gridHolder.Name = "gridHolder";
            this.gridHolder.ReadOnly = true;
            this.gridHolder.RowHeadersVisible = false;
            this.gridHolder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridHolder.Size = new System.Drawing.Size(824, 188);
            this.gridHolder.TabIndex = 0;
            this.gridHolder.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridHolder_RowEnter);
            this.gridHolder.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridHolder_RowLeave);
            this.gridHolder.Scroll += new System.Windows.Forms.ScrollEventHandler(this.gridHolder_Scroll);
            // 
            // gridTrade
            // 
            this.gridTrade.AllowUserToAddRows = false;
            this.gridTrade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridTrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTrade.Location = new System.Drawing.Point(12, 277);
            this.gridTrade.Name = "gridTrade";
            this.gridTrade.ReadOnly = true;
            this.gridTrade.RowHeadersVisible = false;
            this.gridTrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTrade.Size = new System.Drawing.Size(824, 193);
            this.gridTrade.TabIndex = 1;
            // 
            // btnNewHolder
            // 
            this.btnNewHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewHolder.Location = new System.Drawing.Point(897, 40);
            this.btnNewHolder.Name = "btnNewHolder";
            this.btnNewHolder.Size = new System.Drawing.Size(119, 38);
            this.btnNewHolder.TabIndex = 3;
            this.btnNewHolder.Text = "New Holder";
            this.btnNewHolder.UseVisualStyleBackColor = true;
            this.btnNewHolder.Click += new System.EventHandler(this.btnNewHolder_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(897, 180);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(119, 38);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Order By";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // timerTrade
            // 
            this.timerTrade.Tick += new System.EventHandler(this.timerTrade_Tick);
            // 
            // lTradeHistory
            // 
            this.lTradeHistory.AutoSize = true;
            this.lTradeHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTradeHistory.Location = new System.Drawing.Point(12, 254);
            this.lTradeHistory.Name = "lTradeHistory";
            this.lTradeHistory.Size = new System.Drawing.Size(118, 20);
            this.lTradeHistory.TabIndex = 5;
            this.lTradeHistory.Text = "Trade history:";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(897, 108);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(119, 38);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lHolderList
            // 
            this.lHolderList.AutoSize = true;
            this.lHolderList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHolderList.Location = new System.Drawing.Point(12, 17);
            this.lHolderList.Name = "lHolderList";
            this.lHolderList.Size = new System.Drawing.Size(101, 20);
            this.lHolderList.TabIndex = 7;
            this.lHolderList.Text = "Holder List:";
            // 
            // lHolder
            // 
            this.lHolder.AutoSize = true;
            this.lHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHolder.Location = new System.Drawing.Point(185, 17);
            this.lHolder.Name = "lHolder";
            this.lHolder.Size = new System.Drawing.Size(114, 20);
            this.lHolder.TabIndex = 8;
            this.lHolder.Text = "Current holder:";
            // 
            // lOrder
            // 
            this.lOrder.AutoSize = true;
            this.lOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOrder.Location = new System.Drawing.Point(566, 17);
            this.lOrder.Name = "lOrder";
            this.lOrder.Size = new System.Drawing.Size(107, 20);
            this.lOrder.TabIndex = 9;
            this.lOrder.Text = "Current order:";
            // 
            // lqty
            // 
            this.lqty.AutoSize = true;
            this.lqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lqty.Location = new System.Drawing.Point(112, 17);
            this.lqty.Name = "lqty";
            this.lqty.Size = new System.Drawing.Size(18, 20);
            this.lqty.TabIndex = 10;
            this.lqty.Text = "0";
            // 
            // FormHolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 482);
            this.Controls.Add(this.lqty);
            this.Controls.Add(this.lOrder);
            this.Controls.Add(this.lHolder);
            this.Controls.Add(this.lHolderList);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lTradeHistory);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnNewHolder);
            this.Controls.Add(this.gridTrade);
            this.Controls.Add(this.gridHolder);
            this.MaximizeBox = false;
            this.Name = "FormHolder";
            this.Text = "FormHolder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHolder_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.gridHolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gridTrade;
        private System.Windows.Forms.Button btnNewHolder;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Timer timerTrade;
        private System.Windows.Forms.Label lTradeHistory;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lHolderList;
        private System.Windows.Forms.Label lHolder;
        private System.Windows.Forms.Label lOrder;
        public System.Windows.Forms.DataGridView gridHolder;
        public System.Windows.Forms.Label lqty;
    }
}