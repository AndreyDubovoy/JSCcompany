namespace Win_Form_DB
{
    partial class FormBalanceMovement
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
            this.lEnter = new System.Windows.Forms.Label();
            this.tBmoving = new System.Windows.Forms.TextBox();
            this.lCreditCard = new System.Windows.Forms.Label();
            this.tBCreditCard = new System.Windows.Forms.TextBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpValidation = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.grpValidation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lEnter
            // 
            this.lEnter.AutoSize = true;
            this.lEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEnter.Location = new System.Drawing.Point(6, 16);
            this.lEnter.Name = "lEnter";
            this.lEnter.Size = new System.Drawing.Size(293, 20);
            this.lEnter.TabIndex = 0;
            this.lEnter.Text = "Enter amount for refill your Balance";
            // 
            // tBmoving
            // 
            this.tBmoving.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBmoving.Location = new System.Drawing.Point(99, 55);
            this.tBmoving.Name = "tBmoving";
            this.tBmoving.Size = new System.Drawing.Size(113, 26);
            this.tBmoving.TabIndex = 1;
            this.tBmoving.Validated += new System.EventHandler(this.tBmoving_Validated);
            // 
            // lCreditCard
            // 
            this.lCreditCard.AutoSize = true;
            this.lCreditCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCreditCard.Location = new System.Drawing.Point(67, 109);
            this.lCreditCard.Name = "lCreditCard";
            this.lCreditCard.Size = new System.Drawing.Size(182, 20);
            this.lCreditCard.TabIndex = 2;
            this.lCreditCard.Text = "Enter your credit card";
            // 
            // tBCreditCard
            // 
            this.tBCreditCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBCreditCard.Location = new System.Drawing.Point(60, 150);
            this.tBCreditCard.Name = "tBCreditCard";
            this.tBCreditCard.Size = new System.Drawing.Size(189, 26);
            this.tBCreditCard.TabIndex = 3;
            this.tBCreditCard.Validating += new System.ComponentModel.CancelEventHandler(this.tBCreditCard_Validating);
            // 
            // btnSet
            // 
            this.btnSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSet.Location = new System.Drawing.Point(117, 242);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(107, 36);
            this.btnSet.TabIndex = 13;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(238, 242);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 36);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // grpValidation
            // 
            this.grpValidation.Controls.Add(this.lEnter);
            this.grpValidation.Controls.Add(this.tBmoving);
            this.grpValidation.Controls.Add(this.lCreditCard);
            this.grpValidation.Controls.Add(this.tBCreditCard);
            this.grpValidation.Location = new System.Drawing.Point(12, 12);
            this.grpValidation.Name = "grpValidation";
            this.grpValidation.Size = new System.Drawing.Size(333, 203);
            this.grpValidation.TabIndex = 15;
            this.grpValidation.TabStop = false;
            // 
            // FormBalanceMovement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 290);
            this.Controls.Add(this.grpValidation);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSet);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBalanceMovement";
            this.Text = "FormBalanceMovement";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBalanceMovement_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.grpValidation.ResumeLayout(false);
            this.grpValidation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lEnter;
        private System.Windows.Forms.TextBox tBmoving;
        private System.Windows.Forms.Label lCreditCard;
        private System.Windows.Forms.TextBox tBCreditCard;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox grpValidation;
    }
}