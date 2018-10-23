namespace Win_Form_DB
{
    partial class NewHolder
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
            this.lFirstName = new System.Windows.Forms.Label();
            this.lSecondName = new System.Windows.Forms.Label();
            this.tBFirstName = new System.Windows.Forms.TextBox();
            this.tBSecondName = new System.Windows.Forms.TextBox();
            this.lPhone = new System.Windows.Forms.Label();
            this.lMail = new System.Windows.Forms.Label();
            this.tBMail = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tBPhone = new System.Windows.Forms.TextBox();
            this.grpValidation = new System.Windows.Forms.GroupBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lMessage = new System.Windows.Forms.Label();
            this.grpValidation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lFirstName
            // 
            this.lFirstName.AutoSize = true;
            this.lFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFirstName.Location = new System.Drawing.Point(6, 23);
            this.lFirstName.Name = "lFirstName";
            this.lFirstName.Size = new System.Drawing.Size(86, 20);
            this.lFirstName.TabIndex = 0;
            this.lFirstName.Text = "First Name";
            // 
            // lSecondName
            // 
            this.lSecondName.AutoSize = true;
            this.lSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSecondName.Location = new System.Drawing.Point(6, 64);
            this.lSecondName.Name = "lSecondName";
            this.lSecondName.Size = new System.Drawing.Size(110, 20);
            this.lSecondName.TabIndex = 1;
            this.lSecondName.Text = "Second Name";
            // 
            // tBFirstName
            // 
            this.tBFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBFirstName.Location = new System.Drawing.Point(134, 20);
            this.tBFirstName.Name = "tBFirstName";
            this.tBFirstName.Size = new System.Drawing.Size(167, 26);
            this.tBFirstName.TabIndex = 2;
            this.tBFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.tBFirstName_Validating);
            // 
            // tBSecondName
            // 
            this.tBSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBSecondName.Location = new System.Drawing.Point(134, 64);
            this.tBSecondName.Name = "tBSecondName";
            this.tBSecondName.Size = new System.Drawing.Size(167, 26);
            this.tBSecondName.TabIndex = 3;
            this.tBSecondName.Validating += new System.ComponentModel.CancelEventHandler(this.tBSecondName_Validating);
            // 
            // lPhone
            // 
            this.lPhone.AutoSize = true;
            this.lPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPhone.Location = new System.Drawing.Point(6, 111);
            this.lPhone.Name = "lPhone";
            this.lPhone.Size = new System.Drawing.Size(113, 20);
            this.lPhone.TabIndex = 4;
            this.lPhone.Text = "Phone number";
            // 
            // lMail
            // 
            this.lMail.AutoSize = true;
            this.lMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMail.Location = new System.Drawing.Point(6, 159);
            this.lMail.Name = "lMail";
            this.lMail.Size = new System.Drawing.Size(53, 20);
            this.lMail.TabIndex = 5;
            this.lMail.Text = "E-mail";
            // 
            // tBMail
            // 
            this.tBMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBMail.Location = new System.Drawing.Point(134, 153);
            this.tBMail.Name = "tBMail";
            this.tBMail.Size = new System.Drawing.Size(167, 26);
            this.tBMail.TabIndex = 6;
            this.tBMail.Validating += new System.ComponentModel.CancelEventHandler(this.tBMail_Validating);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(271, 258);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 36);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(150, 258);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 36);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tBPhone
            // 
            this.tBPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBPhone.Location = new System.Drawing.Point(134, 105);
            this.tBPhone.Name = "tBPhone";
            this.tBPhone.Size = new System.Drawing.Size(167, 26);
            this.tBPhone.TabIndex = 13;
            this.tBPhone.Validating += new System.ComponentModel.CancelEventHandler(this.tBPhone_Validating);
            // 
            // grpValidation
            // 
            this.grpValidation.Controls.Add(this.lFirstName);
            this.grpValidation.Controls.Add(this.tBPhone);
            this.grpValidation.Controls.Add(this.tBFirstName);
            this.grpValidation.Controls.Add(this.tBMail);
            this.grpValidation.Controls.Add(this.lSecondName);
            this.grpValidation.Controls.Add(this.lMail);
            this.grpValidation.Controls.Add(this.tBSecondName);
            this.grpValidation.Controls.Add(this.lPhone);
            this.grpValidation.Location = new System.Drawing.Point(16, 13);
            this.grpValidation.Name = "grpValidation";
            this.grpValidation.Size = new System.Drawing.Size(362, 202);
            this.grpValidation.TabIndex = 14;
            this.grpValidation.TabStop = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.DataMember = "null";
            // 
            // lMessage
            // 
            this.lMessage.AutoSize = true;
            this.lMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMessage.Location = new System.Drawing.Point(13, 218);
            this.lMessage.Name = "lMessage";
            this.lMessage.Size = new System.Drawing.Size(0, 20);
            this.lMessage.TabIndex = 15;
            // 
            // NewHolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 306);
            this.Controls.Add(this.lMessage);
            this.Controls.Add(this.grpValidation);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewHolder";
            this.Text = "New Holder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewHolder_FormClosing);
            this.Validated += new System.EventHandler(this.btnSave_Click);
            this.grpValidation.ResumeLayout(false);
            this.grpValidation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lFirstName;
        private System.Windows.Forms.Label lSecondName;
        private System.Windows.Forms.TextBox tBFirstName;
        private System.Windows.Forms.TextBox tBSecondName;
        private System.Windows.Forms.Label lPhone;
        private System.Windows.Forms.Label lMail;
        private System.Windows.Forms.TextBox tBMail;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tBPhone;
        private System.Windows.Forms.GroupBox grpValidation;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lMessage;
    }
}