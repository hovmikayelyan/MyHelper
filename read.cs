using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHelper
{
    public partial class read : Form
    {
        public read()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
           
            button1.Visible = false;
           

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
          
     

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
             System.Windows.Forms.Application.Exit();
        }

        private void read_Load(object sender, EventArgs e)
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

            }
            else
            {

            }

        }

        private void alphaBlendTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            new settings().Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Hide();
            new support().Show();
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

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Process.Start(@"notes\ssn.exe");
        }
        

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Process.Start("magnify.exe");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Process.Start(@"keyboard\Keyboard.byHov.exe");

        }


        private async void button1_ClickAsync(object sender, EventArgs e)
        {

            string language = bunifuDropdown1.selectedValue;
            string text = textBox1.Text;
            var request = (HttpWebRequest)WebRequest.Create("http://myhelper.mcdir.ru/api/text_to_speech.php?lang=" + language + "&audio=" + text);
            var postData = "audio=" + text;
            var data = Encoding.ASCII.GetBytes(postData);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;
            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            if ((bunifuDropdown1.selectedValue == "Russian") || (bunifuDropdown1.selectedValue == "Ukrainian"))
            {
                axWindowsMediaPlayer2.URL = responseString;
            }
            else
            {
                axWindowsMediaPlayer2.URL = "temp/test.wav";
                if (File.Exists("temp/a.mp3"))
                {
                    File.Delete("temp/a.mp3");
                }
                try
                {
                    File.Delete("temp/a.mp3");
                }
                catch (Exception ex) { }

                byte[] binaryData = Convert.FromBase64String(responseString);
                File.WriteAllBytes("temp/a.mp3", binaryData);
                axWindowsMediaPlayer2.URL = "temp/a.mp3";
            }

            string o = "";
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Public\Documents\MyHelper\data.mdb;Jet OLEDB:Database Password=$5PZ@GR#eV&y3Yb+rr9w;";
            string strSQL = "SELECT * FROM settings WHERE (name = 'jest')";
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
                if (bunifuDropdown1.selectedIndex != 0 & bunifuDropdown1.selectedIndex != 1)
                {
                    MessageBox.Show("Sorry, the system works only in English, Russian");

                }

                String a = textBox1.Text + " ";


                bool isLooping = true;

                for (int i = 0; i < a.Length; i++)
                {
                    String c = a.Substring(i, 1);
                    string path = @"jest/" + c + ".gif";
                    string path1 = @"jest/" + c + ".PNG";

                    if (bunifuDropdown1.selectedIndex == 1)
                    {
                        if (c == " ")
                        {

                            string imgname = @"jest/s.png";
                            pictureBox2.Image = Image.FromFile(imgname);
                            pictureBox2.Refresh();
                            await Task.Delay(TimeSpan.FromSeconds(0.4));
                            if (isLooping && i == a.Length)
                            {
                                i = i - 1;
                            }

                        }
                        else if (File.Exists(path))
                        {

                            string imgname = @"jest/" + c + ".gif";
                            pictureBox2.Image = Image.FromFile(imgname);
                            pictureBox2.Refresh();
                            await Task.Delay(TimeSpan.FromSeconds(0.4));
                            if (isLooping && i == a.Length)
                            {
                                i = i - 1;
                            }
                        }


                        else
                        {
                            pictureBox2.Image = null;
                            Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                            using (Graphics g = Graphics.FromImage(bmp))
                            {
                                g.DrawString(c, new Font("Times New Roman", 100, FontStyle.Regular), new SolidBrush(Color.Black), 40, 40);
                            }
                            pictureBox2.Image = bmp;



                            pictureBox2.Refresh();
                            await Task.Delay(TimeSpan.FromSeconds(0.4));
                            if (isLooping && i == a.Length)
                            {
                                i = i - 1;
                            }
                        }
                    }
                    else
                    {
                        if (c == " ")
                        {
                            string imgname = @"jest/s.png";
                            pictureBox2.Image = Image.FromFile(imgname);
                            pictureBox2.Refresh();
                            await Task.Delay(TimeSpan.FromSeconds(0.4));
                            if (isLooping && i == a.Length)
                            {
                                i = i - 1;
                            }
                        }
                        else if (File.Exists(path1))
                        {

                            string imgname = @"jest/" + c + ".PNG";
                            pictureBox2.Image = Image.FromFile(imgname);
                            pictureBox2.Refresh();
                            await Task.Delay(TimeSpan.FromSeconds(0.4));
                            if (isLooping && i == a.Length)
                            {
                                i = i - 1;
                            }
                        }


                        else
                        {
                            pictureBox2.Image = null;
                            Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                            using (Graphics g = Graphics.FromImage(bmp))
                            {
                                g.DrawString(c, new Font("Times New Roman", 100, FontStyle.Regular), new SolidBrush(Color.Black), 40, 40);
                            }
                            pictureBox2.Image = bmp;



                            pictureBox2.Refresh();
                            await Task.Delay(TimeSpan.FromSeconds(0.4));
                            if (isLooping && i == a.Length)
                            {
                                i = i - 1;
                            }
                        }
                    }

                }
            }
            else
            {
                pictureBox2.Enabled = false;
            }

           














        }

     


       

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer2_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            


        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
