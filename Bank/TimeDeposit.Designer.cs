namespace Bank
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // planChoose
            // 
            this.planChoose.FormattingEnabled = true;
            this.planChoose.ItemHeight = 24;
            this.planChoose.Items.AddRange(new object[] {
            "3个月/年利率1.4%",
            "6个月/年利率1.65%",
            "1年/年利率1.95%",
            "2年/年利率2.4%",
            "3年/年利率3%",
            "5年/年利率3%"});
            this.planChoose.Location = new System.Drawing.Point(352, 251);
            this.planChoose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.planChoose.Name = "planChoose";
            this.planChoose.Size = new System.Drawing.Size(216, 148);
            this.planChoose.TabIndex = 7;
            // 
            // buyNum
            // 
            this.buyNum.Location = new System.Drawing.Point(394, 493);
            this.buyNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buyNum.Name = "buyNum";
            this.buyNum.Size = new System.Drawing.Size(148, 35);
            this.buyNum.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 504);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "购买金额";
            // 
            // buyBtn
            // 
            this.buyBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buyBtn.Location = new System.Drawing.Point(488, 546);
            this.buyBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buyBtn.Name = "buyBtn";
            this.buyBtn.Size = new System.Drawing.Size(154, 50);
            this.buyBtn.TabIndex = 9;
            this.buyBtn.Text = "确认购买";
            this.buyBtn.UseVisualStyleBackColor = true;
            this.buyBtn.Click += new System.EventHandler(this.buyBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 436);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "储蓄卡余额";
            // 
            // cardBalance
            // 
            this.cardBalance.Location = new System.Drawing.Point(394, 433);
            this.cardBalance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cardBalance.Name = "cardBalance";
            this.cardBalance.ReadOnly = true;
            this.cardBalance.Size = new System.Drawing.Size(148, 35);
            this.cardBalance.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 308);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "选择存期";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "已购的定期存款";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(206, 36);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(504, 185);
            this.dataGridView1.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "额度";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "存期";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "购买日期";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "到期时间";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // TimeDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 627);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TimeDeposit";
            this.Text = "定期存款";
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
    }
}