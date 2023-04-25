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
    public partial class messenger : Form
    {
        public messenger()
        {
            InitializeComponent();
            EO.WebBrowser.Runtime.AddLicense("Kb114+30EO2s3OmxGeCm3MGz8M5nzunz7fGo7vf2HaF3s7P9FOKe5ff2EL112PD9GvZ3s+X1D5+t8PT26KF+xrLUE/Go5Omzy5+v3PYEFO6ntKbC461pmaTA6bto2PD9GvZ3s/MDD+SrwPL3Gp+d2Pj26KFpqbPC3a5rp7XIzZ+v3PYEFO6ntKbC46FotcAEFOan2PgGHeR36d7SGeWawbMKFOervtrI9eBysO3XErx2s7MEFOan2PgGHeR3s7P9FOKe5ff26XXj7fQQ7azcws0X6Jzc8gQQyJ21tMbbtnCttcbcs3Wm8PoO5Kfq6doP");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Process.Start(@"keyboard\Keyboard.byHov.exe");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Process.Start("magnify.exe");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Process.Start(@"notes\ssn.exe");
        }

        private void messenger_Load(object sender, EventArgs e)
        {
            string o = "";
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Public\Documents\MyHelper\data.mdb;Jet OLEDB:Database Password=$5PZ@GR#eV&y3Yb+rr9w;";
            string strSQL = "SELECT * FROM settings WHERE (name = 'magnifier')";
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

            if (o == "true")
            {
                pictureBox8.Visible = true;
            }
            else
            {
                pictureBox8.Visible = false;
            }

            strSQL = "SELECT * FROM settings WHERE (name = 'keyboard')";
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

            if (o == "true")
            {
                pictureBox9.Visible = true;
            }
            else
            {
                pictureBox9.Visible = false;
            }


           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            webControl1.Visible = true;
            webControl1.WebView.Url = "https://messenger.com/";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            webControl1.Visible = true;
            webControl1.WebView.Url = "https://vk.com/im"; 
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            webControl1.Visible = true;
            webControl1.WebView.Url = "https://ok.ru/messages/";
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
