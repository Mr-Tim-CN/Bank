using MySql.Data.MySqlClient;
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
    public partial class Login : Form
    {
        public static Login f1;
        public Login()
        {
            InitializeComponent();
            f1 = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("输入不完整，请检查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string phonenumber = textBox1.Text.Trim();
                string password = textBox2.Text.Trim();
                string sql = "Select * from userinfo where 手机号='" + phonenumber + "' AND 密码='" + password + "'";
                string sql2 = "Select * from userinfo where 手机号='" + phonenumber + "'";
                
                DB.MySqlDataBase mdb = new DB.MySqlDataBase();              //实例化MySqlDataBase的一个对象mdb
                MySqlDataReader rd = mdb.read(sql);
                MySqlDataReader rd2 = mdb.read(sql2);
                if (rd.Read())
                {
                    MessageBox.Show("登录成功！");
                    UserCenter insert = new UserCenter();
                    insert.Show();          //显示这个窗体
                    this.Hide();            //隐藏这个窗体
                    rd.Close();
                }
                else if(rd2.Read())
                {
                    MessageBox.Show("密码错误");
                    rd2.Close();
                }
                else
                {
                    MessageBox.Show("手机号不存在");
                }
            }
            
        }
        public static string Getphonenum()
        {
           
            return f1.textBox1.Text.Trim();
        }
        public static string Getname()
        {
            string phonenumber = Getphonenum();
            string sql = "Select * from userinfo where 手机号='" + phonenumber + "'";
            DB.MySqlDataBase mdb = new DB.MySqlDataBase();
            MySqlDataReader rd = mdb.read(sql);
            if(rd.Read())
            {
                string name = rd["姓名"].ToString();
                rd.Close();                             //关闭连接
                return name;
            }
            else
            {
                return "亲爱的用户";
            }
        }
    }
}
