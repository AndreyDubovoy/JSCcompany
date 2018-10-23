namespace Win_Form_DB
{
    partial class FormUserEntry
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
            this.llogin = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cBUser = new System.Windows.Forms.ComboBox();
            this.lMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // llogin
            // 
            this.llogin.AutoSize = true;
            this.llogin.Location = new System.Drawing.Point(12, 40);
            this.llogin.Name = "llogin";
            this.llogin.Size = new System.Drawing.Size(53, 20);
            this.llogin.TabIndex = 0;
            this.llogin.Text = "Login";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(16, 152);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(101, 35);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(262, 152);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 35);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cBUser
            // 
            this.cBUser.FormattingEnabled = true;
            this.cBUser.Items.AddRange(new object[] {
            "User1",
            "User2",
            "User3",
            "User4"});
            this.cBUser.Location = new System.Drawing.Point(133, 32);
            this.cBUser.Name = "cBUser";
            this.cBUser.Size = new System.Drawing.Size(230, 28);
            this.cBUser.TabIndex = 6;
            // 
            // lMessage
            // 
            this.lMessage.AutoSize = true;
            this.lMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMessage.Location = new System.Drawing.Point(12, 98);
            this.lMessage.Name = "lMessage";
            this.lMessage.Size = new System.Drawing.Size(12, 20);
            this.lMessage.TabIndex = 7;
            this.lMessage.Text = "l";
            this.lMessage.Visible = false;
            // 
            // FormUserEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 215);
            this.Controls.Add(this.lMessage);
            this.Controls.Add(this.cBUser);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.llogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUserEntry";
            this.Text = "User Entry";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormUserEntry_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label llogin;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cBUser;
        private System.Windows.Forms.Label lMessage;
    }
}