using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODP1_Connected_Start
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Enabled = true;
            label2.Hide();
            label3.Visible = true;
        }

        private void admin_Load(object sender, EventArgs e)
        {

              admin_food1.Hide();
              admin_acc1.Hide();
              admin_app1.Hide();
              admin_clothes1.Hide();
              admin_cleans1.Hide();
              admin_lib1.Hide();
              admin_toys1.Hide();
              admin_sports1.Hide();
              admin_suppliers1.Hide();
              admin_elec1.Hide();
              sre1.Hide();
            customer_re1.Hide();
              label1.Text = "Welcome , \n" + administration_sign_in_page.tb;
        }

        private void admin_acc1_Load(object sender, EventArgs e)
        {

        }

        private void admin_app1_Load(object sender, EventArgs e)
        {

        }

        private void admin_cleans1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            admin_food1.Show();
            admin_food1.BringToFront();
            admin_acc1.Hide();
            admin_app1.Hide();
            admin_clothes1.Hide();
            admin_cleans1.Hide();
            admin_lib1.Hide();
            admin_toys1.Hide();
            admin_sports1.Hide();
            admin_suppliers1.Hide();
            admin_elec1.Hide();
            sre1.Hide();
            customer_re1.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            admin_food1.Hide();
            admin_acc1.Hide();
            admin_clothes1.Hide();
            admin_app1.Hide();
            admin_cleans1.Hide();
            admin_toys1.Hide();
            admin_sports1.Hide();
            admin_lib1.Show();
            admin_lib1.BringToFront();
            admin_suppliers1.Hide();
            admin_elec1.Hide();
            sre1.Hide();
            customer_re1.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            admin_food1.Hide();
            admin_acc1.Hide();
            admin_clothes1.Hide();
            admin_app1.Hide();
            admin_cleans1.Hide();
            admin_lib1.Hide();
            admin_sports1.Hide();
            admin_toys1.Hide();
            admin_suppliers1.Hide();
            admin_elec1.Hide();
            sre1.Show();
           sre1.BringToFront();
            customer_re1.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            admin_food1.Hide();
            admin_acc1.Hide();
            admin_clothes1.Hide();
            admin_app1.Hide();
            admin_cleans1.Hide();
            admin_lib1.Hide();
            admin_sports1.Hide();
            admin_toys1.Hide();
            admin_suppliers1.Hide();
            admin_elec1.Hide();
            sre1.Hide();
            customer_re1.Show();
            customer_re1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            admin_food1.Hide();
            admin_acc1.Hide();
            admin_app1.Hide();
            admin_clothes1.Show();
            admin_clothes1.BringToFront();
            admin_cleans1.Hide();
            admin_lib1.Hide();
            admin_toys1.Hide();
            admin_sports1.Hide();
            admin_suppliers1.Hide();
            admin_elec1.Hide();
           sre1.Hide();
            customer_re1.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            admin_food1.Hide();
            admin_acc1.Hide();
            admin_app1.Hide();
            admin_clothes1.Hide();
            admin_cleans1.Show();
            admin_cleans1.BringToFront();
            admin_lib1.Hide();
            admin_toys1.Hide();
            admin_sports1.Hide();
            admin_suppliers1.Hide();
            admin_elec1.Hide();
           sre1.Hide();
            customer_re1.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            admin_food1.Hide();
            admin_acc1.Show();
            admin_acc1.BringToFront();
            admin_app1.Hide();
            admin_clothes1.Hide();
            admin_cleans1.Hide();
            admin_lib1.Hide();
            admin_toys1.Hide();
            admin_sports1.Hide();
            admin_suppliers1.Hide();
            admin_elec1.Hide();
           sre1.Hide();
            customer_re1.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            admin_food1.Hide();
            admin_acc1.Hide();
            admin_clothes1.Hide();
            admin_app1.Show();
            admin_app1.BringToFront();
            admin_cleans1.Hide();
            admin_lib1.Hide();
            admin_toys1.Hide();
            admin_sports1.Hide();
            admin_suppliers1.Hide();
            admin_elec1.Hide();
            sre1.Hide();
            customer_re1.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            admin_food1.Hide();
            admin_acc1.Hide();
            admin_clothes1.Hide();
            admin_app1.Hide();
            admin_cleans1.Hide();
            admin_lib1.Hide();
            admin_toys1.Hide();
            admin_sports1.Show();
            admin_sports1.BringToFront();
            admin_suppliers1.Hide();
            admin_elec1.Hide();
           sre1.Hide();
            customer_re1.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            admin_food1.Hide();
            admin_acc1.Hide();
            admin_clothes1.Hide();
            admin_app1.Hide();
            admin_cleans1.Hide();
            admin_lib1.Hide();
            admin_sports1.Hide();
            admin_toys1.Hide();
            admin_suppliers1.Show();
            admin_elec1.Hide();
            admin_suppliers1.BringToFront();
            sre1.Hide();
            customer_re1.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            admin_food1.Hide();
            admin_acc1.Hide();
            admin_clothes1.Hide();
            admin_app1.Hide();
            admin_cleans1.Hide();
            admin_lib1.Hide();
            admin_sports1.Hide();
            admin_toys1.Hide();
            admin_suppliers1.Hide();
            admin_elec1.Show();
            admin_elec1.BringToFront();
            sre1.Hide();
            customer_re1.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            admin_food1.Hide();
            admin_acc1.Hide();
            admin_clothes1.Hide();
            admin_app1.Hide();
            admin_cleans1.Hide();
            admin_lib1.Hide();
            admin_sports1.Hide();
            admin_toys1.Show();
            admin_toys1.BringToFront();
            admin_suppliers1.Hide();
            admin_elec1.Hide();
              sre1.Hide();
            customer_re1.Hide();
        }
    }
}
