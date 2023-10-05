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
    public partial class register : Form
    {
        String o = "Data Source=ORCl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActorsForm a = new ActorsForm();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(o);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into customer values (:snum,:name,:phone,:gender,:ccid,:city,:zone,:block,:flat)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("snum", textBox1.Text);
            cmd.Parameters.Add("name", textBox2.Text);
            cmd.Parameters.Add("phone",textBox3.Text);
            if (radioButton1.Checked==true)
            {
                cmd.Parameters.Add("gender", "male");
            }
            if(radioButton2.Checked==true) {
                cmd.Parameters.Add("gender", "female");
            }
            cmd.Parameters.Add("ccid", textBox5.Text);
            cmd.Parameters.Add("city", textBox6.Text);
            cmd.Parameters.Add("zone", textBox7.Text);
            cmd.Parameters.Add("block", textBox8.Text);
            cmd.Parameters.Add("flat", textBox9.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("added successfully!!!");
                user_sign u = new user_sign();
                this.Hide();
                u.Show();
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            conn.Close();
        }
    }
}
