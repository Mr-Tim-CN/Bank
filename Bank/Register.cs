using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("输入不完整，请检查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string name = textBox1.Text.Trim();
                string phonenumber = textBox4.Text.Trim();
                string password = textBox2.Text.Trim();
                string cfpwd = textBox3.Text.Trim();
                string sql = "INSERT INTO userinfo VALUES('" + name + "','" + phonenumber + "','" + password + "')";
                if (cfpwd == password)
                {
                    
                    try
                    {
                        DB.MySqlDataBase mdb = new DB.MySqlDataBase();
                        int ext = mdb.Excute(sql);
                        if (ext > 0)
                        {
                            MessageBox.Show("注册成功！");
                            Login insert = new Login();
                            insert.Show();
                            this.Hide();
                        }
                    }
                   
                    catch
                    {
                        MessageBox.Show("手机号已存在");
                    }
                    
                }
                else
                {
                    MessageBox.Show("确认密码错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }
    }
}
