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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // planChoose
            // 
            this.planChoose.FormattingEnabled = true;
            this.planChoose.ItemHeight = 15;
            this.planChoose.Items.AddRange(new object[] {
            "3个月/年利率1.4%",
            "6个月/年利率1.65%",
            "1年/年利率1.95%",
            "2年/年利率2.4%",
            "3年/年利率3%",
            "5年/年利率3%"});
            this.planChoose.Location = new System.Drawing.Point(152, 154);
            this.planChoose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.planChoose.Name = "planChoose";
            this.planChoose.Size = new System.Drawing.Size(145, 94);
            this.planChoose.TabIndex = 7;
            // 
            // buyNum
            // 
            this.buyNum.Location = new System.Drawing.Point(179, 311);
            this.buyNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buyNum.Name = "buyNum";
            this.buyNum.Size = new System.Drawing.Size(100, 25);
            this.buyNum.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "购买金额";
            // 
            // buyBtn
            // 
            this.buyBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buyBtn.Location = new System.Drawing.Point(116, 379);
            this.buyBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buyBtn.Name = "buyBtn";
            this.buyBtn.Size = new System.Drawing.Size(103, 31);
            this.buyBtn.TabIndex = 9;
            this.buyBtn.Text = "确认购买";
            this.buyBtn.UseVisualStyleBackColor = true;
            this.buyBtn.Click += new System.EventHandler(this.buyBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "储蓄卡余额";
            // 
            // cardBalance
            // 
            this.cardBalance.Location = new System.Drawing.Point(179, 268);
            this.cardBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cardBalance.Name = "cardBalance";
            this.cardBalance.ReadOnly = true;
            this.cardBalance.Size = new System.Drawing.Size(100, 25);
            this.cardBalance.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "选择存期";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "已购的定期存款";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(137, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(198, 116);
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
            // TimeDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 424);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cardBalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buyBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.planChoose);
            this.Controls.Add(this.buyNum);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
    }
}