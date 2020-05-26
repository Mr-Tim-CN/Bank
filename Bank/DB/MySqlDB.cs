using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Bank.DB
{
    public class MySqlDB
    {
        private static string _DBConnString = System.Configuration.ConfigurationSettings.AppSettings["DBConnectionString"];
        public static string DBConnString
        {
            get
            {
                return _DBConnString;
            }
        }

        public static DataSet GetDataSet(string sql)
        {
            if (DBConnString == null || DBConnString == "")
                return null;

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, DBConnString);
            MySqlCommandBuilder cmdbld = new MySqlCommandBuilder(dataAdapter);
            DataSet dsMyData = new DataSet();
            dataAdapter.Fill(dsMyData);
            return dsMyData;
        }

        public static int ExecuteNonQuery(string sql)
        {
            if (DBConnString == null || DBConnString == "")
                return 0;

            MySqlConnection con = new MySqlConnection(DBConnString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            try
            {
                int n = cmd.ExecuteNonQuery();
                con.Close();
                if (n > 0)
                {
                    MessageBox.Show("成功！");
                }
                return n;
            }
            catch
            {
                con.Close();
                MessageBox.Show("手机号已存在");
                return 0;
            }
            
        }

        public static string ExecuteScalar(string sql)
        {
            if (DBConnString == null || DBConnString == "")
                return null;

            MySqlConnection myConn = new MySqlConnection(DBConnString);
            MySqlCommand myCommand = new MySqlCommand(sql, myConn);
            myConn.Open();
            object ret = myCommand.ExecuteScalar();
            myConn.Close();
            if (ret == null) return null;
            return ret.ToString();
        }

        public static MySqlDataReader ExecuteReader(string sql)
        {
            if (DBConnString == null || DBConnString == "")
                return null;

            MySqlConnection conn = new MySqlConnection(DBConnString);
            conn.Open();
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("登录成功！");
                UserCenter insert = new UserCenter();
                insert.Show();
            }
            else
            {
                MessageBox.Show("登录失败！");
            }
            reader.Close();        //每次执行完毕都得关闭reader
            conn.Close();
            return reader;
        }
    }
}
