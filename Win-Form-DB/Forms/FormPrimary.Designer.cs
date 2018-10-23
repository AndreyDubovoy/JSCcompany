namespace JointStockCompany
{
    partial class FormPrimary
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
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.UserMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLogMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.holdersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tradeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CabinetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dividendsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lNameCompany = new System.Windows.Forms.Label();
            this.lMessage = new System.Windows.Forms.Label();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserMenuItem,
            this.holdersMenuItem,
            this.tradeMenuItem,
            this.CabinetMenuItem,
            this.dividendsMenuItem,
            this.settingsMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(836, 33);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // UserMenuItem
            // 
            this.UserMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenuItem,
            this.closeMenuItem,
            this.showLogMenuItem});
            this.UserMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserMenuItem.Name = "UserMenuItem";
            this.UserMenuItem.Size = new System.Drawing.Size(64, 29);
            this.UserMenuItem.Text = "User";
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.Size = new System.Drawing.Size(211, 30);
            this.openMenuItem.Text = "Open Connect";
            this.openMenuItem.Click += new System.EventHandler(this.openMenuItem_Click);
            // 
            // closeMenuItem
            // 
            this.closeMenuItem.Name = "closeMenuItem";
            this.closeMenuItem.Size = new System.Drawing.Size(211, 30);
            this.closeMenuItem.Text = "Close Connect";
            this.closeMenuItem.Click += new System.EventHandler(this.closeMenuItem_Click);
            // 
            // showLogMenuItem
            // 
            this.showLogMenuItem.Name = "showLogMenuItem";
            this.showLogMenuItem.Size = new System.Drawing.Size(211, 30);
            this.showLogMenuItem.Text = "Show Log";
            this.showLogMenuItem.Click += new System.EventHandler(this.showLogMenuItem_Click);
            // 
            // holdersMenuItem
            // 
            this.holdersMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holdersMenuItem.Name = "holdersMenuItem";
            this.holdersMenuItem.Size = new System.Drawing.Size(86, 29);
            this.holdersMenuItem.Text = "Holder";
            this.holdersMenuItem.Click += new System.EventHandler(this.holdersMenuItem_Click);
            // 
            // tradeMenuItem
            // 
            this.tradeMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tradeMenuItem.Name = "tradeMenuItem";
            this.tradeMenuItem.Size = new System.Drawing.Size(74, 29);
            this.tradeMenuItem.Text = "Trade";
            this.tradeMenuItem.Click += new System.EventHandler(this.tradeMenuItem_Click);
            // 
            // CabinetMenuItem
            // 
            this.CabinetMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CabinetMenuItem.Name = "CabinetMenuItem";
            this.CabinetMenuItem.Size = new System.Drawing.Size(92, 29);
            this.CabinetMenuItem.Text = "Cabinet";
            this.CabinetMenuItem.Click += new System.EventHandler(this.CabinetMenuItem_Click);
            // 
            // dividendsMenuItem
            // 
            this.dividendsMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividendsMenuItem.Name = "dividendsMenuItem";
            this.dividendsMenuItem.Size = new System.Drawing.Size(112, 29);
            this.dividendsMenuItem.Text = "Dividends";
            this.dividendsMenuItem.Click += new System.EventHandler(this.dividendsMenuItem_Click);
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsMenuItem.Name = "settingsMenuItem";
            this.settingsMenuItem.Size = new System.Drawing.Size(96, 29);
            this.settingsMenuItem.Text = "Settings";
            this.settingsMenuItem.Click += new System.EventHandler(this.settingsMenuItem_Click);
            // 
            // lNameCompany
            // 
            this.lNameCompany.AutoSize = true;
            this.lNameCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameCompany.Location = new System.Drawing.Point(53, 167);
            this.lNameCompany.Name = "lNameCompany";
            this.lNameCompany.Size = new System.Drawing.Size(0, 73);
            this.lNameCompany.TabIndex = 1;
            // 
            // lMessage
            // 
            this.lMessage.AutoSize = true;
            this.lMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMessage.Location = new System.Drawing.Point(83, 43);
            this.lMessage.Name = "lMessage";
            this.lMessage.Size = new System.Drawing.Size(0, 20);
            this.lMessage.TabIndex = 2;
            // 
            // FormPrimary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 436);
            this.Controls.Add(this.lMessage);
            this.Controls.Add(this.lNameCompany);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "FormPrimary";
            this.Text = "FormPrimary";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem UserMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem holdersMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tradeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CabinetMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dividendsMenuItem;
        public System.Windows.Forms.Label lNameCompany;
        private System.Windows.Forms.ToolStripMenuItem settingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLogMenuItem;
        public System.Windows.Forms.Label lMessage;
    }
}

