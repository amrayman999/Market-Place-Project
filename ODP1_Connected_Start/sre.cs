using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
namespace ODP1_Connected_Start
{
    public partial class sre : UserControl
    {
        sr s;
        public sre()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s.SetParameterValue(0,textBox1.Text); 
            crystalReportViewer1.ReportSource = s;
        }

        private void sre_Load(object sender, EventArgs e)
        {
            s = new sr();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
