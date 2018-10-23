namespace Win_Form_DB
{
    partial class FormDividend
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
            this.dGVDividend = new System.Windows.Forms.DataGridView();
            this.dGVDivHolder = new System.Windows.Forms.DataGridView();
            this.btnFixList = new System.Windows.Forms.Button();
            this.btnDistribute = new System.Windows.Forms.Button();
            this.timerDivHolder = new System.Windows.Forms.Timer(this.components);
            this.btnRefillBalance = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDividend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDivHolder)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVDividend
            // 
            this.dGVDividend.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVDividend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDividend.Location = new System.Drawing.Point(12, 12);
            this.dGVDividend.MultiSelect = false;
            this.dGVDividend.Name = "dGVDividend";
            this.dGVDividend.ReadOnly = true;
            this.dGVDividend.RowHeadersVisible = false;
            this.dGVDividend.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVDividend.Size = new System.Drawing.Size(615, 243);
            this.dGVDividend.TabIndex = 0;
            this.dGVDividend.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVDividend_RowEnter);
            // 
            // dGVDivHolder
            // 
            this.dGVDivHolder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVDivHolder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDivHolder.Location = new System.Drawing.Point(633, 12);
            this.dGVDivHolder.Name = "dGVDivHolder";
            this.dGVDivHolder.ReadOnly = true;
            this.dGVDivHolder.RowHeadersVisible = false;
            this.dGVDivHolder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVDivHolder.Size = new System.Drawing.Size(440, 398);
            this.dGVDivHolder.TabIndex = 1;
            // 
            // btnFixList
            // 
            this.btnFixList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFixList.Location = new System.Drawing.Point(12, 275);
            this.btnFixList.Name = "btnFixList";
            this.btnFixList.Size = new System.Drawing.Size(157, 40);
            this.btnFixList.TabIndex = 2;
            this.btnFixList.Text = "Fix holder list";
            this.btnFixList.UseVisualStyleBackColor = true;
            this.btnFixList.Click += new System.EventHandler(this.btnFixList_Click);
            // 
            // btnDistribute
            // 
            this.btnDistribute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDistribute.Location = new System.Drawing.Point(12, 321);
            this.btnDistribute.Name = "btnDistribute";
            this.btnDistribute.Size = new System.Drawing.Size(157, 40);
            this.btnDistribute.TabIndex = 3;
            this.btnDistribute.Text = "Distribute dividends";
            this.btnDistribute.UseVisualStyleBackColor = true;
            this.btnDistribute.Click += new System.EventHandler(this.btnDistribute_Click);
            // 
            // timerDivHolder
            // 
            this.timerDivHolder.Tick += new System.EventHandler(this.timerDivHolder_Tick);
            // 
            // btnRefillBalance
            // 
            this.btnRefillBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefillBalance.Location = new System.Drawing.Point(12, 370);
            this.btnRefillBalance.Name = "btnRefillBalance";
            this.btnRefillBalance.Size = new System.Drawing.Size(157, 40);
            this.btnRefillBalance.TabIndex = 4;
            this.btnRefillBalance.Text = "Refill Balance";
            this.btnRefillBalance.UseVisualStyleBackColor = true;
            this.btnRefillBalance.Click += new System.EventHandler(this.btnRefillBalance_Click);
            // 
            // FormDividend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 422);
            this.Controls.Add(this.btnRefillBalance);
            this.Controls.Add(this.btnDistribute);
            this.Controls.Add(this.btnFixList);
            this.Controls.Add(this.dGVDivHolder);
            this.Controls.Add(this.dGVDividend);
            this.MaximizeBox = false;
            this.Name = "FormDividend";
            this.Text = "Dividends";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDividend_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDividend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDivHolder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dGVDivHolder;
        private System.Windows.Forms.Button btnFixList;
        private System.Windows.Forms.Button btnDistribute;
        private System.Windows.Forms.Timer timerDivHolder;
        public System.Windows.Forms.DataGridView dGVDividend;
        private System.Windows.Forms.Button btnRefillBalance;
    }
}