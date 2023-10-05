using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace ODP1_Connected_Start
{
    public partial class administration_sign_in_page : Form
    {
        public static String  tb;
        public static String Pass;
        String o = "Data Source=ORCl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public administration_sign_in_page()
        {
            InitializeComponent();
        }

        private void goforadminpage_Click(object sender, EventArgs e)
        {
             admin a = new admin();
           
            conn = new OracleConnection(o);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select admin_password , admin_name from administator where admin_password =:id and admin_name =: name";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id",textBox2.Text.ToString());
            cmd.Parameters.Add("name", textBox1.Text.ToString());
            OracleDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            { 
                this.Hide();
               tb= textBox1.Text.ToString();
                Pass =textBox2.Text.ToString();
                a.Show();
            }
            else
            {
                MessageBox.Show("Admin not found in system or wrong data !!!!");
            }
            dr.Close();
            conn.Close();
        }

        private void administration_sign_in_page_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActorsForm f = new ActorsForm();
            f.Show();
        }
    }
}
