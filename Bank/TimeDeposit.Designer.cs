﻿namespace Bank
{
    partial class TimeDeposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeDeposit));
            this.planChoose = new System.Windows.Forms.ListBox();
            this.buyNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buyBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cardBalance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // planChoose
            // 
            this.planChoose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.planChoose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.planChoose.FormattingEnabled = true;
            this.planChoose.ItemHeight = 24;
            this.planChoose.Items.AddRange(new object[] {
            "3个月/年利率1.4%",
            "6个月/年利率1.65%",
            "1年/年利率1.95%",
            "2年/年利率2.4%",
            "3年/年利率3%",
            "5年/年利率3%"});
            this.planChoose.Location = new System.Drawing.Point(204, 396);
            this.planChoose.Margin = new System.Windows.Forms.Padding(4);
            this.planChoose.Name = "planChoose";
            this.planChoose.Size = new System.Drawing.Size(218, 148);
            this.planChoose.TabIndex = 0;
            // 
            // buyNum
            // 
            this.buyNum.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buyNum.Location = new System.Drawing.Point(706, 392);
            this.buyNum.Margin = new System.Windows.Forms.Padding(4);
            this.buyNum.Name = "buyNum";
            this.buyNum.Size = new System.Drawing.Size(148, 35);
            this.buyNum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.label1.Location = new System.Drawing.Point(539, 392);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "购买金额";
            // 
            // buyBtn
            // 
            this.buyBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buyBtn.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.buyBtn.Location = new System.Drawing.Point(558, 470);
            this.buyBtn.Margin = new System.Windows.Forms.Padding(4);
            this.buyBtn.Name = "buyBtn";
            this.buyBtn.Size = new System.Drawing.Size(276, 61);
            this.buyBtn.TabIndex = 2;
            this.buyBtn.Text = "确认购买";
            this.buyBtn.UseVisualStyleBackColor = true;
            this.buyBtn.Click += new System.EventHandler(this.buyBtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.label2.Location = new System.Drawing.Point(525, 316);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "储蓄卡余额";
            // 
            // cardBalance
            // 
            this.cardBalance.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cardBalance.Cursor = System.Windows.Forms.Cursors.No;
            this.cardBalance.Location = new System.Drawing.Point(706, 316);
            this.cardBalance.Margin = new System.Windows.Forms.Padding(4);
            this.cardBalance.Name = "cardBalance";
            this.cardBalance.ReadOnly = true;
            this.cardBalance.Size = new System.Drawing.Size(148, 35);
            this.cardBalance.TabIndex = 11;
            this.cardBalance.TabStop = false;
            this.cardBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.label3.Location = new System.Drawing.Point(52, 451);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "选择存期";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("楷体", 25F);
            this.label4.Location = new System.Drawing.Point(35, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 34);
            this.label4.TabIndex = 14;
            this.label4.Text = "有效的定期存款";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(322, 31);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(579, 186);
            this.dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "额度";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "存期";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 83;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "购买日期";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 131;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "到期时间";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 131;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("楷体", 25F);
            this.label6.Location = new System.Drawing.Point(131, 309);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 34);
            this.label6.TabIndex = 27;
            this.label6.Text = "新增定期存款";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-172, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1354, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "_________________________________________________________________________________" +
    "_______________________________";
            // 
            // TimeDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 578);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cardBalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buyBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.planChoose);
            this.Controls.Add(this.buyNum);
            this.Font = new System.Drawing.Font("宋体", 18F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TimeDeposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "定期存款";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox buyNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buyBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cardBalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox planChoose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}