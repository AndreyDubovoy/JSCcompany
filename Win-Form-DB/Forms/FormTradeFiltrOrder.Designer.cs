namespace Win_Form_DB
{
    partial class FormTradeFiltrOrder
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
            this.gBBuy = new System.Windows.Forms.GroupBox();
            this.gBBuyOrder = new System.Windows.Forms.GroupBox();
            this.rBtnBuyDate = new System.Windows.Forms.RadioButton();
            this.rBtnBuyPrice = new System.Windows.Forms.RadioButton();
            this.rBtnBuyName = new System.Windows.Forms.RadioButton();
            this.gBBuyFilter = new System.Windows.Forms.GroupBox();
            this.rBtnBuyComplete = new System.Windows.Forms.RadioButton();
            this.rBtnBuyAll = new System.Windows.Forms.RadioButton();
            this.gBSale = new System.Windows.Forms.GroupBox();
            this.gBSaleOrder = new System.Windows.Forms.GroupBox();
            this.rBtnSaleDate = new System.Windows.Forms.RadioButton();
            this.rBtnSalePrice = new System.Windows.Forms.RadioButton();
            this.rBtnSaleName = new System.Windows.Forms.RadioButton();
            this.gBSaleFiltr = new System.Windows.Forms.GroupBox();
            this.rBtnSaleComplete = new System.Windows.Forms.RadioButton();
            this.rBtnSaleAll = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gBBuy.SuspendLayout();
            this.gBBuyOrder.SuspendLayout();
            this.gBBuyFilter.SuspendLayout();
            this.gBSale.SuspendLayout();
            this.gBSaleOrder.SuspendLayout();
            this.gBSaleFiltr.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBBuy
            // 
            this.gBBuy.Controls.Add(this.gBBuyOrder);
            this.gBBuy.Controls.Add(this.gBBuyFilter);
            this.gBBuy.Location = new System.Drawing.Point(12, 12);
            this.gBBuy.Name = "gBBuy";
            this.gBBuy.Size = new System.Drawing.Size(200, 307);
            this.gBBuy.TabIndex = 0;
            this.gBBuy.TabStop = false;
            this.gBBuy.Text = "For Sale";
            // 
            // gBBuyOrder
            // 
            this.gBBuyOrder.Controls.Add(this.rBtnBuyDate);
            this.gBBuyOrder.Controls.Add(this.rBtnBuyPrice);
            this.gBBuyOrder.Controls.Add(this.rBtnBuyName);
            this.gBBuyOrder.Location = new System.Drawing.Point(6, 127);
            this.gBBuyOrder.Name = "gBBuyOrder";
            this.gBBuyOrder.Size = new System.Drawing.Size(188, 175);
            this.gBBuyOrder.TabIndex = 2;
            this.gBBuyOrder.TabStop = false;
            this.gBBuyOrder.Text = "Order";
            // 
            // rBtnBuyDate
            // 
            this.rBtnBuyDate.AutoSize = true;
            this.rBtnBuyDate.Location = new System.Drawing.Point(15, 129);
            this.rBtnBuyDate.Name = "rBtnBuyDate";
            this.rBtnBuyDate.Size = new System.Drawing.Size(62, 17);
            this.rBtnBuyDate.TabIndex = 1;
            this.rBtnBuyDate.Text = "by Date";
            this.rBtnBuyDate.UseVisualStyleBackColor = true;
            // 
            // rBtnBuyPrice
            // 
            this.rBtnBuyPrice.AutoSize = true;
            this.rBtnBuyPrice.Checked = true;
            this.rBtnBuyPrice.Location = new System.Drawing.Point(15, 44);
            this.rBtnBuyPrice.Name = "rBtnBuyPrice";
            this.rBtnBuyPrice.Size = new System.Drawing.Size(63, 17);
            this.rBtnBuyPrice.TabIndex = 1;
            this.rBtnBuyPrice.TabStop = true;
            this.rBtnBuyPrice.Text = "by Price";
            this.rBtnBuyPrice.UseVisualStyleBackColor = true;
            // 
            // rBtnBuyName
            // 
            this.rBtnBuyName.AutoSize = true;
            this.rBtnBuyName.Location = new System.Drawing.Point(15, 85);
            this.rBtnBuyName.Name = "rBtnBuyName";
            this.rBtnBuyName.Size = new System.Drawing.Size(67, 17);
            this.rBtnBuyName.TabIndex = 1;
            this.rBtnBuyName.Text = "by Name";
            this.rBtnBuyName.UseVisualStyleBackColor = true;
            // 
            // gBBuyFilter
            // 
            this.gBBuyFilter.Controls.Add(this.rBtnBuyComplete);
            this.gBBuyFilter.Controls.Add(this.rBtnBuyAll);
            this.gBBuyFilter.Location = new System.Drawing.Point(6, 19);
            this.gBBuyFilter.Name = "gBBuyFilter";
            this.gBBuyFilter.Size = new System.Drawing.Size(188, 100);
            this.gBBuyFilter.TabIndex = 1;
            this.gBBuyFilter.TabStop = false;
            this.gBBuyFilter.Text = "Filter";
            // 
            // rBtnBuyComplete
            // 
            this.rBtnBuyComplete.AutoSize = true;
            this.rBtnBuyComplete.Location = new System.Drawing.Point(15, 55);
            this.rBtnBuyComplete.Name = "rBtnBuyComplete";
            this.rBtnBuyComplete.Size = new System.Drawing.Size(108, 17);
            this.rBtnBuyComplete.TabIndex = 1;
            this.rBtnBuyComplete.Text = "Without complete";
            this.rBtnBuyComplete.UseVisualStyleBackColor = true;
            // 
            // rBtnBuyAll
            // 
            this.rBtnBuyAll.AutoSize = true;
            this.rBtnBuyAll.Checked = true;
            this.rBtnBuyAll.Location = new System.Drawing.Point(15, 19);
            this.rBtnBuyAll.Name = "rBtnBuyAll";
            this.rBtnBuyAll.Size = new System.Drawing.Size(36, 17);
            this.rBtnBuyAll.TabIndex = 1;
            this.rBtnBuyAll.TabStop = true;
            this.rBtnBuyAll.Text = "All";
            this.rBtnBuyAll.UseVisualStyleBackColor = true;
            // 
            // gBSale
            // 
            this.gBSale.Controls.Add(this.gBSaleOrder);
            this.gBSale.Controls.Add(this.gBSaleFiltr);
            this.gBSale.Location = new System.Drawing.Point(251, 12);
            this.gBSale.Name = "gBSale";
            this.gBSale.Size = new System.Drawing.Size(200, 307);
            this.gBSale.TabIndex = 1;
            this.gBSale.TabStop = false;
            this.gBSale.Text = "For Buy";
            // 
            // gBSaleOrder
            // 
            this.gBSaleOrder.Controls.Add(this.rBtnSaleDate);
            this.gBSaleOrder.Controls.Add(this.rBtnSalePrice);
            this.gBSaleOrder.Controls.Add(this.rBtnSaleName);
            this.gBSaleOrder.Location = new System.Drawing.Point(6, 127);
            this.gBSaleOrder.Name = "gBSaleOrder";
            this.gBSaleOrder.Size = new System.Drawing.Size(188, 175);
            this.gBSaleOrder.TabIndex = 3;
            this.gBSaleOrder.TabStop = false;
            this.gBSaleOrder.Text = "Order";
            // 
            // rBtnSaleDate
            // 
            this.rBtnSaleDate.AutoSize = true;
            this.rBtnSaleDate.Location = new System.Drawing.Point(15, 129);
            this.rBtnSaleDate.Name = "rBtnSaleDate";
            this.rBtnSaleDate.Size = new System.Drawing.Size(62, 17);
            this.rBtnSaleDate.TabIndex = 1;
            this.rBtnSaleDate.Text = "by Date";
            this.rBtnSaleDate.UseVisualStyleBackColor = true;
            // 
            // rBtnSalePrice
            // 
            this.rBtnSalePrice.AutoSize = true;
            this.rBtnSalePrice.Checked = true;
            this.rBtnSalePrice.Location = new System.Drawing.Point(15, 44);
            this.rBtnSalePrice.Name = "rBtnSalePrice";
            this.rBtnSalePrice.Size = new System.Drawing.Size(63, 17);
            this.rBtnSalePrice.TabIndex = 1;
            this.rBtnSalePrice.TabStop = true;
            this.rBtnSalePrice.Text = "by Price";
            this.rBtnSalePrice.UseVisualStyleBackColor = true;
            // 
            // rBtnSaleName
            // 
            this.rBtnSaleName.AutoSize = true;
            this.rBtnSaleName.Location = new System.Drawing.Point(15, 85);
            this.rBtnSaleName.Name = "rBtnSaleName";
            this.rBtnSaleName.Size = new System.Drawing.Size(67, 17);
            this.rBtnSaleName.TabIndex = 1;
            this.rBtnSaleName.Text = "by Name";
            this.rBtnSaleName.UseVisualStyleBackColor = true;
            // 
            // gBSaleFiltr
            // 
            this.gBSaleFiltr.Controls.Add(this.rBtnSaleComplete);
            this.gBSaleFiltr.Controls.Add(this.rBtnSaleAll);
            this.gBSaleFiltr.Location = new System.Drawing.Point(6, 19);
            this.gBSaleFiltr.Name = "gBSaleFiltr";
            this.gBSaleFiltr.Size = new System.Drawing.Size(188, 100);
            this.gBSaleFiltr.TabIndex = 2;
            this.gBSaleFiltr.TabStop = false;
            this.gBSaleFiltr.Text = "Filter";
            // 
            // rBtnSaleComplete
            // 
            this.rBtnSaleComplete.AutoSize = true;
            this.rBtnSaleComplete.Location = new System.Drawing.Point(15, 55);
            this.rBtnSaleComplete.Name = "rBtnSaleComplete";
            this.rBtnSaleComplete.Size = new System.Drawing.Size(108, 17);
            this.rBtnSaleComplete.TabIndex = 1;
            this.rBtnSaleComplete.Text = "Without complete";
            this.rBtnSaleComplete.UseVisualStyleBackColor = true;
            // 
            // rBtnSaleAll
            // 
            this.rBtnSaleAll.AutoSize = true;
            this.rBtnSaleAll.Checked = true;
            this.rBtnSaleAll.Location = new System.Drawing.Point(15, 19);
            this.rBtnSaleAll.Name = "rBtnSaleAll";
            this.rBtnSaleAll.Size = new System.Drawing.Size(36, 17);
            this.rBtnSaleAll.TabIndex = 1;
            this.rBtnSaleAll.TabStop = true;
            this.rBtnSaleAll.Text = "All";
            this.rBtnSaleAll.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(223, 337);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 37);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "OK";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.FormTradeFiltrOrder_Save);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(342, 337);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 37);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.FormTradeFiltrOrder_Cancel);
            // 
            // FormTradeFiltrOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 386);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gBSale);
            this.Controls.Add(this.gBBuy);
            this.Name = "FormTradeFiltrOrder";
            this.Text = "Filter and Order for trade bids";
            this.Validated += new System.EventHandler(this.FormTradeFiltrOrder_Cancel);
            this.gBBuy.ResumeLayout(false);
            this.gBBuyOrder.ResumeLayout(false);
            this.gBBuyOrder.PerformLayout();
            this.gBBuyFilter.ResumeLayout(false);
            this.gBBuyFilter.PerformLayout();
            this.gBSale.ResumeLayout(false);
            this.gBSaleOrder.ResumeLayout(false);
            this.gBSaleOrder.PerformLayout();
            this.gBSaleFiltr.ResumeLayout(false);
            this.gBSaleFiltr.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBBuy;
        private System.Windows.Forms.RadioButton rBtnBuyComplete;
        private System.Windows.Forms.RadioButton rBtnBuyAll;
        private System.Windows.Forms.GroupBox gBBuyFilter;
        private System.Windows.Forms.RadioButton rBtnBuyDate;
        private System.Windows.Forms.RadioButton rBtnBuyName;
        private System.Windows.Forms.RadioButton rBtnBuyPrice;
        private System.Windows.Forms.GroupBox gBBuyOrder;
        private System.Windows.Forms.GroupBox gBSale;
        private System.Windows.Forms.GroupBox gBSaleOrder;
        private System.Windows.Forms.RadioButton rBtnSaleDate;
        private System.Windows.Forms.RadioButton rBtnSalePrice;
        private System.Windows.Forms.RadioButton rBtnSaleName;
        private System.Windows.Forms.GroupBox gBSaleFiltr;
        private System.Windows.Forms.RadioButton rBtnSaleComplete;
        private System.Windows.Forms.RadioButton rBtnSaleAll;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}