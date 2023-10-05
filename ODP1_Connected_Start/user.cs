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
    public partial class user : Form
    {
     
        public user()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void user_Load(object sender, EventArgs e)
        {
            food1.Hide();
            app1.Hide();
            acc1.Hide();
            cleans1.Hide();
            clothes1.Hide();
            elec1.Hide();
            lib1.Hide();
            toy1.Hide();
            sport1.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
              food1.Show();
              food1.BringToFront();
            app1.Hide();
            acc1.Hide();
            cleans1.Hide();
            clothes1.Hide();
            elec1.Hide();
            lib1.Hide();
            toy1.Hide();
            sport1.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            food1.Hide();
            cleans1.Show();
            cleans1.BringToFront();
            app1.Hide();
            acc1.Hide();
            clothes1.Hide();
            elec1.Hide();
            lib1.Hide();
            toy1.Hide();
            sport1.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            food1.Hide();
            cleans1.Hide();
            app1.Hide();
            acc1.Show(); 
            acc1.BringToFront();
            clothes1.Hide();
            elec1.Hide();
            lib1.Hide();
            toy1.Hide();
            sport1.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            food1.Hide();
            cleans1.Hide();
            app1.Hide();
            acc1.Hide();
            clothes1.Hide();
            elec1.Show();
            elec1.BringToFront();
            lib1.Hide();
            toy1.Hide();
            sport1.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            food1.Hide();
            cleans1.Hide();
            app1.Show();
            app1.BringToFront();
            acc1.Hide();
            clothes1.Hide();
            elec1.Hide();
            lib1.Hide();
            toy1.Hide();
            sport1.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            food1.Hide();
            cleans1.Hide();
            app1.Hide();
            toy1.Show();
            toy1.BringToFront();
            acc1.Hide();
            clothes1.Hide();
            elec1.Hide();
            lib1.Hide();
            sport1.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            food1.Hide();
            cleans1.Hide();
            app1.Hide();
            acc1.Hide();
            clothes1.Hide();
            elec1.Hide();
            lib1.Hide();
            toy1.Hide();
            sport1.Show();
            sport1.BringToFront();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            food1.Hide();
            cleans1.Hide();
            app1.Hide();
            acc1.Hide();
            clothes1.Hide();
            elec1.Hide();
            lib1.Show(); 
            lib1.BringToFront();
            toy1.Hide();
            sport1.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            food1.Hide();
            cleans1.Hide();
            app1.Hide();
            acc1.Hide();
            clothes1.Show();
            clothes1.BringToFront();
            elec1.Hide();
            lib1.Hide();
            toy1.Hide();
            sport1.Hide();
        }
    }
}
