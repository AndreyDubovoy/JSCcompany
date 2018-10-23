namespace Win_Form_DB
{
    partial class SeachHolder
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
            this.tBSecondName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGoTo = new System.Windows.Forms.Button();
            this.lFirstName = new System.Windows.Forms.Label();
            this.lSecondName = new System.Windows.Forms.Label();
            this.tBFirstName = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBSecondName
            // 
            this.tBSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBSecondName.Location = new System.Drawing.Point(140, 104);
            this.tBSecondName.Name = "tBSecondName";
            this.tBSecondName.Size = new System.Drawing.Size(189, 26);
            this.tBSecondName.TabIndex = 0;
            this.tBSecondName.Click += new System.EventHandler(this.tBSecondName_Enter);
            this.tBSecondName.Enter += new System.EventHandler(this.tBSecondName_Enter);
            this.tBSecondName.Validated += new System.EventHandler(this.tBSecondName_Enter);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(23, 217);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 32);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnGoTo
            // 
            this.btnGoTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoTo.Location = new System.Drawing.Point(231, 217);
            this.btnGoTo.Name = "btnGoTo";
            this.btnGoTo.Size = new System.Drawing.Size(98, 32);
            this.btnGoTo.TabIndex = 2;
            this.btnGoTo.Text = "Go To";
            this.btnGoTo.UseVisualStyleBackColor = true;
            this.btnGoTo.Click += new System.EventHandler(this.btnGoTo_Click);
            // 
            // lFirstName
            // 
            this.lFirstName.AutoSize = true;
            this.lFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFirstName.Location = new System.Drawing.Point(12, 33);
            this.lFirstName.Name = "lFirstName";
            this.lFirstName.Size = new System.Drawing.Size(96, 20);
            this.lFirstName.TabIndex = 3;
            this.lFirstName.Text = "First Name";
            // 
            // lSecondName
            // 
            this.lSecondName.AutoSize = true;
            this.lSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSecondName.Location = new System.Drawing.Point(12, 107);
            this.lSecondName.Name = "lSecondName";
            this.lSecondName.Size = new System.Drawing.Size(121, 20);
            this.lSecondName.TabIndex = 4;
            this.lSecondName.Text = "Second Name";
            // 
            // tBFirstName
            // 
            this.tBFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBFirstName.Location = new System.Drawing.Point(140, 30);
            this.tBFirstName.Name = "tBFirstName";
            this.tBFirstName.Size = new System.Drawing.Size(189, 26);
            this.tBFirstName.TabIndex = 5;
            this.tBFirstName.Click += new System.EventHandler(this.tBFirstName_Enter);
            this.tBFirstName.Enter += new System.EventHandler(this.tBFirstName_Enter);
            this.tBFirstName.Validated += new System.EventHandler(this.tBFirstName_Enter);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(127, 217);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 32);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // SeachHolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 261);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tBFirstName);
            this.Controls.Add(this.lSecondName);
            this.Controls.Add(this.lFirstName);
            this.Controls.Add(this.btnGoTo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tBSecondName);
            this.Location = new System.Drawing.Point(670, 120);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SeachHolder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Seach Holder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBSecondName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGoTo;
        private System.Windows.Forms.Label lFirstName;
        private System.Windows.Forms.Label lSecondName;
        private System.Windows.Forms.TextBox tBFirstName;
        private System.Windows.Forms.Button btnClear;
    }
}