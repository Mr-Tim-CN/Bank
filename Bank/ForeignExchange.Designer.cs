namespace Bank
{
    partial class ForeignExchange
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
            this.currencyChoose = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.holdExc = new System.Windows.Forms.TextBox();
            this.excToRmbBtn = new System.Windows.Forms.RadioButton();
            this.rmbToExcBtn = new System.Windows.Forms.RadioButton();
            this.excNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buyPrice = new System.Windows.Forms.Label();
            this.sellPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currencyChoose
            // 
            this.currencyChoose.FormattingEnabled = true;
            this.currencyChoose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.currencyChoose.Items.AddRange(new object[] {
            "美元",
            "日元",
            "港币"});
            this.currencyChoose.Location = new System.Drawing.Point(14, 21);
            this.currencyChoose.Margin = new System.Windows.Forms.Padding(2);
            this.currencyChoose.Name = "currencyChoose";
            this.currencyChoose.Size = new System.Drawing.Size(108, 20);
            this.currencyChoose.TabIndex = 0;
            this.currencyChoose.Text = "选择一个币种";
            this.currencyChoose.SelectedIndexChanged += new System.EventHandler(this.currencyChoose_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "该货币持有量";
            // 
            // holdExc
            // 
            this.holdExc.Location = new System.Drawing.Point(154, 75);
            this.holdExc.Margin = new System.Windows.Forms.Padding(2);
            this.holdExc.Name = "holdExc";
            this.holdExc.ReadOnly = true;
            this.holdExc.Size = new System.Drawing.Size(76, 21);
            this.holdExc.TabIndex = 3;
            // 
            // excToRmbBtn
            // 
            this.excToRmbBtn.AutoSize = true;
            this.excToRmbBtn.Location = new System.Drawing.Point(28, 113);
            this.excToRmbBtn.Margin = new System.Windows.Forms.Padding(2);
            this.excToRmbBtn.Name = "excToRmbBtn";
            this.excToRmbBtn.Size = new System.Drawing.Size(95, 16);
            this.excToRmbBtn.TabIndex = 4;
            this.excToRmbBtn.TabStop = true;
            this.excToRmbBtn.Text = "兑换为人民币";
            this.excToRmbBtn.UseVisualStyleBackColor = true;
            // 
            // rmbToExcBtn
            // 
            this.rmbToExcBtn.AutoSize = true;
            this.rmbToExcBtn.Location = new System.Drawing.Point(140, 113);
            this.rmbToExcBtn.Margin = new System.Windows.Forms.Padding(2);
            this.rmbToExcBtn.Name = "rmbToExcBtn";
            this.rmbToExcBtn.Size = new System.Drawing.Size(95, 16);
            this.rmbToExcBtn.TabIndex = 5;
            this.rmbToExcBtn.TabStop = true;
            this.rmbToExcBtn.Text = "从人民币兑换";
            this.rmbToExcBtn.UseVisualStyleBackColor = true;
            // 
            // excNum
            // 
            this.excNum.Location = new System.Drawing.Point(154, 159);
            this.excNum.Margin = new System.Windows.Forms.Padding(2);
            this.excNum.Name = "excNum";
            this.excNum.Size = new System.Drawing.Size(76, 21);
            this.excNum.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "兑换数量（等额人民币）";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 223);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "确认兑换";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "买入价";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "卖出价";
            // 
            // buyPrice
            // 
            this.buyPrice.AutoSize = true;
            this.buyPrice.Location = new System.Drawing.Point(194, 14);
            this.buyPrice.Name = "buyPrice";
            this.buyPrice.Size = new System.Drawing.Size(11, 12);
            this.buyPrice.TabIndex = 11;
            this.buyPrice.Text = " ";
            // 
            // sellPrice
            // 
            this.sellPrice.AutoSize = true;
            this.sellPrice.Location = new System.Drawing.Point(194, 46);
            this.sellPrice.Name = "sellPrice";
            this.sellPrice.Size = new System.Drawing.Size(11, 12);
            this.sellPrice.TabIndex = 12;
            this.sellPrice.Text = " ";
            // 
            // ForeignExchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 272);
            this.Controls.Add(this.sellPrice);
            this.Controls.Add(this.buyPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.excNum);
            this.Controls.Add(this.rmbToExcBtn);
            this.Controls.Add(this.excToRmbBtn);
            this.Controls.Add(this.holdExc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currencyChoose);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ForeignExchange";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox currencyChoose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox holdExc;
        private System.Windows.Forms.RadioButton excToRmbBtn;
        private System.Windows.Forms.RadioButton rmbToExcBtn;
        private System.Windows.Forms.TextBox excNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label buyPrice;
        private System.Windows.Forms.Label sellPrice;
    }
}