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
    public partial class contacts : Form
    {
        public contacts()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            new skype().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Public\Documents\MyHelper\data.mdb;Jet OLEDB:Database Password=$5PZ@GR#eV&y3Yb+rr9w;";
            string strSQL = "DELETE FROM call WHERE Name = '" + comboBox1.Text + "'";
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
            comboBox1.Items.Remove(comboBox1.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Public\Documents\MyHelper\data.mdb;Jet OLEDB:Database Password=$5PZ@GR#eV&y3Yb+rr9w;";
            string strSQL = "INSERT INTO call(name, login) VALUES ('" + textBox1.Text + "' ,'" + textBox2.Text + "')";
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
            
            textBox2.Text = "";
            comboBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
        }

        private void contacts_Load(object sender, EventArgs e)
        {
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Public\Documents\MyHelper\data.mdb;Jet OLEDB:Database Password=$5PZ@GR#eV&y3Yb+rr9w;";
            string strSQL = "SELECT * FROM call WHERE name";
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
                            comboBox1.Items.Add(reader["name"].ToString());

                        }
                    }
                }
                catch (Exception ex)
                {
                }
            }


            string o = "";
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

            if (o != "РУС")
            {
                button1.Text = "Delete";
                button2.Text = "Add";
                label2.Text = "Choose name";
                label11.Text = "Support";
                label12.Text = "Settings";
                label3.Text = "Add new contact";
                label4.Visible = false;
                label5.Visible = true;
                label1.Text = "Enter name";
            }
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
