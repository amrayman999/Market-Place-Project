using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace ODP1_Connected_Start
{
    public partial class user_sign : Form
    {

        public static String password;
        String o = "Data Source=ORCl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public user_sign()
        {
            InitializeComponent();
        }

        private void user_sign_Load(object sender, EventArgs e)
        {

        }

        private void goforadminpage_Click(object sender, EventArgs e)
        {
            user a = new user();
            conn = new OracleConnection(o);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select cust_id , cust_name from customer where cust_id =:id and cust_name =: name";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", textBox2.Text.ToString());
            cmd.Parameters.Add("name", textBox1.Text.ToString());
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.Hide();
                password = textBox2.Text.ToString();
                a.Show();
            }
            else
            {
                MessageBox.Show("user not found in system , wrong data or(you have to register now)!!!!");
            }
            dr.Close();
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            register r = new register();
            this.Close();
            r.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            ActorsForm a = new ActorsForm();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ActorsForm a = new ActorsForm();
            a.Show();
        }
    }
}
