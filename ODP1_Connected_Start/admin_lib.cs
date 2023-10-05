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
  
    public partial class admin_lib : UserControl
    {  
        String o = "Data Source=ORCl;User Id=scott;Password=tiger;";
    OracleConnection conn;
    OracleDataAdapter adapter;
    DataSet ds1, ds2;
    OracleCommandBuilder bulider;
        public admin_lib()
        {
            InitializeComponent();
        }

        private void admin_lib_Load(object sender, EventArgs e)
        {
     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bulider = new OracleCommandBuilder(adapter);
            adapter.Update(ds1.Tables[0]);
            MessageBox.Show("done!!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bulider = new OracleCommandBuilder(adapter);
            adapter.Update(ds2.Tables[0]);
            MessageBox.Show("done!!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string cmdstr1 = "select * from libirarian";
            adapter = new OracleDataAdapter(cmdstr1, o);
            ds1 = new DataSet();
            adapter.Fill(ds1);
            dataGridView1.DataSource = ds1.Tables[0];
            string cmdstr2 = "select * from lib_discrip";
            adapter = new OracleDataAdapter(cmdstr2, o);
            ds2 = new DataSet();
            adapter.Fill(ds2);
            dataGridView2.DataSource = ds2.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(o);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into  libirarian values (:snum,:name,:type,:amount,:price,:ad_pass)";
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
            maskedTextBox5.Text="";
            maskedTextBox6.Text = "";
            conn.Close();
        }
    }
}
