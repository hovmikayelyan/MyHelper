using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHelper
{
    public partial class support : Form
    {
        public support()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Process.Start("mailto:myhelper@it-college.am");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Process.Start("skype:live:myhelper_3?call");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
            Process.Start("http://myhelper.it-college.am/");
         
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Process.Start("http://myhelper.it-college.am/forum/");
        }
    }
}
