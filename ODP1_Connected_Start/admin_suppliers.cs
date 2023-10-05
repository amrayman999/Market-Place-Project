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
    public partial class admin_suppliers : UserControl
    {
        String o = "Data Source=ORCl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        OracleDataAdapter adapter;
        DataSet ds1, ds2,ds3,d4;
        OracleCommandBuilder bulider;
        public admin_suppliers()
        {
            InitializeComponent();
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

       
                string cmdstr1 = "select * from supplier";
                adapter = new OracleDataAdapter(cmdstr1, o);
                ds1 = new DataSet();
                adapter.Fill(ds1);
                dataGridView1.DataSource = ds1.Tables[0];
                string cmdstr2 = "select * from sup_admin";
                adapter = new OracleDataAdapter(cmdstr2, o);
                ds2 = new DataSet();
                adapter.Fill(ds2);
                dataGridView2.DataSource = ds2.Tables[0];
     
      
         

   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*conn = new OracleConnection(o);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into  supplier values (:id,:name,:type,:amount,:phone,:city,:street,SYSDATE)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(":id", textBox1.Text);
            cmd.Parameters.Add("name", maskedTextBox1.Text);
            cmd.Parameters.Add("type", maskedTextBox2.Text);
            cmd.Parameters.Add("amount", maskedTextBox5.Text);
            cmd.Parameters.Add("phone", maskedTextBox6.Text);
            cmd.Parameters.Add("city", maskedTextBox3.Text);
            cmd.Parameters.Add("street", maskedTextBox4.Text);


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
            conn.Close();*/
            conn = new OracleConnection(o);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "i";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("subid",textBox1.Text);
            cmd.Parameters.Add("subn",maskedTextBox1.Text);
            cmd.Parameters.Add("gtype", maskedTextBox2.Text);
            cmd.Parameters.Add("amm", maskedTextBox5.Text);
            cmd.Parameters.Add("phone", maskedTextBox6.Text);
            cmd.Parameters.Add("city", maskedTextBox3.Text);
            cmd.Parameters.Add("street",maskedTextBox4.Text);
            cmd.Parameters.Add("last_date",System.DateTime.Today);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("added successfully!!!");
            }
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "insert into sup_admin values(:apass , :supid)";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("apass", administration_sign_in_page.Pass);
            c.Parameters.Add("supid", textBox1.Text);
            c.ExecuteNonQuery();
            OracleCommand g = new OracleCommand();
            g.Connection = conn;
            g.CommandText = "update administator set last_contract_date =: ld where admin_password =:p";
            g.CommandType = CommandType.Text;
            g.Parameters.Add("ld", System.DateTime.Today);
            g.Parameters.Add("p",administration_sign_in_page.Pass);
            g.ExecuteNonQuery();
            textBox1.Text = "";
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            maskedTextBox5.Text = "";
            maskedTextBox6.Text = "";
            maskedTextBox3.Text = "";
            maskedTextBox4.Text = "";
            
            conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            conn = new OracleConnection(o);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "get_all_ids";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("allids", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }

            dr.Close();
            conn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string cmdstr3 = @"select * from supplier where supplier_name = :name " ;
            adapter = new OracleDataAdapter(cmdstr3, o);
            adapter.SelectCommand.Parameters.Add("name", textBox2.Text);
            ds3 = new DataSet();
            adapter.Fill(ds3);
            dataGridView1.DataSource = ds3.Tables[0];
            string cmdstr4 = @"select q.admin_password,q.admin_name,s.supplier_id, s.supplier_name, s.last_contract_date  , s.goods_type  from administator q, sup_admin sa , supplier s where q.admin_password= sa.admin_password and s.supplier_id=sa.sup_id and s.supplier_name=: sa ";
            adapter = new OracleDataAdapter(cmdstr4, o);
            adapter.SelectCommand.Parameters.Add("sa", textBox2.Text);
            d4= new DataSet();
            adapter.Fill(d4);
            dataGridView2.DataSource = d4.Tables[0];
        }

        private void admin_suppliers_Load(object sender, EventArgs e)
        {
           
        }
    }
}
