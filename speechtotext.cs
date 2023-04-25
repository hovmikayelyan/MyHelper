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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHelper
{
    

    public partial class speechtotext : Form
    {
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int record(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);

        public speechtotext()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
           
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

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (File.Exists("temp/mic.wav"))
            {
                File.Delete("temp/mic.wav");
            }
            record("open new Type waveaudio Alias recsound", "", 0, 0);
            record("record recsound", "", 0, 0);

        }

        private async void button2_ClickAsync(object sender, EventArgs e)
        {



            if (File.Exists("out.wav"))
            {
                File.Delete("out.wav");
            }
            if (File.Exists("out.flac"))
            {
                File.Delete("out.flac");
            }
            record("save recsound temp/mic.wav", "", 0, 0);
            record("close recsound", "", 0, 0);
            System.Threading.Thread.Sleep(800);
            Process.Start("ttt.vbs");
            System.Threading.Thread.Sleep(800);
            Process.Start("aaa.vbs");
            System.Threading.Thread.Sleep(800);
            byte[] pdfBytes = File.ReadAllBytes("out.flac");
            string pdfBase64 = Convert.ToBase64String(pdfBytes);
            //  textBox1.Text = pdfBase64;
            string lang = comboBox1.Text;
            string translate = comboBox2.Text;
            if (translate == "-----")
            {
                translate = "no_translate";
            }
            var request = (HttpWebRequest)WebRequest.Create("http://myhelper.mcdir.ru/api/speech_to_text.php?lang=" + lang + "&translate=" + translate);
            var postData = "audio=" + pdfBase64;
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

            if (comboBox2.Text == "-----")
            {
                textBox1.Text = responseString;

            }
            else
            {
                textBox1.Text = responseString;

               request = (HttpWebRequest)WebRequest.Create(responseString);

                response = (HttpWebResponse)request.GetResponse();

                responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();



                request = (HttpWebRequest)WebRequest.Create("http://myhelper.mcdir.ru/api/json.php?data=" + responseString);

                response = (HttpWebResponse)request.GetResponse();

                responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();


 



                textBox1.Text = responseString;



 




            }



            if (comboBox2.Text != "English" & comboBox2.Text != "Russian")
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

                if (comboBox2.Text == "Russian")
                {
                    if (c == " ")
                    {

                        string imgname = @"jest/s.png";
                        pictureBox3.Image = Image.FromFile(imgname);
                        pictureBox3.Refresh();
                        await Task.Delay(TimeSpan.FromSeconds(0.4));
                        if (isLooping && i == a.Length)
                        {
                            i = i - 1;
                        }

                    }
                    else if (File.Exists(path))
                    {

                        string imgname = @"jest/" + c + ".gif";
                        pictureBox3.Image = Image.FromFile(imgname);
                        pictureBox3.Refresh();
                        await Task.Delay(TimeSpan.FromSeconds(0.4));
                        if (isLooping && i == a.Length)
                        {
                            i = i - 1;
                        }
                    }


                    else
                    {
                        pictureBox3.Image = null;
                        Bitmap bmp = new Bitmap(pictureBox3.Width, pictureBox3.Height);
                        using (Graphics g = Graphics.FromImage(bmp))
                        {
                            g.DrawString(c, new Font("Times New Roman", 80, FontStyle.Regular), new SolidBrush(Color.Black), 40, 40);
                        }
                        pictureBox3.Image = bmp;



                        pictureBox3.Refresh();
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
                        pictureBox3.Image = Image.FromFile(imgname);
                        pictureBox3.Refresh();
                        await Task.Delay(TimeSpan.FromSeconds(0.4));
                        if (isLooping && i == a.Length)
                        {
                            i = i - 1;
                        }
                    }
                    else if (File.Exists(path1))
                    {

                        string imgname = @"jest/" + c + ".PNG";
                        pictureBox3.Image = Image.FromFile(imgname);
                        pictureBox3.Refresh();
                        await Task.Delay(TimeSpan.FromSeconds(0.4));
                        if (isLooping && i == a.Length)
                        {
                            i = i - 1;
                        }
                    }


                    else
                    {
                        pictureBox3.Image = null;
                        Bitmap bmp = new Bitmap(pictureBox3.Width, pictureBox3.Height);
                        using (Graphics g = Graphics.FromImage(bmp))
                        {
                            g.DrawString(c, new Font("Times New Roman", 80, FontStyle.Regular), new SolidBrush(Color.Black), 40, 40);
                        }
                        pictureBox3.Image = bmp;



                        pictureBox3.Refresh();
                        await Task.Delay(TimeSpan.FromSeconds(0.4));
                        if (isLooping && i == a.Length)
                        {
                            i = i - 1;
                        }
                    }
                }

            }



        }

        private void label12_Click(object sender, EventArgs e)
        {
            new settings().Show();
        }

        private async void speechtotext_LoadAsync(object sender, EventArgs e)
        {
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

            }
            else
            {

            }
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
