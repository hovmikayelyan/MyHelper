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
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        private void settings_Load(object sender, EventArgs e)
        {
            string o = "";
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Public\Documents\MyHelper\data.mdb;Jet OLEDB:Database Password=$5PZ@GR#eV&y3Yb+rr9w;";
           string  strSQL = "SELECT * FROM settings WHERE (name = 'magnifier')";
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
               bunifuCheckbox1.Checked = true;
            }
            else
            {
                bunifuCheckbox1.Checked = false;
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
                bunifuCheckbox2.Checked = true;
            }
            else
            {
                bunifuCheckbox2.Checked = false;
            }


            strSQL = "SELECT * FROM settings WHERE (name = 'jest')";
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
                bunifuCheckbox3.Checked = true;
            }
            else
            {
                bunifuCheckbox3.Checked = false;
            }


            strSQL = "SELECT * FROM settings WHERE (name = 'timer')";
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

            comboBox1.Text = o;


           

            strSQL = "SELECT * FROM settings WHERE (name = 'number')";
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

            textBox2.Text = o;


            strSQL = "SELECT * FROM settings WHERE (name = 'alarm1')";
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
            textBox3.Text = o;

            strSQL = "SELECT * FROM settings WHERE (name = 'alarm2')";
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
            textBox4.Text = o;

            strSQL = "SELECT * FROM settings WHERE (name = 'alarm3')";
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
            textBox5.Text = o;

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
            textBox6.Text = o;



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void label12_Click(object sender, EventArgs e)
        {
            new settings().Show();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string bol, lan, time, ser, phone, a1, a2, a3, a4;
            if (bunifuCheckbox1.Checked == true)
            {
                bol = "true";
            }
            else
            {
                bol = "false";
            }

            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Public\Documents\MyHelper\data.mdb;Jet OLEDB:Database Password=$5PZ@GR#eV&y3Yb+rr9w;";
            string strSQL = "UPDATE `settings` SET `value` = '" + bol + "' WHERE `name` = 'magnifier'";
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


            if (bunifuCheckbox2.Checked == true)
            {
                bol = "true";
            }
            else
            {
                bol = "false";
            }


            strSQL = "UPDATE `settings` SET `value` = '" + bol + "' WHERE `name` = 'keyboard'";
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


            if (bunifuCheckbox3.Checked == true)
            {
                bol = "true";
            }
            else
            {
                bol = "false";
            }



            strSQL = "UPDATE `settings` SET `value` = '" + bol + "' WHERE `name` = 'jest'";
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


           

            time = comboBox1.Text;
            strSQL = "UPDATE `settings` SET `value` = '" + time + "' WHERE `name` = 'timer'";
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

           

            phone = textBox2.Text;
            strSQL = "UPDATE `settings` SET `value` = '" + phone + "' WHERE `name` = 'number'";
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

            a1 = textBox3.Text;
            a2 = textBox4.Text;
            a3 = textBox5.Text;
            a4 = textBox6.Text;

            strSQL = "UPDATE `settings` SET `value` = '" + a1 + "' WHERE `name` = 'alarm1'";
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

            strSQL = "UPDATE `settings` SET `value` = '" + a2 + "' WHERE `name` = 'alarm2'";
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

            strSQL = "UPDATE `settings` SET `value` = '" + a3 + "' WHERE `name` = 'alarm3'";
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

            strSQL = "UPDATE `settings` SET `value` = '" + a4 + "' WHERE `name` = 'alarm4'";
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


            Application.Restart();


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
