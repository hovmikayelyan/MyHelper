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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu().Show();
            string o = "";
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Public\Documents\MyHelper\data.mdb;Jet OLEDB:Database Password=$5PZ@GR#eV&y3Yb+rr9w;";
            string strSQL = "UPDATE `settings` SET `value` = '" + bunifuDropdown1.selectedValue + "' WHERE `name` = 'language'";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand(strSQL, connection);
                try
                {
                    connection.Open();
                    command = new OleDbCommand(strSQL, connection);
                    command.ExecuteReader();
                    connection.Close();
                }
                catch (Exception ex)
                {
                }
            }

           

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            timer1.Start();
            string o = "";
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Public\Documents\MyHelper\data.mdb;Jet OLEDB:Database Password=$5PZ@GR#eV&y3Yb+rr9w;";
            string strSQL = "SELECT * FROM settings WHERE (name = 'timer')";
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
            if (o.Trim() != "выкл.")
            {
               timer2.Interval = Int32.Parse(o) * 60000;
                    timer2.Start();
            }

            strSQL = "SELECT * FROM settings WHERE (name = 'language')";
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

            if (o == "РУС")
            {
                bunifuDropdown1.selectedIndex = 0;
            }
            else
            {
                bunifuDropdown1.selectedIndex = 1;
                button1.Text = "Start";
            }




        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            System.GC.Collect();

            string o = "";
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Public\Documents\MyHelper\data.mdb;Jet OLEDB:Database Password=$5PZ@GR#eV&y3Yb+rr9w;";
            string strSQL = "SELECT * FROM settings WHERE (name = 'alarm2')";
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

            

            string nowtime = DateTime.Now.ToString("HH:mm tt").Trim();
        
            if (String.Equals(o, nowtime))
            {
                new alarm().Show();
           }

        /*   strSQL = "SELECT * FROM settings WHERE (name = 'alarm3')";
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

            

            if (String.Equals(o, nowtime))
            {
                new alarm().Show();
            }

            strSQL = "SELECT * FROM settings WHERE (name = 'alarm4')";
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



            if (String.Equals(o, nowtime))
            {
                new alarm().Show();
            }
            */
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 0");
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
           
            

        }
    }
}
