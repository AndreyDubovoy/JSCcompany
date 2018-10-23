namespace Win_Form_DB
{
    partial class HolderOrderForm
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
            this.gBOrderHolder = new System.Windows.Forms.GroupBox();
            this.rBPrefer = new System.Windows.Forms.RadioButton();
            this.rBCommon = new System.Windows.Forms.RadioButton();
            this.rBSecondName = new System.Windows.Forms.RadioButton();
            this.rBFirstName = new System.Windows.Forms.RadioButton();
            this.rBId = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lMessage = new System.Windows.Forms.Label();
            this.gBOrderHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBOrderHolder
            // 
            this.gBOrderHolder.Controls.Add(this.rBPrefer);
            this.gBOrderHolder.Controls.Add(this.rBCommon);
            this.gBOrderHolder.Controls.Add(this.rBSecondName);
            this.gBOrderHolder.Controls.Add(this.rBFirstName);
            this.gBOrderHolder.Controls.Add(this.rBId);
            this.gBOrderHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBOrderHolder.Location = new System.Drawing.Point(12, 12);
            this.gBOrderHolder.Name = "gBOrderHolder";
            this.gBOrderHolder.Size = new System.Drawing.Size(240, 172);
            this.gBOrderHolder.TabIndex = 0;
            this.gBOrderHolder.TabStop = false;
            this.gBOrderHolder.Text = "Order by";
            // 
            // rBPrefer
            // 
            this.rBPrefer.AutoSize = true;
            this.rBPrefer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBPrefer.Location = new System.Drawing.Point(6, 141);
            this.rBPrefer.Name = "rBPrefer";
            this.rBPrefer.Size = new System.Drawing.Size(222, 24);
            this.rBPrefer.TabIndex = 4;
            this.rBPrefer.TabStop = true;
            this.rBPrefer.Text = "preference Shares Quantity";
            this.rBPrefer.UseVisualStyleBackColor = true;
            // 
            // rBCommon
            // 
            this.rBCommon.AutoSize = true;
            this.rBCommon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBCommon.Location = new System.Drawing.Point(6, 111);
            this.rBCommon.Name = "rBCommon";
            this.rBCommon.Size = new System.Drawing.Size(210, 24);
            this.rBCommon.TabIndex = 3;
            this.rBCommon.TabStop = true;
            this.rBCommon.Text = "common Shares  Quantity";
            this.rBCommon.UseVisualStyleBackColor = true;
            // 
            // rBSecondName
            // 
            this.rBSecondName.AutoSize = true;
            this.rBSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBSecondName.Location = new System.Drawing.Point(6, 81);
            this.rBSecondName.Name = "rBSecondName";
            this.rBSecondName.Size = new System.Drawing.Size(132, 24);
            this.rBSecondName.TabIndex = 2;
            this.rBSecondName.TabStop = true;
            this.rBSecondName.Text = "Second  Name";
            this.rBSecondName.UseVisualStyleBackColor = true;
            // 
            // rBFirstName
            // 
            this.rBFirstName.AutoSize = true;
            this.rBFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBFirstName.Location = new System.Drawing.Point(6, 51);
            this.rBFirstName.Name = "rBFirstName";
            this.rBFirstName.Size = new System.Drawing.Size(104, 24);
            this.rBFirstName.TabIndex = 1;
            this.rBFirstName.TabStop = true;
            this.rBFirstName.Text = "First Name";
            this.rBFirstName.UseVisualStyleBackColor = true;
            // 
            // rBId
            // 
            this.rBId.AutoSize = true;
            this.rBId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBId.Location = new System.Drawing.Point(6, 21);
            this.rBId.Name = "rBId";
            this.rBId.Size = new System.Drawing.Size(41, 24);
            this.rBId.TabIndex = 0;
            this.rBId.TabStop = true;
            this.rBId.Text = "Id";
            this.rBId.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(12, 223);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(104, 38);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(168, 223);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 38);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lMessage
            // 
            this.lMessage.AutoSize = true;
            this.lMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMessage.Location = new System.Drawing.Point(12, 187);
            this.lMessage.Name = "lMessage";
            this.lMessage.Size = new System.Drawing.Size(0, 20);
            this.lMessage.TabIndex = 3;
            // 
            // HolderOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 273);
            this.Controls.Add(this.lMessage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gBOrderHolder);
            this.MaximizeBox = false;
            this.Name = "HolderOrderForm";
            this.Text = "Order by Holder";
            this.gBOrderHolder.ResumeLayout(false);
            this.gBOrderHolder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBOrderHolder;
        private System.Windows.Forms.RadioButton rBPrefer;
        private System.Windows.Forms.RadioButton rBCommon;
        private System.Windows.Forms.RadioButton rBSecondName;
        private System.Windows.Forms.RadioButton rBFirstName;
        private System.Windows.Forms.RadioButton rBId;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lMessage;
    }
}