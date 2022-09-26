
namespace DesktopUI
{
    partial class BalanceScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BalanceScreen));
            this.ReportGrpBx = new System.Windows.Forms.GroupBox();
            this.ClearReportBtn = new System.Windows.Forms.Button();
            this.ReportRtb = new System.Windows.Forms.RichTextBox();
            this.ReportTypesCmbBx = new System.Windows.Forms.ComboBox();
            this.AnalyzeGrpBx = new System.Windows.Forms.GroupBox();
            this.TimePeriodPnl = new System.Windows.Forms.Panel();
            this.SecondYearTxtBx = new System.Windows.Forms.TextBox();
            this.FirstYearTxtBx = new System.Windows.Forms.TextBox();
            this.FirstTimeTxt = new System.Windows.Forms.TextBox();
            this.SecondQuarterCmbBx = new System.Windows.Forms.ComboBox();
            this.FirstQuarterCmbBx = new System.Windows.Forms.ComboBox();
            this.SecondTimeTxt = new System.Windows.Forms.TextBox();
            this.ReportTypePnl = new System.Windows.Forms.Panel();
            this.FinancialItemGrpBx = new System.Windows.Forms.GroupBox();
            this.PrepaidExpensesChkBx = new System.Windows.Forms.CheckBox();
            this.IntangibleFixedAssetsChkBx = new System.Windows.Forms.CheckBox();
            this.AccumProfitLossChkBx = new System.Windows.Forms.CheckBox();
            this.FinancialDebtsChkBx = new System.Windows.Forms.CheckBox();
            this.TradeDebtsChkBx = new System.Windows.Forms.CheckBox();
            this.LongTermLiabilitiesChkBx = new System.Windows.Forms.CheckBox();
            this.ShortTermLiabilitiesChkBx = new System.Windows.Forms.CheckBox();
            this.FixedAssetsChkBx = new System.Windows.Forms.CheckBox();
            this.CurrentAssestsChkBx = new System.Windows.Forms.CheckBox();
            this.StocksChkBx = new System.Windows.Forms.CheckBox();
            this.TradeReceivablesChkBx = new System.Windows.Forms.CheckBox();
            this.ReferenceItemGrpBx = new System.Windows.Forms.GroupBox();
            this.SalesChkBx = new System.Windows.Forms.CheckBox();
            this.EquityChkBx = new System.Windows.Forms.CheckBox();
            this.ClearAnalyzeGrpBxBtn = new System.Windows.Forms.Button();
            this.AnalyzeBtn = new System.Windows.Forms.Button();
            this.SelectedStockGrpBx = new System.Windows.Forms.GroupBox();
            this.SelectedStockDgv = new System.Windows.Forms.DataGridView();
            this.SelectedStocks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClearSelectedStockBtn = new System.Windows.Forms.Button();
            this.StockGrpBx = new System.Windows.Forms.GroupBox();
            this.SelectAllChkBx = new System.Windows.Forms.CheckBox();
            this.StockDgv = new System.Windows.Forms.DataGridView();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.analyze = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ClearStockBtn = new System.Windows.Forms.Button();
            this.StockLoadBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ClearAllBtn = new System.Windows.Forms.Button();
            this.MainScreenBtn = new System.Windows.Forms.Button();
            this.QuitBtn = new System.Windows.Forms.Button();
            this.ExportTxtBtn = new System.Windows.Forms.Button();
            this.ReportGrpBx.SuspendLayout();
            this.AnalyzeGrpBx.SuspendLayout();
            this.TimePeriodPnl.SuspendLayout();
            this.ReportTypePnl.SuspendLayout();
            this.FinancialItemGrpBx.SuspendLayout();
            this.ReferenceItemGrpBx.SuspendLayout();
            this.SelectedStockGrpBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedStockDgv)).BeginInit();
            this.StockGrpBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportGrpBx
            // 
            this.ReportGrpBx.Controls.Add(this.ClearReportBtn);
            this.ReportGrpBx.Controls.Add(this.ReportRtb);
            this.ReportGrpBx.Location = new System.Drawing.Point(789, 21);
            this.ReportGrpBx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ReportGrpBx.Name = "ReportGrpBx";
            this.ReportGrpBx.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ReportGrpBx.Size = new System.Drawing.Size(630, 808);
            this.ReportGrpBx.TabIndex = 24;
            this.ReportGrpBx.TabStop = false;
            this.ReportGrpBx.Text = "Sonuç";
            // 
            // ClearReportBtn
            // 
            this.ClearReportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClearReportBtn.Location = new System.Drawing.Point(271, 748);
            this.ClearReportBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearReportBtn.Name = "ClearReportBtn";
            this.ClearReportBtn.Size = new System.Drawing.Size(87, 52);
            this.ClearReportBtn.TabIndex = 34;
            this.ClearReportBtn.Text = "Temizle";
            this.ClearReportBtn.UseVisualStyleBackColor = false;
            this.ClearReportBtn.Click += new System.EventHandler(this.ClearReportBtn_Click);
            // 
            // ReportRtb
            // 
            this.ReportRtb.Location = new System.Drawing.Point(7, 32);
            this.ReportRtb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ReportRtb.Name = "ReportRtb";
            this.ReportRtb.ReadOnly = true;
            this.ReportRtb.Size = new System.Drawing.Size(615, 705);
            this.ReportRtb.TabIndex = 4;
            this.ReportRtb.Text = "";
            this.ReportRtb.Visible = false;
            // 
            // ReportTypesCmbBx
            // 
            this.ReportTypesCmbBx.FormattingEnabled = true;
            this.ReportTypesCmbBx.Location = new System.Drawing.Point(21, 4);
            this.ReportTypesCmbBx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ReportTypesCmbBx.Name = "ReportTypesCmbBx";
            this.ReportTypesCmbBx.Size = new System.Drawing.Size(178, 28);
            this.ReportTypesCmbBx.TabIndex = 1;
            this.ReportTypesCmbBx.Text = "Rapor tipi seçiniz...";
            this.ReportTypesCmbBx.SelectedIndexChanged += new System.EventHandler(this.ReportTypesCmbBx_SelectedIndexChanged);
            // 
            // AnalyzeGrpBx
            // 
            this.AnalyzeGrpBx.Controls.Add(this.TimePeriodPnl);
            this.AnalyzeGrpBx.Controls.Add(this.ReportTypePnl);
            this.AnalyzeGrpBx.Controls.Add(this.FinancialItemGrpBx);
            this.AnalyzeGrpBx.Controls.Add(this.ReferenceItemGrpBx);
            this.AnalyzeGrpBx.Controls.Add(this.ClearAnalyzeGrpBxBtn);
            this.AnalyzeGrpBx.Controls.Add(this.AnalyzeBtn);
            this.AnalyzeGrpBx.Location = new System.Drawing.Point(553, 21);
            this.AnalyzeGrpBx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AnalyzeGrpBx.Name = "AnalyzeGrpBx";
            this.AnalyzeGrpBx.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AnalyzeGrpBx.Size = new System.Drawing.Size(229, 808);
            this.AnalyzeGrpBx.TabIndex = 23;
            this.AnalyzeGrpBx.TabStop = false;
            this.AnalyzeGrpBx.Text = "Analiz";
            // 
            // TimePeriodPnl
            // 
            this.TimePeriodPnl.Controls.Add(this.SecondYearTxtBx);
            this.TimePeriodPnl.Controls.Add(this.FirstYearTxtBx);
            this.TimePeriodPnl.Controls.Add(this.FirstTimeTxt);
            this.TimePeriodPnl.Controls.Add(this.SecondQuarterCmbBx);
            this.TimePeriodPnl.Controls.Add(this.FirstQuarterCmbBx);
            this.TimePeriodPnl.Controls.Add(this.SecondTimeTxt);
            this.TimePeriodPnl.Location = new System.Drawing.Point(7, 491);
            this.TimePeriodPnl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TimePeriodPnl.Name = "TimePeriodPnl";
            this.TimePeriodPnl.Size = new System.Drawing.Size(215, 176);
            this.TimePeriodPnl.TabIndex = 33;
            // 
            // SecondYearTxtBx
            // 
            this.SecondYearTxtBx.Location = new System.Drawing.Point(3, 136);
            this.SecondYearTxtBx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SecondYearTxtBx.Name = "SecondYearTxtBx";
            this.SecondYearTxtBx.Size = new System.Drawing.Size(102, 27);
            this.SecondYearTxtBx.TabIndex = 33;
            // 
            // FirstYearTxtBx
            // 
            this.FirstYearTxtBx.Location = new System.Drawing.Point(3, 44);
            this.FirstYearTxtBx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FirstYearTxtBx.Name = "FirstYearTxtBx";
            this.FirstYearTxtBx.Size = new System.Drawing.Size(102, 27);
            this.FirstYearTxtBx.TabIndex = 32;
            // 
            // FirstTimeTxt
            // 
            this.FirstTimeTxt.Location = new System.Drawing.Point(3, 4);
            this.FirstTimeTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FirstTimeTxt.Name = "FirstTimeTxt";
            this.FirstTimeTxt.ReadOnly = true;
            this.FirstTimeTxt.Size = new System.Drawing.Size(209, 27);
            this.FirstTimeTxt.TabIndex = 27;
            this.FirstTimeTxt.Text = "1. Zaman";
            this.FirstTimeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SecondQuarterCmbBx
            // 
            this.SecondQuarterCmbBx.FormattingEnabled = true;
            this.SecondQuarterCmbBx.Location = new System.Drawing.Point(113, 136);
            this.SecondQuarterCmbBx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SecondQuarterCmbBx.Name = "SecondQuarterCmbBx";
            this.SecondQuarterCmbBx.Size = new System.Drawing.Size(99, 28);
            this.SecondQuarterCmbBx.TabIndex = 31;
            this.SecondQuarterCmbBx.Text = "Çeyrek";
            this.SecondQuarterCmbBx.SelectedIndexChanged += new System.EventHandler(this.SecondQuarterCmbBx_SelectedIndexChanged);
            // 
            // FirstQuarterCmbBx
            // 
            this.FirstQuarterCmbBx.FormattingEnabled = true;
            this.FirstQuarterCmbBx.Location = new System.Drawing.Point(113, 43);
            this.FirstQuarterCmbBx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FirstQuarterCmbBx.Name = "FirstQuarterCmbBx";
            this.FirstQuarterCmbBx.Size = new System.Drawing.Size(99, 28);
            this.FirstQuarterCmbBx.TabIndex = 28;
            this.FirstQuarterCmbBx.Text = "Çeyrek";
            this.FirstQuarterCmbBx.SelectedIndexChanged += new System.EventHandler(this.FirstQuarterCmbBx_SelectedIndexChanged);
            // 
            // SecondTimeTxt
            // 
            this.SecondTimeTxt.Location = new System.Drawing.Point(3, 97);
            this.SecondTimeTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SecondTimeTxt.Name = "SecondTimeTxt";
            this.SecondTimeTxt.ReadOnly = true;
            this.SecondTimeTxt.Size = new System.Drawing.Size(209, 27);
            this.SecondTimeTxt.TabIndex = 30;
            this.SecondTimeTxt.Text = "2. Zaman";
            this.SecondTimeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ReportTypePnl
            // 
            this.ReportTypePnl.Controls.Add(this.ReportTypesCmbBx);
            this.ReportTypePnl.Location = new System.Drawing.Point(7, 675);
            this.ReportTypePnl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ReportTypePnl.Name = "ReportTypePnl";
            this.ReportTypePnl.Size = new System.Drawing.Size(213, 65);
            this.ReportTypePnl.TabIndex = 32;
            // 
            // FinancialItemGrpBx
            // 
            this.FinancialItemGrpBx.Controls.Add(this.PrepaidExpensesChkBx);
            this.FinancialItemGrpBx.Controls.Add(this.IntangibleFixedAssetsChkBx);
            this.FinancialItemGrpBx.Controls.Add(this.AccumProfitLossChkBx);
            this.FinancialItemGrpBx.Controls.Add(this.FinancialDebtsChkBx);
            this.FinancialItemGrpBx.Controls.Add(this.TradeDebtsChkBx);
            this.FinancialItemGrpBx.Controls.Add(this.LongTermLiabilitiesChkBx);
            this.FinancialItemGrpBx.Controls.Add(this.ShortTermLiabilitiesChkBx);
            this.FinancialItemGrpBx.Controls.Add(this.FixedAssetsChkBx);
            this.FinancialItemGrpBx.Controls.Add(this.CurrentAssestsChkBx);
            this.FinancialItemGrpBx.Controls.Add(this.StocksChkBx);
            this.FinancialItemGrpBx.Controls.Add(this.TradeReceivablesChkBx);
            this.FinancialItemGrpBx.Location = new System.Drawing.Point(7, 128);
            this.FinancialItemGrpBx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FinancialItemGrpBx.Name = "FinancialItemGrpBx";
            this.FinancialItemGrpBx.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FinancialItemGrpBx.Size = new System.Drawing.Size(215, 359);
            this.FinancialItemGrpBx.TabIndex = 18;
            this.FinancialItemGrpBx.TabStop = false;
            this.FinancialItemGrpBx.Text = "Kalemler";
            // 
            // PrepaidExpensesChkBx
            // 
            this.PrepaidExpensesChkBx.AutoSize = true;
            this.PrepaidExpensesChkBx.Location = new System.Drawing.Point(6, 327);
            this.PrepaidExpensesChkBx.Name = "PrepaidExpensesChkBx";
            this.PrepaidExpensesChkBx.Size = new System.Drawing.Size(184, 24);
            this.PrepaidExpensesChkBx.TabIndex = 23;
            this.PrepaidExpensesChkBx.Text = "Peşin Ödenmiş Giderler";
            this.PrepaidExpensesChkBx.UseVisualStyleBackColor = true;
            this.PrepaidExpensesChkBx.CheckedChanged += new System.EventHandler(this.PrepaidExpensesChkBx_CheckedChanged);
            // 
            // IntangibleFixedAssetsChkBx
            // 
            this.IntangibleFixedAssetsChkBx.AutoSize = true;
            this.IntangibleFixedAssetsChkBx.Location = new System.Drawing.Point(6, 297);
            this.IntangibleFixedAssetsChkBx.Name = "IntangibleFixedAssetsChkBx";
            this.IntangibleFixedAssetsChkBx.Size = new System.Drawing.Size(197, 24);
            this.IntangibleFixedAssetsChkBx.TabIndex = 22;
            this.IntangibleFixedAssetsChkBx.Text = "Maddi Olm. Dur. Varlıklar";
            this.IntangibleFixedAssetsChkBx.UseVisualStyleBackColor = true;
            this.IntangibleFixedAssetsChkBx.CheckedChanged += new System.EventHandler(this.IntangibleFixedAssetsChkBx_CheckedChanged);
            // 
            // AccumProfitLossChkBx
            // 
            this.AccumProfitLossChkBx.AutoSize = true;
            this.AccumProfitLossChkBx.Location = new System.Drawing.Point(6, 267);
            this.AccumProfitLossChkBx.Name = "AccumProfitLossChkBx";
            this.AccumProfitLossChkBx.Size = new System.Drawing.Size(204, 24);
            this.AccumProfitLossChkBx.TabIndex = 21;
            this.AccumProfitLossChkBx.Text = "Geçmiş Yıllar Kar/Zararları";
            this.AccumProfitLossChkBx.UseVisualStyleBackColor = true;
            this.AccumProfitLossChkBx.CheckedChanged += new System.EventHandler(this.AccumProfitLossChkBx_CheckedChanged);
            // 
            // FinancialDebtsChkBx
            // 
            this.FinancialDebtsChkBx.AutoSize = true;
            this.FinancialDebtsChkBx.Location = new System.Drawing.Point(6, 237);
            this.FinancialDebtsChkBx.Name = "FinancialDebtsChkBx";
            this.FinancialDebtsChkBx.Size = new System.Drawing.Size(135, 24);
            this.FinancialDebtsChkBx.TabIndex = 20;
            this.FinancialDebtsChkBx.Text = "Finansal Borçlar";
            this.FinancialDebtsChkBx.UseVisualStyleBackColor = true;
            this.FinancialDebtsChkBx.CheckedChanged += new System.EventHandler(this.FinancialDebtsChkBx_CheckedChanged);
            // 
            // TradeDebtsChkBx
            // 
            this.TradeDebtsChkBx.AutoSize = true;
            this.TradeDebtsChkBx.Location = new System.Drawing.Point(6, 207);
            this.TradeDebtsChkBx.Name = "TradeDebtsChkBx";
            this.TradeDebtsChkBx.Size = new System.Drawing.Size(118, 24);
            this.TradeDebtsChkBx.TabIndex = 19;
            this.TradeDebtsChkBx.Text = "Ticari Borçlar";
            this.TradeDebtsChkBx.UseVisualStyleBackColor = true;
            this.TradeDebtsChkBx.CheckedChanged += new System.EventHandler(this.TradeDebtsChkBx_CheckedChanged);
            // 
            // LongTermLiabilitiesChkBx
            // 
            this.LongTermLiabilitiesChkBx.AutoSize = true;
            this.LongTermLiabilitiesChkBx.Location = new System.Drawing.Point(6, 177);
            this.LongTermLiabilitiesChkBx.Name = "LongTermLiabilitiesChkBx";
            this.LongTermLiabilitiesChkBx.Size = new System.Drawing.Size(126, 24);
            this.LongTermLiabilitiesChkBx.TabIndex = 18;
            this.LongTermLiabilitiesChkBx.Text = "Uzun Vad. Yük.";
            this.LongTermLiabilitiesChkBx.UseVisualStyleBackColor = true;
            this.LongTermLiabilitiesChkBx.CheckedChanged += new System.EventHandler(this.LongTermLiabilitiesChkBx_CheckedChanged);
            // 
            // ShortTermLiabilitiesChkBx
            // 
            this.ShortTermLiabilitiesChkBx.AutoSize = true;
            this.ShortTermLiabilitiesChkBx.Location = new System.Drawing.Point(6, 147);
            this.ShortTermLiabilitiesChkBx.Name = "ShortTermLiabilitiesChkBx";
            this.ShortTermLiabilitiesChkBx.Size = new System.Drawing.Size(120, 24);
            this.ShortTermLiabilitiesChkBx.TabIndex = 17;
            this.ShortTermLiabilitiesChkBx.Text = "Kısa Vad. Yük.";
            this.ShortTermLiabilitiesChkBx.UseVisualStyleBackColor = true;
            this.ShortTermLiabilitiesChkBx.CheckedChanged += new System.EventHandler(this.ShortTermLiabilitiesChkBx_CheckedChanged);
            // 
            // FixedAssetsChkBx
            // 
            this.FixedAssetsChkBx.AutoSize = true;
            this.FixedAssetsChkBx.Location = new System.Drawing.Point(6, 117);
            this.FixedAssetsChkBx.Name = "FixedAssetsChkBx";
            this.FixedAssetsChkBx.Size = new System.Drawing.Size(128, 24);
            this.FixedAssetsChkBx.TabIndex = 16;
            this.FixedAssetsChkBx.Text = "Duran Varlıklar";
            this.FixedAssetsChkBx.UseVisualStyleBackColor = true;
            this.FixedAssetsChkBx.CheckedChanged += new System.EventHandler(this.FixedAssetsChkBx_CheckedChanged);
            // 
            // CurrentAssestsChkBx
            // 
            this.CurrentAssestsChkBx.AutoSize = true;
            this.CurrentAssestsChkBx.Location = new System.Drawing.Point(6, 87);
            this.CurrentAssestsChkBx.Name = "CurrentAssestsChkBx";
            this.CurrentAssestsChkBx.Size = new System.Drawing.Size(132, 24);
            this.CurrentAssestsChkBx.TabIndex = 15;
            this.CurrentAssestsChkBx.Text = "Dönen Varlıklar";
            this.CurrentAssestsChkBx.UseVisualStyleBackColor = true;
            this.CurrentAssestsChkBx.CheckedChanged += new System.EventHandler(this.CurrentAssestsChkBx_CheckedChanged);
            // 
            // StocksChkBx
            // 
            this.StocksChkBx.AutoSize = true;
            this.StocksChkBx.Location = new System.Drawing.Point(6, 57);
            this.StocksChkBx.Name = "StocksChkBx";
            this.StocksChkBx.Size = new System.Drawing.Size(77, 24);
            this.StocksChkBx.TabIndex = 14;
            this.StocksChkBx.Text = "Stoklar";
            this.StocksChkBx.UseVisualStyleBackColor = true;
            this.StocksChkBx.CheckedChanged += new System.EventHandler(this.StocksChkBx_CheckedChanged);
            // 
            // TradeReceivablesChkBx
            // 
            this.TradeReceivablesChkBx.AutoSize = true;
            this.TradeReceivablesChkBx.Location = new System.Drawing.Point(6, 27);
            this.TradeReceivablesChkBx.Name = "TradeReceivablesChkBx";
            this.TradeReceivablesChkBx.Size = new System.Drawing.Size(132, 24);
            this.TradeReceivablesChkBx.TabIndex = 13;
            this.TradeReceivablesChkBx.Text = "Ticari Alacaklar";
            this.TradeReceivablesChkBx.UseVisualStyleBackColor = true;
            this.TradeReceivablesChkBx.CheckedChanged += new System.EventHandler(this.TradeReceivablesChkBx_CheckedChanged);
            // 
            // ReferenceItemGrpBx
            // 
            this.ReferenceItemGrpBx.Controls.Add(this.SalesChkBx);
            this.ReferenceItemGrpBx.Controls.Add(this.EquityChkBx);
            this.ReferenceItemGrpBx.Location = new System.Drawing.Point(7, 29);
            this.ReferenceItemGrpBx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ReferenceItemGrpBx.Name = "ReferenceItemGrpBx";
            this.ReferenceItemGrpBx.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ReferenceItemGrpBx.Size = new System.Drawing.Size(213, 91);
            this.ReferenceItemGrpBx.TabIndex = 17;
            this.ReferenceItemGrpBx.TabStop = false;
            this.ReferenceItemGrpBx.Text = "Referanslar";
            // 
            // SalesChkBx
            // 
            this.SalesChkBx.AutoSize = true;
            this.SalesChkBx.Location = new System.Drawing.Point(6, 57);
            this.SalesChkBx.Name = "SalesChkBx";
            this.SalesChkBx.Size = new System.Drawing.Size(118, 24);
            this.SalesChkBx.TabIndex = 11;
            this.SalesChkBx.Text = "Satış Gelirleri";
            this.SalesChkBx.UseVisualStyleBackColor = true;
            this.SalesChkBx.CheckedChanged += new System.EventHandler(this.SalesChkBx_CheckedChanged);
            // 
            // EquityChkBx
            // 
            this.EquityChkBx.AutoSize = true;
            this.EquityChkBx.Location = new System.Drawing.Point(6, 28);
            this.EquityChkBx.Name = "EquityChkBx";
            this.EquityChkBx.Size = new System.Drawing.Size(111, 24);
            this.EquityChkBx.TabIndex = 10;
            this.EquityChkBx.Text = "Özkaynaklar";
            this.EquityChkBx.UseVisualStyleBackColor = true;
            this.EquityChkBx.CheckedChanged += new System.EventHandler(this.EquityChkBx_CheckedChanged);
            // 
            // ClearAnalyzeGrpBxBtn
            // 
            this.ClearAnalyzeGrpBxBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClearAnalyzeGrpBxBtn.Location = new System.Drawing.Point(120, 748);
            this.ClearAnalyzeGrpBxBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearAnalyzeGrpBxBtn.Name = "ClearAnalyzeGrpBxBtn";
            this.ClearAnalyzeGrpBxBtn.Size = new System.Drawing.Size(87, 52);
            this.ClearAnalyzeGrpBxBtn.TabIndex = 7;
            this.ClearAnalyzeGrpBxBtn.Text = "Temizle";
            this.ClearAnalyzeGrpBxBtn.UseVisualStyleBackColor = false;
            this.ClearAnalyzeGrpBxBtn.Click += new System.EventHandler(this.ClearAnalyzeGrpBxBtn_Click);
            // 
            // AnalyzeBtn
            // 
            this.AnalyzeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AnalyzeBtn.Location = new System.Drawing.Point(27, 748);
            this.AnalyzeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AnalyzeBtn.Name = "AnalyzeBtn";
            this.AnalyzeBtn.Size = new System.Drawing.Size(87, 52);
            this.AnalyzeBtn.TabIndex = 6;
            this.AnalyzeBtn.Text = "Analiz";
            this.AnalyzeBtn.UseVisualStyleBackColor = false;
            this.AnalyzeBtn.Click += new System.EventHandler(this.AnalyzeBtn_Click);
            // 
            // SelectedStockGrpBx
            // 
            this.SelectedStockGrpBx.Controls.Add(this.SelectedStockDgv);
            this.SelectedStockGrpBx.Controls.Add(this.ClearSelectedStockBtn);
            this.SelectedStockGrpBx.Location = new System.Drawing.Point(329, 21);
            this.SelectedStockGrpBx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelectedStockGrpBx.Name = "SelectedStockGrpBx";
            this.SelectedStockGrpBx.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelectedStockGrpBx.Size = new System.Drawing.Size(217, 808);
            this.SelectedStockGrpBx.TabIndex = 22;
            this.SelectedStockGrpBx.TabStop = false;
            this.SelectedStockGrpBx.Text = "Seçili Hisseler";
            // 
            // SelectedStockDgv
            // 
            this.SelectedStockDgv.AllowUserToAddRows = false;
            this.SelectedStockDgv.AllowUserToDeleteRows = false;
            this.SelectedStockDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectedStockDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectedStocks});
            this.SelectedStockDgv.Location = new System.Drawing.Point(6, 32);
            this.SelectedStockDgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelectedStockDgv.Name = "SelectedStockDgv";
            this.SelectedStockDgv.RowHeadersWidth = 51;
            this.SelectedStockDgv.RowTemplate.Height = 25;
            this.SelectedStockDgv.Size = new System.Drawing.Size(205, 708);
            this.SelectedStockDgv.TabIndex = 3;
            // 
            // SelectedStocks
            // 
            this.SelectedStocks.HeaderText = "Seçilenler";
            this.SelectedStocks.MinimumWidth = 6;
            this.SelectedStocks.Name = "SelectedStocks";
            this.SelectedStocks.Width = 120;
            // 
            // ClearSelectedStockBtn
            // 
            this.ClearSelectedStockBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClearSelectedStockBtn.Location = new System.Drawing.Point(53, 748);
            this.ClearSelectedStockBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearSelectedStockBtn.Name = "ClearSelectedStockBtn";
            this.ClearSelectedStockBtn.Size = new System.Drawing.Size(113, 52);
            this.ClearSelectedStockBtn.TabIndex = 8;
            this.ClearSelectedStockBtn.Text = "Temizle";
            this.ClearSelectedStockBtn.UseVisualStyleBackColor = false;
            this.ClearSelectedStockBtn.Click += new System.EventHandler(this.ClearSelectedStockBtn_Click);
            // 
            // StockGrpBx
            // 
            this.StockGrpBx.Controls.Add(this.SelectAllChkBx);
            this.StockGrpBx.Controls.Add(this.StockDgv);
            this.StockGrpBx.Controls.Add(this.ClearStockBtn);
            this.StockGrpBx.Controls.Add(this.StockLoadBtn);
            this.StockGrpBx.Location = new System.Drawing.Point(37, 21);
            this.StockGrpBx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StockGrpBx.Name = "StockGrpBx";
            this.StockGrpBx.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StockGrpBx.Size = new System.Drawing.Size(269, 808);
            this.StockGrpBx.TabIndex = 21;
            this.StockGrpBx.TabStop = false;
            this.StockGrpBx.Text = "Hisseler";
            // 
            // SelectAllChkBx
            // 
            this.SelectAllChkBx.AutoSize = true;
            this.SelectAllChkBx.Location = new System.Drawing.Point(193, 761);
            this.SelectAllChkBx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelectAllChkBx.Name = "SelectAllChkBx";
            this.SelectAllChkBx.Size = new System.Drawing.Size(69, 24);
            this.SelectAllChkBx.TabIndex = 6;
            this.SelectAllChkBx.Text = "Hepsi";
            this.SelectAllChkBx.UseVisualStyleBackColor = true;
            this.SelectAllChkBx.CheckedChanged += new System.EventHandler(this.SelectAllStocksChkBx_CheckedChanged);
            // 
            // StockDgv
            // 
            this.StockDgv.AllowUserToDeleteRows = false;
            this.StockDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stock,
            this.analyze});
            this.StockDgv.Location = new System.Drawing.Point(7, 27);
            this.StockDgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StockDgv.Name = "StockDgv";
            this.StockDgv.RowHeadersWidth = 51;
            this.StockDgv.RowTemplate.Height = 25;
            this.StockDgv.Size = new System.Drawing.Size(255, 708);
            this.StockDgv.TabIndex = 1;
            this.StockDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StockDgv_CellContentClick);
            // 
            // stock
            // 
            this.stock.Frozen = true;
            this.stock.HeaderText = "Sembol ";
            this.stock.MinimumWidth = 6;
            this.stock.Name = "stock";
            this.stock.Width = 120;
            // 
            // analyze
            // 
            this.analyze.Frozen = true;
            this.analyze.HeaderText = "İncele";
            this.analyze.MinimumWidth = 6;
            this.analyze.Name = "analyze";
            this.analyze.Width = 50;
            // 
            // ClearStockBtn
            // 
            this.ClearStockBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClearStockBtn.Location = new System.Drawing.Point(101, 747);
            this.ClearStockBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearStockBtn.Name = "ClearStockBtn";
            this.ClearStockBtn.Size = new System.Drawing.Size(69, 52);
            this.ClearStockBtn.TabIndex = 5;
            this.ClearStockBtn.Text = "Temizle";
            this.ClearStockBtn.UseVisualStyleBackColor = false;
            this.ClearStockBtn.Click += new System.EventHandler(this.ClearStockBtn_Click);
            // 
            // StockLoadBtn
            // 
            this.StockLoadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.StockLoadBtn.Location = new System.Drawing.Point(7, 747);
            this.StockLoadBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StockLoadBtn.Name = "StockLoadBtn";
            this.StockLoadBtn.Size = new System.Drawing.Size(69, 52);
            this.StockLoadBtn.TabIndex = 0;
            this.StockLoadBtn.Text = "Yükle";
            this.StockLoadBtn.UseVisualStyleBackColor = false;
            this.StockLoadBtn.Click += new System.EventHandler(this.StockLoadBtn_Click);
            // 
            // ClearAllBtn
            // 
            this.ClearAllBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClearAllBtn.Location = new System.Drawing.Point(1425, 642);
            this.ClearAllBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearAllBtn.Name = "ClearAllBtn";
            this.ClearAllBtn.Size = new System.Drawing.Size(88, 55);
            this.ClearAllBtn.TabIndex = 19;
            this.ClearAllBtn.Text = "Her şeyi Temizle";
            this.ClearAllBtn.UseVisualStyleBackColor = false;
            this.ClearAllBtn.Click += new System.EventHandler(this.ClearAllBtn_Click);
            // 
            // MainScreenBtn
            // 
            this.MainScreenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MainScreenBtn.Location = new System.Drawing.Point(1425, 708);
            this.MainScreenBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MainScreenBtn.Name = "MainScreenBtn";
            this.MainScreenBtn.Size = new System.Drawing.Size(88, 55);
            this.MainScreenBtn.TabIndex = 25;
            this.MainScreenBtn.Text = "Ana Sayfa";
            this.MainScreenBtn.UseVisualStyleBackColor = false;
            this.MainScreenBtn.Click += new System.EventHandler(this.MainScreenBtn_Click);
            // 
            // QuitBtn
            // 
            this.QuitBtn.BackColor = System.Drawing.Color.Red;
            this.QuitBtn.Location = new System.Drawing.Point(1425, 774);
            this.QuitBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(88, 55);
            this.QuitBtn.TabIndex = 26;
            this.QuitBtn.Text = "Çıkış";
            this.QuitBtn.UseVisualStyleBackColor = false;
            this.QuitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // ExportTxtBtn
            // 
            this.ExportTxtBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ExportTxtBtn.Location = new System.Drawing.Point(1425, 576);
            this.ExportTxtBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ExportTxtBtn.Name = "ExportTxtBtn";
            this.ExportTxtBtn.Size = new System.Drawing.Size(88, 55);
            this.ExportTxtBtn.TabIndex = 27;
            this.ExportTxtBtn.Text = "TXT";
            this.ExportTxtBtn.UseVisualStyleBackColor = false;
            this.ExportTxtBtn.Click += new System.EventHandler(this.ExportTxtBtn_Click);
            // 
            // BalanceScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::DesktopUI.Properties.Resources._14803736_Vector_2652;
            this.ClientSize = new System.Drawing.Size(1527, 853);
            this.Controls.Add(this.ExportTxtBtn);
            this.Controls.Add(this.QuitBtn);
            this.Controls.Add(this.MainScreenBtn);
            this.Controls.Add(this.ReportGrpBx);
            this.Controls.Add(this.AnalyzeGrpBx);
            this.Controls.Add(this.SelectedStockGrpBx);
            this.Controls.Add(this.StockGrpBx);
            this.Controls.Add(this.ClearAllBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BalanceScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilanço";
            this.ReportGrpBx.ResumeLayout(false);
            this.AnalyzeGrpBx.ResumeLayout(false);
            this.TimePeriodPnl.ResumeLayout(false);
            this.TimePeriodPnl.PerformLayout();
            this.ReportTypePnl.ResumeLayout(false);
            this.FinancialItemGrpBx.ResumeLayout(false);
            this.FinancialItemGrpBx.PerformLayout();
            this.ReferenceItemGrpBx.ResumeLayout(false);
            this.ReferenceItemGrpBx.PerformLayout();
            this.SelectedStockGrpBx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SelectedStockDgv)).EndInit();
            this.StockGrpBx.ResumeLayout(false);
            this.StockGrpBx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox ReportGrpBx;
        private System.Windows.Forms.RichTextBox ReportRtb;
        private System.Windows.Forms.ComboBox ReportTypesCmbBx;
        private System.Windows.Forms.GroupBox AnalyzeGrpBx;
        private System.Windows.Forms.GroupBox SelectedStockGrpBx;
        private System.Windows.Forms.DataGridView SelectedStockDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectedStocks;
        private System.Windows.Forms.Button ClearSelectedStockBtn;
        private System.Windows.Forms.GroupBox StockGrpBx;
        private System.Windows.Forms.DataGridView StockDgv;
        private System.Windows.Forms.Button ClearStockBtn;
        private System.Windows.Forms.Button StockLoadBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button ClearAllBtn;
        private System.Windows.Forms.Button MainScreenBtn;
        private System.Windows.Forms.Button QuitBtn;
        private System.Windows.Forms.Button ClearAnalyzeGrpBxBtn;
        private System.Windows.Forms.Button AnalyzeBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewCheckBoxColumn analyze;
        private System.Windows.Forms.CheckBox EquityChkBx;
        private System.Windows.Forms.CheckBox SalesChkBx;
        private System.Windows.Forms.GroupBox FinancialItemGrpBx;
        private System.Windows.Forms.GroupBox ReferenceItemGrpBx;
        private System.Windows.Forms.ComboBox SecondQuarterCmbBx;
        private System.Windows.Forms.TextBox SecondTimeTxt;
        private System.Windows.Forms.ComboBox FirstQuarterCmbBx;
        private System.Windows.Forms.TextBox FirstTimeTxt;
        private System.Windows.Forms.Panel ReportTypePnl;
        private System.Windows.Forms.Button ExportTxtBtn;
        private System.Windows.Forms.Panel TimePeriodPnl;
        private System.Windows.Forms.TextBox SecondYearTxtBx;
        private System.Windows.Forms.TextBox FirstYearTxtBx;
        private System.Windows.Forms.CheckBox SelectAllChkBx;
        private System.Windows.Forms.CheckBox TradeReceivablesChkBx;
        private System.Windows.Forms.Button ClearReportBtn;
        private System.Windows.Forms.CheckBox PrepaidExpensesChkBx;
        private System.Windows.Forms.CheckBox IntangibleFixedAssetsChkBx;
        private System.Windows.Forms.CheckBox AccumProfitLossChkBx;
        private System.Windows.Forms.CheckBox FinancialDebtsChkBx;
        private System.Windows.Forms.CheckBox TradeDebtsChkBx;
        private System.Windows.Forms.CheckBox LongTermLiabilitiesChkBx;
        private System.Windows.Forms.CheckBox ShortTermLiabilitiesChkBx;
        private System.Windows.Forms.CheckBox FixedAssetsChkBx;
        private System.Windows.Forms.CheckBox CurrentAssestsChkBx;
        private System.Windows.Forms.CheckBox StocksChkBx;
    }
}