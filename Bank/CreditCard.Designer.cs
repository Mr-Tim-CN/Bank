namespace Bank
{
    partial class CreditCard
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
            this.UsableCrdTBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UsedCrdTBox = new System.Windows.Forms.TextBox();
            this.DefaultCrdTBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DrawTbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PayBtn = new System.Windows.Forms.Button();
            this.DrawBtn = new System.Windows.Forms.Button();
            this.PayTBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UsableCrdTBox
            // 
            this.UsableCrdTBox.Location = new System.Drawing.Point(137, 134);
            this.UsableCrdTBox.Margin = new System.Windows.Forms.Padding(2);
            this.UsableCrdTBox.Name = "UsableCrdTBox";
            this.UsableCrdTBox.ReadOnly = true;
            this.UsableCrdTBox.Size = new System.Drawing.Size(76, 21);
            this.UsableCrdTBox.TabIndex = 19;
            this.UsableCrdTBox.TextChanged += new System.EventHandler(this.UsableCrd_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "可用额度";
            // 
            // UsedCrdTBox
            // 
            this.UsedCrdTBox.Location = new System.Drawing.Point(137, 87);
            this.UsedCrdTBox.Margin = new System.Windows.Forms.Padding(2);
            this.UsedCrdTBox.Name = "UsedCrdTBox";
            this.UsedCrdTBox.ReadOnly = true;
            this.UsedCrdTBox.Size = new System.Drawing.Size(76, 21);
            this.UsedCrdTBox.TabIndex = 17;
            this.UsedCrdTBox.TextChanged += new System.EventHandler(this.UsedCrd_TextChanged);
            // 
            // DefaultCrdTBox
            // 
            this.DefaultCrdTBox.Location = new System.Drawing.Point(137, 44);
            this.DefaultCrdTBox.Margin = new System.Windows.Forms.Padding(2);
            this.DefaultCrdTBox.Name = "DefaultCrdTBox";
            this.DefaultCrdTBox.ReadOnly = true;
            this.DefaultCrdTBox.Size = new System.Drawing.Size(76, 21);
            this.DefaultCrdTBox.TabIndex = 16;
            this.DefaultCrdTBox.Text = "3000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "已用额度";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "信用额度";
            // 
            // DrawTbox
            // 
            this.DrawTbox.Location = new System.Drawing.Point(103, 191);
            this.DrawTbox.Margin = new System.Windows.Forms.Padding(2);
            this.DrawTbox.Name = "DrawTbox";
            this.DrawTbox.Size = new System.Drawing.Size(76, 21);
            this.DrawTbox.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "支取金额";
            // 
            // PayBtn
            // 
            this.PayBtn.Location = new System.Drawing.Point(225, 191);
            this.PayBtn.Margin = new System.Windows.Forms.Padding(2);
            this.PayBtn.Name = "PayBtn";
            this.PayBtn.Size = new System.Drawing.Size(69, 21);
            this.PayBtn.TabIndex = 22;
            this.PayBtn.Text = "确认支取";
            this.PayBtn.UseVisualStyleBackColor = true;
            this.PayBtn.Click += new System.EventHandler(this.PayBtn_Click);
            // 
            // DrawBtn
            // 
            this.DrawBtn.Location = new System.Drawing.Point(225, 234);
            this.DrawBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DrawBtn.Name = "DrawBtn";
            this.DrawBtn.Size = new System.Drawing.Size(69, 21);
            this.DrawBtn.TabIndex = 25;
            this.DrawBtn.Text = "确认还款";
            this.DrawBtn.UseVisualStyleBackColor = true;
            this.DrawBtn.Click += new System.EventHandler(this.DrawBtn_Click);
            // 
            // PayTBox
            // 
            this.PayTBox.Location = new System.Drawing.Point(103, 234);
            this.PayTBox.Margin = new System.Windows.Forms.Padding(2);
            this.PayTBox.Name = "PayTBox";
            this.PayTBox.Size = new System.Drawing.Size(76, 21);
            this.PayTBox.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 241);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 23;
            this.label3.Text = "从储蓄卡还款";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 26;
            this.label6.Text = "你好，$姓名$";
            // 
            // CreditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 318);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DrawBtn);
            this.Controls.Add(this.PayTBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PayBtn);
            this.Controls.Add(this.DrawTbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UsableCrdTBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UsedCrdTBox);
            this.Controls.Add(this.DefaultCrdTBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreditCard";
            this.Text = "信用卡";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsableCrdTBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UsedCrdTBox;
        private System.Windows.Forms.TextBox DefaultCrdTBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DrawTbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PayBtn;
        private System.Windows.Forms.Button DrawBtn;
        private System.Windows.Forms.TextBox PayTBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
    }
}