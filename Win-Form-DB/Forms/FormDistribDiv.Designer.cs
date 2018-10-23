namespace Win_Form_DB
{
    partial class FormDistribDiv
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
            this.lDate = new System.Windows.Forms.Label();
            this.lPrefer = new System.Windows.Forms.Label();
            this.lCommon = new System.Windows.Forms.Label();
            this.lAmountRevenue = new System.Windows.Forms.Label();
            this.lOnePrefer = new System.Windows.Forms.Label();
            this.lOneCommon = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDistribute = new System.Windows.Forms.Button();
            this.tBDistrAmount = new System.Windows.Forms.TextBox();
            this.tBOnePrefer = new System.Windows.Forms.TextBox();
            this.lDistributed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDate.Location = new System.Drawing.Point(12, 9);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(171, 20);
            this.lDate.TabIndex = 0;
            this.lDate.Text = "List fixing date:        ";
            // 
            // lPrefer
            // 
            this.lPrefer.AutoSize = true;
            this.lPrefer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPrefer.Location = new System.Drawing.Point(12, 45);
            this.lPrefer.Name = "lPrefer";
            this.lPrefer.Size = new System.Drawing.Size(186, 20);
            this.lPrefer.TabIndex = 1;
            this.lPrefer.Text = "Prefer shares:     ";
            // 
            // lCommon
            // 
            this.lCommon.AutoSize = true;
            this.lCommon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCommon.Location = new System.Drawing.Point(12, 84);
            this.lCommon.Name = "lCommon";
            this.lCommon.Size = new System.Drawing.Size(178, 20);
            this.lCommon.TabIndex = 2;
            this.lCommon.Text = "Common shares:       ";
            // 
            // lAmountRevenue
            // 
            this.lAmountRevenue.AutoSize = true;
            this.lAmountRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAmountRevenue.Location = new System.Drawing.Point(12, 127);
            this.lAmountRevenue.Name = "lAmountRevenue";
            this.lAmountRevenue.Size = new System.Drawing.Size(157, 20);
            this.lAmountRevenue.TabIndex = 3;
            this.lAmountRevenue.Text = "Distribute amount:";
            // 
            // lOnePrefer
            // 
            this.lOnePrefer.AutoSize = true;
            this.lOnePrefer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOnePrefer.Location = new System.Drawing.Point(12, 168);
            this.lOnePrefer.Name = "lOnePrefer";
            this.lOnePrefer.Size = new System.Drawing.Size(230, 20);
            this.lOnePrefer.TabIndex = 4;
            this.lOnePrefer.Text = "Amount for one prefer:";
            // 
            // lOneCommon
            // 
            this.lOneCommon.AutoSize = true;
            this.lOneCommon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOneCommon.Location = new System.Drawing.Point(12, 216);
            this.lOneCommon.Name = "lOneCommon";
            this.lOneCommon.Size = new System.Drawing.Size(235, 20);
            this.lOneCommon.TabIndex = 5;
            this.lOneCommon.Text = "Amount for one common:     ";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(35, 316);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 32);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDistribute
            // 
            this.btnDistribute.Enabled = false;
            this.btnDistribute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDistribute.Location = new System.Drawing.Point(243, 316);
            this.btnDistribute.Name = "btnDistribute";
            this.btnDistribute.Size = new System.Drawing.Size(101, 32);
            this.btnDistribute.TabIndex = 7;
            this.btnDistribute.Text = "Distribute";
            this.btnDistribute.UseVisualStyleBackColor = true;
            this.btnDistribute.Click += new System.EventHandler(this.btnDistribute_Click);
            // 
            // tBDistrAmount
            // 
            this.tBDistrAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBDistrAmount.Location = new System.Drawing.Point(270, 121);
            this.tBDistrAmount.Name = "tBDistrAmount";
            this.tBDistrAmount.Size = new System.Drawing.Size(94, 26);
            this.tBDistrAmount.TabIndex = 8;
            this.tBDistrAmount.Validated += new System.EventHandler(this.tBDistrAmount_Validated);
            // 
            // tBOnePrefer
            // 
            this.tBOnePrefer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBOnePrefer.Location = new System.Drawing.Point(270, 162);
            this.tBOnePrefer.Name = "tBOnePrefer";
            this.tBOnePrefer.Size = new System.Drawing.Size(94, 26);
            this.tBOnePrefer.TabIndex = 9;
            this.tBOnePrefer.Validated += new System.EventHandler(this.tBOnePrefer_Validated);
            // 
            // lDistributed
            // 
            this.lDistributed.AutoSize = true;
            this.lDistributed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDistributed.Location = new System.Drawing.Point(12, 260);
            this.lDistributed.Name = "lDistributed";
            this.lDistributed.Size = new System.Drawing.Size(167, 20);
            this.lDistributed.TabIndex = 10;
            this.lDistributed.Text = "Distributed amount:";
            // 
            // FormDistribDiv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 360);
            this.Controls.Add(this.lDistributed);
            this.Controls.Add(this.tBOnePrefer);
            this.Controls.Add(this.tBDistrAmount);
            this.Controls.Add(this.btnDistribute);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lOneCommon);
            this.Controls.Add(this.lOnePrefer);
            this.Controls.Add(this.lAmountRevenue);
            this.Controls.Add(this.lCommon);
            this.Controls.Add(this.lPrefer);
            this.Controls.Add(this.lDate);
            this.Name = "FormDistribDiv";
            this.Text = "Dividend distributing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.Label lPrefer;
        private System.Windows.Forms.Label lCommon;
        private System.Windows.Forms.Label lAmountRevenue;
        private System.Windows.Forms.Label lOnePrefer;
        private System.Windows.Forms.Label lOneCommon;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDistribute;
        private System.Windows.Forms.TextBox tBDistrAmount;
        private System.Windows.Forms.TextBox tBOnePrefer;
        private System.Windows.Forms.Label lDistributed;
    }
}