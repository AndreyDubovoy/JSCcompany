namespace Win_Form_DB
{
    partial class FormNewList
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
            this.lconfirm = new System.Windows.Forms.Label();
            this.lconfirm1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lconfirm
            // 
            this.lconfirm.AutoSize = true;
            this.lconfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lconfirm.Location = new System.Drawing.Point(35, 35);
            this.lconfirm.Name = "lconfirm";
            this.lconfirm.Size = new System.Drawing.Size(237, 20);
            this.lconfirm.TabIndex = 0;
            this.lconfirm.Text = "Do you want form new holder list";
            // 
            // lconfirm1
            // 
            this.lconfirm1.AutoSize = true;
            this.lconfirm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lconfirm1.Location = new System.Drawing.Point(70, 81);
            this.lconfirm1.Name = "lconfirm1";
            this.lconfirm1.Size = new System.Drawing.Size(171, 20);
            this.lconfirm1.TabIndex = 1;
            this.lconfirm1.Text = "for dividend distribution";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(12, 169);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 32);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(230, 169);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(101, 32);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lMessage
            // 
            this.lMessage.AutoSize = true;
            this.lMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMessage.Location = new System.Drawing.Point(12, 120);
            this.lMessage.Name = "lMessage";
            this.lMessage.Size = new System.Drawing.Size(0, 20);
            this.lMessage.TabIndex = 9;
            // 
            // FormNewList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 213);
            this.Controls.Add(this.lMessage);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lconfirm1);
            this.Controls.Add(this.lconfirm);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNewList";
            this.Text = "Fix holder list";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNewList_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lconfirm;
        private System.Windows.Forms.Label lconfirm1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lMessage;
    }
}