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
    public partial class food : UserControl
    {
        String o = "Data Source=ORCl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public static int total ;
        public food()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void food_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(o);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select serial_number, fo_name, fo_type,amount,price from food  where fo_name =:name";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("name", textBox1.Text.ToString());
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                label1.Visible = false;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                button2.Visible = true;
                comboBox1.Visible = true;
                label3.Text = dr[1].ToString();
                label4.Text = dr[2].ToString();
                label5.Text = "Available amount :"+dr[3].ToString()+" units";
                if (dr[3].Equals(0))
                {
                    label5.Text = "not available now !!!";
                    label8.Visible = false;
                    button2.Visible = false;
                    comboBox1.Visible = false;
                    label7.Visible = false;
                }
                label7.Text = dr[4].ToString()+" LE ";
              

            }
            else
            {
                label1.Visible = true;
                label3.Text = "";
                label4.Text = "";
                label5.Text = "";
                label6.Text = "";
                label7.Text = "";
                button2.Visible = false;
                label8.Text = "";
                comboBox1.Visible = false;
            }
       
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select grene_val from food_grene  where fo_serialnum =:id";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("id", dr[0].ToString());
            OracleDataReader d = c.ExecuteReader();
            if (d.Read())
            {
                label6.Visible = true;
                label6.Text = d[0].ToString();
                

            }
            d.Close();
            dr.Close();
           
            conn.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selection = int.Parse(comboBox1.SelectedItem.ToString());
            conn = new OracleConnection(o);
               conn.Open();
            OracleCommand cd = new OracleCommand();
            cd.Connection = conn;
            cd.CommandText = "select serial_number ,price from food  where fo_name = :name";
            cd.CommandType = CommandType.Text;
            cd.Parameters.Add("name", textBox1.Text.ToString());
            OracleDataReader dr2 = cd.ExecuteReader();
            if (dr2.Read()) {
                OracleCommand c2 = new OracleCommand();
                c2.Connection = conn;
                c2.CommandText = "insert into  user_food values(:id , :serial)";
                c2.CommandType = CommandType.Text;
                c2.Parameters.Add("id", user_sign.password);
                c2.Parameters.Add("serial", dr2[0].ToString());
                int b = c2.ExecuteNonQuery();
                total = int.Parse(dr2[1].ToString()) * selection;
                OracleCommand md = new OracleCommand();
                md.Connection = conn;
                md.CommandText = "select serial_number , amount  from food  where fo_name = :name";
                md.CommandType = CommandType.Text;
                md.Parameters.Add("name", textBox1.Text.ToString());
                OracleDataReader dr1 = md.ExecuteReader();
                if (dr1.Read())
                {
                    OracleCommand c1 = new OracleCommand();
                    c1.Connection = conn;
                    c1.CommandText = "update  food set amount = :neam  where serial_number = :ss";
                    c1.CommandType = CommandType.Text;
                    int current = int.Parse(dr1[1].ToString());
                    c1.Parameters.Add("neam", (current - selection).ToString());
                    c1.Parameters.Add("ss", dr1[0].ToString());
                    int r = c1.ExecuteNonQuery();
                   label2.Visible = true;
                    label2.Text = total.ToString() + " LE ";
                     button12.Visible = true;
                } 
                dr1.Close();
            }
              
            dr2.Close();
            conn.Close();
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.nbe.com.eg/NBE/E/#/AR/Home");
            button12.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            comboBox1.Visible = false;
            button2.Visible = false;
        }
    }
}
