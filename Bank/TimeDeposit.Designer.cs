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
            this.holdPlan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // planChoose
            // 
            this.planChoose.FormattingEnabled = true;
            this.planChoose.ItemHeight = 12;
            this.planChoose.Items.AddRange(new object[] {
            "3个月/年利率1.4%",
            "6个月/年利率1.65%",
            "1年/年利率1.95%",
            "2年/年利率2.4%",
            "3年/年利率3%",
            "5年/年利率3%"});
            this.planChoose.Location = new System.Drawing.Point(114, 123);
            this.planChoose.Margin = new System.Windows.Forms.Padding(2);
            this.planChoose.Name = "planChoose";
            this.planChoose.Size = new System.Drawing.Size(110, 76);
            this.planChoose.TabIndex = 7;
            // 
            // buyNum
            // 
            this.buyNum.Location = new System.Drawing.Point(134, 249);
            this.buyNum.Margin = new System.Windows.Forms.Padding(2);
            this.buyNum.Name = "buyNum";
            this.buyNum.Size = new System.Drawing.Size(76, 21);
            this.buyNum.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 252);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "购买金额";
            // 
            // buyBtn
            // 
            this.buyBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buyBtn.Location = new System.Drawing.Point(87, 303);
            this.buyBtn.Margin = new System.Windows.Forms.Padding(2);
            this.buyBtn.Name = "buyBtn";
            this.buyBtn.Size = new System.Drawing.Size(77, 25);
            this.buyBtn.TabIndex = 9;
            this.buyBtn.Text = "确认购买";
            this.buyBtn.UseVisualStyleBackColor = true;
            this.buyBtn.Click += new System.EventHandler(this.buyBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "储蓄卡余额";
            // 
            // cardBalance
            // 
            this.cardBalance.Location = new System.Drawing.Point(134, 214);
            this.cardBalance.Margin = new System.Windows.Forms.Padding(2);
            this.cardBalance.Name = "cardBalance";
            this.cardBalance.ReadOnly = true;
            this.cardBalance.Size = new System.Drawing.Size(76, 21);
            this.cardBalance.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "选择存期";
            // 
            // holdPlan
            // 
            this.holdPlan.Location = new System.Drawing.Point(115, 30);
            this.holdPlan.Margin = new System.Windows.Forms.Padding(2);
            this.holdPlan.Multiline = true;
            this.holdPlan.Name = "holdPlan";
            this.holdPlan.ReadOnly = true;
            this.holdPlan.Size = new System.Drawing.Size(110, 66);
            this.holdPlan.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "已购的定期存款";
            // 
            // TimeDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 339);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.holdPlan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cardBalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buyBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.planChoose);
            this.Controls.Add(this.buyNum);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TimeDeposit";
            this.Text = "定期存款";
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
        private System.Windows.Forms.TextBox holdPlan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox planChoose;
    }
}