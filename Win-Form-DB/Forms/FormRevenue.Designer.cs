namespace Win_Form_DB
{
    partial class FormRevenue
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
            this.gBFrom = new System.Windows.Forms.GroupBox();
            this.lFromT = new System.Windows.Forms.Label();
            this.lFromAP = new System.Windows.Forms.Label();
            this.lFromAC = new System.Windows.Forms.Label();
            this.lFromPP = new System.Windows.Forms.Label();
            this.lFromPC = new System.Windows.Forms.Label();
            this.lFromQP = new System.Windows.Forms.Label();
            this.lFromQC = new System.Windows.Forms.Label();
            this.lTotalFrom = new System.Windows.Forms.Label();
            this.lAmountFrom = new System.Windows.Forms.Label();
            this.lPriceFrom = new System.Windows.Forms.Label();
            this.lQuantityFrom = new System.Windows.Forms.Label();
            this.lTitulFrom = new System.Windows.Forms.Label();
            this.dTPFrom = new System.Windows.Forms.DateTimePicker();
            this.gBTo = new System.Windows.Forms.GroupBox();
            this.lToT = new System.Windows.Forms.Label();
            this.lToAP = new System.Windows.Forms.Label();
            this.lToAC = new System.Windows.Forms.Label();
            this.lToPP = new System.Windows.Forms.Label();
            this.lToPC = new System.Windows.Forms.Label();
            this.lToQP = new System.Windows.Forms.Label();
            this.lToQC = new System.Windows.Forms.Label();
            this.lTotalTo = new System.Windows.Forms.Label();
            this.lAmountTo = new System.Windows.Forms.Label();
            this.lPriceTo = new System.Windows.Forms.Label();
            this.lQuantityTo = new System.Windows.Forms.Label();
            this.lTitulTo = new System.Windows.Forms.Label();
            this.dTPTo = new System.Windows.Forms.DateTimePicker();
            this.gBTrade = new System.Windows.Forms.GroupBox();
            this.lTradeC = new System.Windows.Forms.Label();
            this.lTradeD = new System.Windows.Forms.Label();
            this.lTradePSA = new System.Windows.Forms.Label();
            this.lTradePSP = new System.Windows.Forms.Label();
            this.lTradePSQ = new System.Windows.Forms.Label();
            this.lTradePBA = new System.Windows.Forms.Label();
            this.lTradePBP = new System.Windows.Forms.Label();
            this.lTradePBQ = new System.Windows.Forms.Label();
            this.lTradeCSA = new System.Windows.Forms.Label();
            this.lTradeCSP = new System.Windows.Forms.Label();
            this.lTradeCSQ = new System.Windows.Forms.Label();
            this.lTradeCBA = new System.Windows.Forms.Label();
            this.lTradeCBP = new System.Windows.Forms.Label();
            this.lTradeCBQ = new System.Windows.Forms.Label();
            this.lTradeT = new System.Windows.Forms.Label();
            this.lTotalTrade = new System.Windows.Forms.Label();
            this.lComission = new System.Windows.Forms.Label();
            this.lDividends = new System.Windows.Forms.Label();
            this.lSalePref = new System.Windows.Forms.Label();
            this.lBuyPref = new System.Windows.Forms.Label();
            this.lTitulPref = new System.Windows.Forms.Label();
            this.lSaleCommon = new System.Windows.Forms.Label();
            this.lBuyCommon = new System.Windows.Forms.Label();
            this.lTitulCommon = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRecount = new System.Windows.Forms.Button();
            this.lRevenue = new System.Windows.Forms.Label();
            this.lRevenueP = new System.Windows.Forms.Label();
            this.gBFrom.SuspendLayout();
            this.gBTo.SuspendLayout();
            this.gBTrade.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBFrom
            // 
            this.gBFrom.Controls.Add(this.lFromT);
            this.gBFrom.Controls.Add(this.lFromAP);
            this.gBFrom.Controls.Add(this.lFromAC);
            this.gBFrom.Controls.Add(this.lFromPP);
            this.gBFrom.Controls.Add(this.lFromPC);
            this.gBFrom.Controls.Add(this.lFromQP);
            this.gBFrom.Controls.Add(this.lFromQC);
            this.gBFrom.Controls.Add(this.lTotalFrom);
            this.gBFrom.Controls.Add(this.lAmountFrom);
            this.gBFrom.Controls.Add(this.lPriceFrom);
            this.gBFrom.Controls.Add(this.lQuantityFrom);
            this.gBFrom.Controls.Add(this.lTitulFrom);
            this.gBFrom.Controls.Add(this.dTPFrom);
            this.gBFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBFrom.Location = new System.Drawing.Point(12, 12);
            this.gBFrom.Name = "gBFrom";
            this.gBFrom.Size = new System.Drawing.Size(349, 378);
            this.gBFrom.TabIndex = 0;
            this.gBFrom.TabStop = false;
            this.gBFrom.Text = "From date";
            // 
            // lFromT
            // 
            this.lFromT.AutoSize = true;
            this.lFromT.Location = new System.Drawing.Point(71, 335);
            this.lFromT.Name = "lFromT";
            this.lFromT.Size = new System.Drawing.Size(63, 20);
            this.lFromT.TabIndex = 12;
            this.lFromT.Text = "000000";
            // 
            // lFromAP
            // 
            this.lFromAP.AutoSize = true;
            this.lFromAP.Location = new System.Drawing.Point(227, 213);
            this.lFromAP.Name = "lFromAP";
            this.lFromAP.Size = new System.Drawing.Size(63, 20);
            this.lFromAP.TabIndex = 11;
            this.lFromAP.Text = "000000";
            // 
            // lFromAC
            // 
            this.lFromAC.AutoSize = true;
            this.lFromAC.Location = new System.Drawing.Point(131, 213);
            this.lFromAC.Name = "lFromAC";
            this.lFromAC.Size = new System.Drawing.Size(63, 20);
            this.lFromAC.TabIndex = 10;
            this.lFromAC.Text = "000000";
            // 
            // lFromPP
            // 
            this.lFromPP.AutoSize = true;
            this.lFromPP.Location = new System.Drawing.Point(227, 167);
            this.lFromPP.Name = "lFromPP";
            this.lFromPP.Size = new System.Drawing.Size(63, 20);
            this.lFromPP.TabIndex = 9;
            this.lFromPP.Text = "000000";
            // 
            // lFromPC
            // 
            this.lFromPC.AutoSize = true;
            this.lFromPC.Location = new System.Drawing.Point(131, 167);
            this.lFromPC.Name = "lFromPC";
            this.lFromPC.Size = new System.Drawing.Size(63, 20);
            this.lFromPC.TabIndex = 8;
            this.lFromPC.Text = "000000";
            // 
            // lFromQP
            // 
            this.lFromQP.AutoSize = true;
            this.lFromQP.Location = new System.Drawing.Point(227, 123);
            this.lFromQP.Name = "lFromQP";
            this.lFromQP.Size = new System.Drawing.Size(63, 20);
            this.lFromQP.TabIndex = 7;
            this.lFromQP.Text = "000000";
            // 
            // lFromQC
            // 
            this.lFromQC.AutoSize = true;
            this.lFromQC.Location = new System.Drawing.Point(131, 123);
            this.lFromQC.Name = "lFromQC";
            this.lFromQC.Size = new System.Drawing.Size(63, 20);
            this.lFromQC.TabIndex = 6;
            this.lFromQC.Text = "000000";
            // 
            // lTotalFrom
            // 
            this.lTotalFrom.AutoSize = true;
            this.lTotalFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotalFrom.Location = new System.Drawing.Point(6, 335);
            this.lTotalFrom.Name = "lTotalFrom";
            this.lTotalFrom.Size = new System.Drawing.Size(49, 20);
            this.lTotalFrom.TabIndex = 5;
            this.lTotalFrom.Text = "Total";
            // 
            // lAmountFrom
            // 
            this.lAmountFrom.AutoSize = true;
            this.lAmountFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAmountFrom.Location = new System.Drawing.Point(6, 213);
            this.lAmountFrom.Name = "lAmountFrom";
            this.lAmountFrom.Size = new System.Drawing.Size(65, 20);
            this.lAmountFrom.TabIndex = 4;
            this.lAmountFrom.Text = "Amount";
            // 
            // lPriceFrom
            // 
            this.lPriceFrom.AutoSize = true;
            this.lPriceFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPriceFrom.Location = new System.Drawing.Point(6, 167);
            this.lPriceFrom.Name = "lPriceFrom";
            this.lPriceFrom.Size = new System.Drawing.Size(44, 20);
            this.lPriceFrom.TabIndex = 3;
            this.lPriceFrom.Text = "Price";
            // 
            // lQuantityFrom
            // 
            this.lQuantityFrom.AutoSize = true;
            this.lQuantityFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lQuantityFrom.Location = new System.Drawing.Point(6, 123);
            this.lQuantityFrom.Name = "lQuantityFrom";
            this.lQuantityFrom.Size = new System.Drawing.Size(68, 20);
            this.lQuantityFrom.TabIndex = 2;
            this.lQuantityFrom.Text = "Quantity";
            // 
            // lTitulFrom
            // 
            this.lTitulFrom.AutoSize = true;
            this.lTitulFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitulFrom.Location = new System.Drawing.Point(131, 77);
            this.lTitulFrom.Name = "lTitulFrom";
            this.lTitulFrom.Size = new System.Drawing.Size(179, 20);
            this.lTitulFrom.TabIndex = 1;
            this.lTitulFrom.Text = "Common       Preference";
            // 
            // dTPFrom
            // 
            this.dTPFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPFrom.Location = new System.Drawing.Point(6, 19);
            this.dTPFrom.Name = "dTPFrom";
            this.dTPFrom.Size = new System.Drawing.Size(304, 26);
            this.dTPFrom.TabIndex = 0;
            this.dTPFrom.Validated += new System.EventHandler(this.dTPFrom_Validated);
            // 
            // gBTo
            // 
            this.gBTo.Controls.Add(this.lToT);
            this.gBTo.Controls.Add(this.lToAP);
            this.gBTo.Controls.Add(this.lToAC);
            this.gBTo.Controls.Add(this.lToPP);
            this.gBTo.Controls.Add(this.lToPC);
            this.gBTo.Controls.Add(this.lToQP);
            this.gBTo.Controls.Add(this.lToQC);
            this.gBTo.Controls.Add(this.lTotalTo);
            this.gBTo.Controls.Add(this.lAmountTo);
            this.gBTo.Controls.Add(this.lPriceTo);
            this.gBTo.Controls.Add(this.lQuantityTo);
            this.gBTo.Controls.Add(this.lTitulTo);
            this.gBTo.Controls.Add(this.dTPTo);
            this.gBTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBTo.Location = new System.Drawing.Point(722, 12);
            this.gBTo.Name = "gBTo";
            this.gBTo.Size = new System.Drawing.Size(348, 378);
            this.gBTo.TabIndex = 1;
            this.gBTo.TabStop = false;
            this.gBTo.Text = "To date";
            // 
            // lToT
            // 
            this.lToT.AutoSize = true;
            this.lToT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lToT.Location = new System.Drawing.Point(92, 335);
            this.lToT.Name = "lToT";
            this.lToT.Size = new System.Drawing.Size(63, 20);
            this.lToT.TabIndex = 13;
            this.lToT.Text = "000000";
            // 
            // lToAP
            // 
            this.lToAP.AutoSize = true;
            this.lToAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lToAP.Location = new System.Drawing.Point(233, 213);
            this.lToAP.Name = "lToAP";
            this.lToAP.Size = new System.Drawing.Size(63, 20);
            this.lToAP.TabIndex = 12;
            this.lToAP.Text = "000000";
            // 
            // lToAC
            // 
            this.lToAC.AutoSize = true;
            this.lToAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lToAC.Location = new System.Drawing.Point(140, 213);
            this.lToAC.Name = "lToAC";
            this.lToAC.Size = new System.Drawing.Size(63, 20);
            this.lToAC.TabIndex = 11;
            this.lToAC.Text = "000000";
            // 
            // lToPP
            // 
            this.lToPP.AutoSize = true;
            this.lToPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lToPP.Location = new System.Drawing.Point(233, 167);
            this.lToPP.Name = "lToPP";
            this.lToPP.Size = new System.Drawing.Size(63, 20);
            this.lToPP.TabIndex = 10;
            this.lToPP.Text = "000000";
            // 
            // lToPC
            // 
            this.lToPC.AutoSize = true;
            this.lToPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lToPC.Location = new System.Drawing.Point(140, 167);
            this.lToPC.Name = "lToPC";
            this.lToPC.Size = new System.Drawing.Size(63, 20);
            this.lToPC.TabIndex = 9;
            this.lToPC.Text = "000000";
            // 
            // lToQP
            // 
            this.lToQP.AutoSize = true;
            this.lToQP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lToQP.Location = new System.Drawing.Point(233, 123);
            this.lToQP.Name = "lToQP";
            this.lToQP.Size = new System.Drawing.Size(63, 20);
            this.lToQP.TabIndex = 8;
            this.lToQP.Text = "000000";
            // 
            // lToQC
            // 
            this.lToQC.AutoSize = true;
            this.lToQC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lToQC.Location = new System.Drawing.Point(140, 123);
            this.lToQC.Name = "lToQC";
            this.lToQC.Size = new System.Drawing.Size(63, 20);
            this.lToQC.TabIndex = 7;
            this.lToQC.Text = "000000";
            // 
            // lTotalTo
            // 
            this.lTotalTo.AutoSize = true;
            this.lTotalTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotalTo.Location = new System.Drawing.Point(6, 335);
            this.lTotalTo.Name = "lTotalTo";
            this.lTotalTo.Size = new System.Drawing.Size(49, 20);
            this.lTotalTo.TabIndex = 6;
            this.lTotalTo.Text = "Total";
            // 
            // lAmountTo
            // 
            this.lAmountTo.AutoSize = true;
            this.lAmountTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAmountTo.Location = new System.Drawing.Point(6, 213);
            this.lAmountTo.Name = "lAmountTo";
            this.lAmountTo.Size = new System.Drawing.Size(65, 20);
            this.lAmountTo.TabIndex = 5;
            this.lAmountTo.Text = "Amount";
            // 
            // lPriceTo
            // 
            this.lPriceTo.AutoSize = true;
            this.lPriceTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPriceTo.Location = new System.Drawing.Point(6, 167);
            this.lPriceTo.Name = "lPriceTo";
            this.lPriceTo.Size = new System.Drawing.Size(44, 20);
            this.lPriceTo.TabIndex = 4;
            this.lPriceTo.Text = "Price";
            // 
            // lQuantityTo
            // 
            this.lQuantityTo.AutoSize = true;
            this.lQuantityTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lQuantityTo.Location = new System.Drawing.Point(6, 123);
            this.lQuantityTo.Name = "lQuantityTo";
            this.lQuantityTo.Size = new System.Drawing.Size(68, 20);
            this.lQuantityTo.TabIndex = 3;
            this.lQuantityTo.Text = "Quantity";
            // 
            // lTitulTo
            // 
            this.lTitulTo.AutoSize = true;
            this.lTitulTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitulTo.Location = new System.Drawing.Point(131, 77);
            this.lTitulTo.Name = "lTitulTo";
            this.lTitulTo.Size = new System.Drawing.Size(179, 20);
            this.lTitulTo.TabIndex = 2;
            this.lTitulTo.Text = "Common       Preference";
            // 
            // dTPTo
            // 
            this.dTPTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPTo.Location = new System.Drawing.Point(6, 19);
            this.dTPTo.Name = "dTPTo";
            this.dTPTo.Size = new System.Drawing.Size(304, 26);
            this.dTPTo.TabIndex = 1;
            this.dTPTo.Validated += new System.EventHandler(this.dTPTo_Validated);
            // 
            // gBTrade
            // 
            this.gBTrade.Controls.Add(this.lTradeC);
            this.gBTrade.Controls.Add(this.lTradeD);
            this.gBTrade.Controls.Add(this.lTradePSA);
            this.gBTrade.Controls.Add(this.lTradePSP);
            this.gBTrade.Controls.Add(this.lTradePSQ);
            this.gBTrade.Controls.Add(this.lTradePBA);
            this.gBTrade.Controls.Add(this.lTradePBP);
            this.gBTrade.Controls.Add(this.lTradePBQ);
            this.gBTrade.Controls.Add(this.lTradeCSA);
            this.gBTrade.Controls.Add(this.lTradeCSP);
            this.gBTrade.Controls.Add(this.lTradeCSQ);
            this.gBTrade.Controls.Add(this.lTradeCBA);
            this.gBTrade.Controls.Add(this.lTradeCBP);
            this.gBTrade.Controls.Add(this.lTradeCBQ);
            this.gBTrade.Controls.Add(this.lTradeT);
            this.gBTrade.Controls.Add(this.lTotalTrade);
            this.gBTrade.Controls.Add(this.lComission);
            this.gBTrade.Controls.Add(this.lDividends);
            this.gBTrade.Controls.Add(this.lSalePref);
            this.gBTrade.Controls.Add(this.lBuyPref);
            this.gBTrade.Controls.Add(this.lTitulPref);
            this.gBTrade.Controls.Add(this.lSaleCommon);
            this.gBTrade.Controls.Add(this.lBuyCommon);
            this.gBTrade.Controls.Add(this.lTitulCommon);
            this.gBTrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBTrade.Location = new System.Drawing.Point(367, 12);
            this.gBTrade.Name = "gBTrade";
            this.gBTrade.Size = new System.Drawing.Size(349, 378);
            this.gBTrade.TabIndex = 2;
            this.gBTrade.TabStop = false;
            this.gBTrade.Text = "Trade";
            // 
            // lTradeC
            // 
            this.lTradeC.AutoSize = true;
            this.lTradeC.BackColor = System.Drawing.Color.Red;
            this.lTradeC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTradeC.Location = new System.Drawing.Point(109, 283);
            this.lTradeC.Name = "lTradeC";
            this.lTradeC.Size = new System.Drawing.Size(63, 20);
            this.lTradeC.TabIndex = 27;
            this.lTradeC.Text = "000000";
            // 
            // lTradeD
            // 
            this.lTradeD.AutoSize = true;
            this.lTradeD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTradeD.Location = new System.Drawing.Point(109, 237);
            this.lTradeD.Name = "lTradeD";
            this.lTradeD.Size = new System.Drawing.Size(63, 20);
            this.lTradeD.TabIndex = 26;
            this.lTradeD.Text = "000000";
            // 
            // lTradePSA
            // 
            this.lTradePSA.AutoSize = true;
            this.lTradePSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTradePSA.Location = new System.Drawing.Point(264, 188);
            this.lTradePSA.Name = "lTradePSA";
            this.lTradePSA.Size = new System.Drawing.Size(63, 20);
            this.lTradePSA.TabIndex = 25;
            this.lTradePSA.Text = "000000";
            // 
            // lTradePSP
            // 
            this.lTradePSP.AutoSize = true;
            this.lTradePSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTradePSP.Location = new System.Drawing.Point(189, 188);
            this.lTradePSP.Name = "lTradePSP";
            this.lTradePSP.Size = new System.Drawing.Size(63, 20);
            this.lTradePSP.TabIndex = 24;
            this.lTradePSP.Text = "000000";
            // 
            // lTradePSQ
            // 
            this.lTradePSQ.AutoSize = true;
            this.lTradePSQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTradePSQ.Location = new System.Drawing.Point(109, 188);
            this.lTradePSQ.Name = "lTradePSQ";
            this.lTradePSQ.Size = new System.Drawing.Size(63, 20);
            this.lTradePSQ.TabIndex = 23;
            this.lTradePSQ.Text = "000000";
            // 
            // lTradePBA
            // 
            this.lTradePBA.AutoSize = true;
            this.lTradePBA.BackColor = System.Drawing.Color.Red;
            this.lTradePBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTradePBA.Location = new System.Drawing.Point(264, 154);
            this.lTradePBA.Name = "lTradePBA";
            this.lTradePBA.Size = new System.Drawing.Size(63, 20);
            this.lTradePBA.TabIndex = 22;
            this.lTradePBA.Text = "000000";
            // 
            // lTradePBP
            // 
            this.lTradePBP.AutoSize = true;
            this.lTradePBP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTradePBP.Location = new System.Drawing.Point(189, 154);
            this.lTradePBP.Name = "lTradePBP";
            this.lTradePBP.Size = new System.Drawing.Size(63, 20);
            this.lTradePBP.TabIndex = 21;
            this.lTradePBP.Text = "000000";
            // 
            // lTradePBQ
            // 
            this.lTradePBQ.AutoSize = true;
            this.lTradePBQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTradePBQ.Location = new System.Drawing.Point(109, 154);
            this.lTradePBQ.Name = "lTradePBQ";
            this.lTradePBQ.Size = new System.Drawing.Size(63, 20);
            this.lTradePBQ.TabIndex = 20;
            this.lTradePBQ.Text = "000000";
            // 
            // lTradeCSA
            // 
            this.lTradeCSA.AutoSize = true;
            this.lTradeCSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTradeCSA.Location = new System.Drawing.Point(264, 88);
            this.lTradeCSA.Name = "lTradeCSA";
            this.lTradeCSA.Size = new System.Drawing.Size(63, 20);
            this.lTradeCSA.TabIndex = 19;
            this.lTradeCSA.Text = "000000";
            // 
            // lTradeCSP
            // 
            this.lTradeCSP.AutoSize = true;
            this.lTradeCSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTradeCSP.Location = new System.Drawing.Point(189, 88);
            this.lTradeCSP.Name = "lTradeCSP";
            this.lTradeCSP.Size = new System.Drawing.Size(63, 20);
            this.lTradeCSP.TabIndex = 18;
            this.lTradeCSP.Text = "000000";
            // 
            // lTradeCSQ
            // 
            this.lTradeCSQ.AutoSize = true;
            this.lTradeCSQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTradeCSQ.Location = new System.Drawing.Point(109, 88);
            this.lTradeCSQ.Name = "lTradeCSQ";
            this.lTradeCSQ.Size = new System.Drawing.Size(63, 20);
            this.lTradeCSQ.TabIndex = 17;
            this.lTradeCSQ.Text = "000000";
            // 
            // lTradeCBA
            // 
            this.lTradeCBA.AutoSize = true;
            this.lTradeCBA.BackColor = System.Drawing.Color.Red;
            this.lTradeCBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTradeCBA.Location = new System.Drawing.Point(264, 55);
            this.lTradeCBA.Name = "lTradeCBA";
            this.lTradeCBA.Size = new System.Drawing.Size(63, 20);
            this.lTradeCBA.TabIndex = 16;
            this.lTradeCBA.Text = "000000";
            // 
            // lTradeCBP
            // 
            this.lTradeCBP.AutoSize = true;
            this.lTradeCBP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTradeCBP.Location = new System.Drawing.Point(189, 55);
            this.lTradeCBP.Name = "lTradeCBP";
            this.lTradeCBP.Size = new System.Drawing.Size(63, 20);
            this.lTradeCBP.TabIndex = 15;
            this.lTradeCBP.Text = "000000";
            // 
            // lTradeCBQ
            // 
            this.lTradeCBQ.AutoSize = true;
            this.lTradeCBQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTradeCBQ.Location = new System.Drawing.Point(109, 55);
            this.lTradeCBQ.Name = "lTradeCBQ";
            this.lTradeCBQ.Size = new System.Drawing.Size(63, 20);
            this.lTradeCBQ.TabIndex = 14;
            this.lTradeCBQ.Text = "000000";
            // 
            // lTradeT
            // 
            this.lTradeT.AutoSize = true;
            this.lTradeT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTradeT.Location = new System.Drawing.Point(79, 335);
            this.lTradeT.Name = "lTradeT";
            this.lTradeT.Size = new System.Drawing.Size(63, 20);
            this.lTradeT.TabIndex = 13;
            this.lTradeT.Text = "000000";
            // 
            // lTotalTrade
            // 
            this.lTotalTrade.AutoSize = true;
            this.lTotalTrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotalTrade.Location = new System.Drawing.Point(6, 335);
            this.lTotalTrade.Name = "lTotalTrade";
            this.lTotalTrade.Size = new System.Drawing.Size(49, 20);
            this.lTotalTrade.TabIndex = 11;
            this.lTotalTrade.Text = "Total";
            // 
            // lComission
            // 
            this.lComission.AutoSize = true;
            this.lComission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lComission.Location = new System.Drawing.Point(6, 283);
            this.lComission.Name = "lComission";
            this.lComission.Size = new System.Drawing.Size(82, 20);
            this.lComission.TabIndex = 10;
            this.lComission.Text = "Comission";
            // 
            // lDividends
            // 
            this.lDividends.AutoSize = true;
            this.lDividends.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDividends.Location = new System.Drawing.Point(6, 237);
            this.lDividends.Name = "lDividends";
            this.lDividends.Size = new System.Drawing.Size(78, 20);
            this.lDividends.TabIndex = 9;
            this.lDividends.Text = "Dividends";
            // 
            // lSalePref
            // 
            this.lSalePref.AutoSize = true;
            this.lSalePref.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSalePref.Location = new System.Drawing.Point(31, 188);
            this.lSalePref.Name = "lSalePref";
            this.lSalePref.Size = new System.Drawing.Size(41, 20);
            this.lSalePref.TabIndex = 8;
            this.lSalePref.Text = "Sale";
            // 
            // lBuyPref
            // 
            this.lBuyPref.AutoSize = true;
            this.lBuyPref.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBuyPref.Location = new System.Drawing.Point(36, 154);
            this.lBuyPref.Name = "lBuyPref";
            this.lBuyPref.Size = new System.Drawing.Size(36, 20);
            this.lBuyPref.TabIndex = 7;
            this.lBuyPref.Text = "Buy";
            // 
            // lTitulPref
            // 
            this.lTitulPref.AutoSize = true;
            this.lTitulPref.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitulPref.Location = new System.Drawing.Point(6, 123);
            this.lTitulPref.Name = "lTitulPref";
            this.lTitulPref.Size = new System.Drawing.Size(321, 20);
            this.lTitulPref.TabIndex = 6;
            this.lTitulPref.Text = "Preference      Quantity        Price       Amount";
            // 
            // lSaleCommon
            // 
            this.lSaleCommon.AutoSize = true;
            this.lSaleCommon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSaleCommon.Location = new System.Drawing.Point(31, 88);
            this.lSaleCommon.Name = "lSaleCommon";
            this.lSaleCommon.Size = new System.Drawing.Size(41, 20);
            this.lSaleCommon.TabIndex = 5;
            this.lSaleCommon.Text = "Sale";
            // 
            // lBuyCommon
            // 
            this.lBuyCommon.AutoSize = true;
            this.lBuyCommon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBuyCommon.Location = new System.Drawing.Point(36, 55);
            this.lBuyCommon.Name = "lBuyCommon";
            this.lBuyCommon.Size = new System.Drawing.Size(36, 20);
            this.lBuyCommon.TabIndex = 4;
            this.lBuyCommon.Text = "Buy";
            // 
            // lTitulCommon
            // 
            this.lTitulCommon.AutoSize = true;
            this.lTitulCommon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitulCommon.Location = new System.Drawing.Point(6, 25);
            this.lTitulCommon.Name = "lTitulCommon";
            this.lTitulCommon.Size = new System.Drawing.Size(319, 20);
            this.lTitulCommon.TabIndex = 2;
            this.lTitulCommon.Text = "Common         Quantity        Price       Amount";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(22, 414);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 37);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRecount
            // 
            this.btnRecount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecount.Location = new System.Drawing.Point(198, 414);
            this.btnRecount.Name = "btnRecount";
            this.btnRecount.Size = new System.Drawing.Size(124, 37);
            this.btnRecount.TabIndex = 4;
            this.btnRecount.Text = "Recount";
            this.btnRecount.UseVisualStyleBackColor = true;
            this.btnRecount.Click += new System.EventHandler(this.btnRecount_Click);
            // 
            // lRevenue
            // 
            this.lRevenue.AutoSize = true;
            this.lRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRevenue.Location = new System.Drawing.Point(724, 414);
            this.lRevenue.Name = "lRevenue";
            this.lRevenue.Size = new System.Drawing.Size(94, 24);
            this.lRevenue.TabIndex = 5;
            this.lRevenue.Text = "Revenue";
            // 
            // lRevenueP
            // 
            this.lRevenueP.AutoSize = true;
            this.lRevenueP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRevenueP.Location = new System.Drawing.Point(814, 414);
            this.lRevenueP.Name = "lRevenueP";
            this.lRevenueP.Size = new System.Drawing.Size(76, 24);
            this.lRevenueP.TabIndex = 8;
            this.lRevenueP.Text = "000000";
            // 
            // FormRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 463);
            this.Controls.Add(this.lRevenueP);
            this.Controls.Add(this.lRevenue);
            this.Controls.Add(this.btnRecount);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gBTrade);
            this.Controls.Add(this.gBTo);
            this.Controls.Add(this.gBFrom);
            this.Name = "FormRevenue";
            this.Text = "Revenue for the period";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRevenue_FormClosing);
            this.gBFrom.ResumeLayout(false);
            this.gBFrom.PerformLayout();
            this.gBTo.ResumeLayout(false);
            this.gBTo.PerformLayout();
            this.gBTrade.ResumeLayout(false);
            this.gBTrade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBFrom;
        private System.Windows.Forms.DateTimePicker dTPFrom;
        private System.Windows.Forms.GroupBox gBTo;
        private System.Windows.Forms.DateTimePicker dTPTo;
        private System.Windows.Forms.GroupBox gBTrade;
        private System.Windows.Forms.Label lTotalFrom;
        private System.Windows.Forms.Label lAmountFrom;
        private System.Windows.Forms.Label lPriceFrom;
        private System.Windows.Forms.Label lQuantityFrom;
        private System.Windows.Forms.Label lTitulFrom;
        private System.Windows.Forms.Label lTotalTo;
        private System.Windows.Forms.Label lAmountTo;
        private System.Windows.Forms.Label lPriceTo;
        private System.Windows.Forms.Label lQuantityTo;
        private System.Windows.Forms.Label lTitulTo;
        private System.Windows.Forms.Label lTitulPref;
        private System.Windows.Forms.Label lSaleCommon;
        private System.Windows.Forms.Label lBuyCommon;
        private System.Windows.Forms.Label lTitulCommon;
        private System.Windows.Forms.Label lTotalTrade;
        private System.Windows.Forms.Label lComission;
        private System.Windows.Forms.Label lDividends;
        private System.Windows.Forms.Label lSalePref;
        private System.Windows.Forms.Label lBuyPref;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRecount;
        private System.Windows.Forms.Label lFromT;
        private System.Windows.Forms.Label lFromAP;
        private System.Windows.Forms.Label lFromAC;
        private System.Windows.Forms.Label lFromPP;
        private System.Windows.Forms.Label lFromPC;
        private System.Windows.Forms.Label lFromQP;
        private System.Windows.Forms.Label lFromQC;
        private System.Windows.Forms.Label lToT;
        private System.Windows.Forms.Label lToAP;
        private System.Windows.Forms.Label lToAC;
        private System.Windows.Forms.Label lToPP;
        private System.Windows.Forms.Label lToPC;
        private System.Windows.Forms.Label lToQP;
        private System.Windows.Forms.Label lToQC;
        private System.Windows.Forms.Label lTradeC;
        private System.Windows.Forms.Label lTradeD;
        private System.Windows.Forms.Label lTradePSA;
        private System.Windows.Forms.Label lTradePSP;
        private System.Windows.Forms.Label lTradePSQ;
        private System.Windows.Forms.Label lTradePBA;
        private System.Windows.Forms.Label lTradePBP;
        private System.Windows.Forms.Label lTradePBQ;
        private System.Windows.Forms.Label lTradeCSA;
        private System.Windows.Forms.Label lTradeCSP;
        private System.Windows.Forms.Label lTradeCSQ;
        private System.Windows.Forms.Label lTradeCBA;
        private System.Windows.Forms.Label lTradeCBP;
        private System.Windows.Forms.Label lTradeCBQ;
        private System.Windows.Forms.Label lTradeT;
        private System.Windows.Forms.Label lRevenue;
        private System.Windows.Forms.Label lRevenueP;
    }
}