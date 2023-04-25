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
    public partial class skype : Form
    {
        public skype()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Process.Start(@"notes\ssn.exe");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Process.Start("magnify.exe");

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Process.Start(@"keyboard\Keyboard.byHov.exe");

        }

        private void skype_Load(object sender, EventArgs e)
        {
            string o = "";
            int a = 1;
            int top = 100;
            int left = 100;
            int top1 = 100;
            int left1 = 300;
            int width = 150;
            int height = 40;
          string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Public\Documents\MyHelper\data.mdb;Jet OLEDB:Database Password=$5PZ@GR#eV&y3Yb+rr9w;";
            string strSQL = "SELECT * FROM call WHERE name ";
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
                            o = reader["name"].ToString();
                            Button button = new Button();
                            button.Size = new Size(width, height);
                            button.Font = new Font("Century Gothic", 14, FontStyle.Regular);
                            button.FlatStyle = FlatStyle.Flat;
                            button.FlatAppearance.BorderColor= Color.FromArgb(255, 0, 120, 215);
                            button.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 0, 120, 215);
                            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 0, 120, 215);
                            button.ForeColor = Color.White;
                            button.BackColor = Color.FromArgb(255,0, 120, 215);
                            if (a <= 8)
                            {
                                button.Text = reader["name"].ToString();
                                button.Name = reader["login"].ToString();
                                button.Left = left;
                                button.Top = top;
                                this.Controls.Add(button);
                                top += button.Height + 20;
                                a += 1;
                            }
                            else
                            {
                                button.Text = reader["name"].ToString();
                                button.Name = reader["login"].ToString();
                                button.Left = left1;
                                button.Top = top1;
                                this.Controls.Add(button);
                                top1 += button.Height + 20;
                                a += 1;
                            }

                            button.Click += new System.EventHandler(this.btnButton_Click);

                        }
                    }
                }
                catch (Exception ex)
                {
                }
            }




        }

        void btnButton_Click(object sender, EventArgs e)
        {

            Button currButton = (Button)sender;
            Process.Start("skype:" + currButton.Name + "?call");

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new contacts().Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            new settings().Show();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
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
            this.Hide();
            new support().Show();
        }
    }


}
    

