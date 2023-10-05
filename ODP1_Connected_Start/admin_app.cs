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
    public partial class admin_app : UserControl
    {
        String o = "Data Source=ORCl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        OracleDataAdapter adapter;
        DataSet ds;
        OracleCommandBuilder bulider;
        public admin_app()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(o);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into applience values (:snum,:name,:type,:amount,:price,:ad_pass)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("snum", textBox1.Text);
            cmd.Parameters.Add("name", maskedTextBox1.Text);
            cmd.Parameters.Add("type", maskedTextBox2.Text);
            cmd.Parameters.Add("amount", maskedTextBox5.Text);
            cmd.Parameters.Add("price", maskedTextBox6.Text);
            cmd.Parameters.Add("ad_pass", administration_sign_in_page.Pass);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("added successfully!!!");
            }
            textBox1.Text = "";
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            maskedTextBox5.Text = "";
            maskedTextBox6.Text = "";
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cmdstr1 = "select * from applience";
            adapter = new OracleDataAdapter(cmdstr1, o);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {

            bulider = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            MessageBox.Show("done!!");
        }
    }
}
