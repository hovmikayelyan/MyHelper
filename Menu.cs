using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHelper
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
            new read().Show();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void label12_Click(object sender, EventArgs e)
        {
           
            new settings().Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
           
            new speechtotext().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
            new browser().Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
            new ask().Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new messenger().Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new skype().Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start(@"keyboard\Keyboard.byHov.exe");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("magnify.exe");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start(@"notes\ssn.exe");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string o = "";
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Public\Documents\MyHelper\data.mdb;Jet OLEDB:Database Password=$5PZ@GR#eV&y3Yb+rr9w;";
            string strSQL = "SELECT * FROM settings WHERE (name = 'number')";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand(strSQL, connection);
                try
                {
                    connection.Open();
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            o = reader["value"].ToString();

                        }
                    }
                }
                catch (Exception ex)
                {
                }
            }
            Process.Start("skype:" + o + "?call");
        }

        private void label11_Click(object sender, EventArgs e)
        {
            
            new support().Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            string o = "";
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Public\Documents\MyHelper\data.mdb;Jet OLEDB:Database Password=$5PZ@GR#eV&y3Yb+rr9w;";
            string strSQL = "SELECT * FROM settings WHERE (name = 'language')";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand(strSQL, connection);
                try
                {
                    connection.Open();
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            o = reader["value"].ToString();

                        }
                    }
                }
                catch (Exception ex)
                {
                }
            }

            if (o != "РУС")
            {
              
                label2.Text = "Read text";
                label11.Text = "Support";
                label12.Text = "Settings";
                label3.Text = "Asq a question";
                label1.Text = "Browser";
                label4.Text = "Messenger";
                label5.Text = "Call via Skype";
                label6.Text = "Speech to text";
                label7.Text = "On screen \r\n keyboard";
                label8.Text = "Magnifier";
                label9.Text = "Notes";
                label10.Text = "Calculator";
                
            }
        }
    }
}
