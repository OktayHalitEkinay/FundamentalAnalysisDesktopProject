
namespace DesktopUI
{
    partial class MainScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.BalanceBtn = new System.Windows.Forms.Button();
            this.CashFlowTableBtn = new System.Windows.Forms.Button();
            this.IncomeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BalanceBtn
            // 
            this.BalanceBtn.BackColor = System.Drawing.Color.White;
            this.BalanceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BalanceBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BalanceBtn.Location = new System.Drawing.Point(77, 71);
            this.BalanceBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BalanceBtn.Name = "BalanceBtn";
            this.BalanceBtn.Size = new System.Drawing.Size(241, 42);
            this.BalanceBtn.TabIndex = 0;
            this.BalanceBtn.Text = "Bilanço";
            this.BalanceBtn.UseVisualStyleBackColor = false;
            this.BalanceBtn.Click += new System.EventHandler(this.BalanceBtn_Click);
            // 
            // CashFlowTableBtn
            // 
            this.CashFlowTableBtn.BackColor = System.Drawing.Color.White;
            this.CashFlowTableBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CashFlowTableBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CashFlowTableBtn.Location = new System.Drawing.Point(77, 206);
            this.CashFlowTableBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CashFlowTableBtn.Name = "CashFlowTableBtn";
            this.CashFlowTableBtn.Size = new System.Drawing.Size(241, 42);
            this.CashFlowTableBtn.TabIndex = 1;
            this.CashFlowTableBtn.Text = "Nakit Akım Tablosu";
            this.CashFlowTableBtn.UseVisualStyleBackColor = false;
            this.CashFlowTableBtn.Click += new System.EventHandler(this.CashFlowTableBtn_Click);
            // 
            // IncomeBtn
            // 
            this.IncomeBtn.BackColor = System.Drawing.Color.White;
            this.IncomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IncomeBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IncomeBtn.Location = new System.Drawing.Point(77, 139);
            this.IncomeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IncomeBtn.Name = "IncomeBtn";
            this.IncomeBtn.Size = new System.Drawing.Size(241, 42);
            this.IncomeBtn.TabIndex = 2;
            this.IncomeBtn.Text = "Gelir Tablosu";
            this.IncomeBtn.UseVisualStyleBackColor = false;
            this.IncomeBtn.Click += new System.EventHandler(this.IncomeBtn_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::DesktopUI.Properties.Resources._14803736_Vector_2652;
            this.ClientSize = new System.Drawing.Size(1241, 637);
            this.Controls.Add(this.IncomeBtn);
            this.Controls.Add(this.CashFlowTableBtn);
            this.Controls.Add(this.BalanceBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Ekran";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BalanceBtn;
        private System.Windows.Forms.Button CashFlowTableBtn;
        private System.Windows.Forms.Button IncomeBtn;
    }
}

