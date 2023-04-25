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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHelper
{
    public partial class ask : Form
    {
        public ask()
        {
            InitializeComponent();
            EO.WebBrowser.Runtime.AddLicense("Kb114+30EO2s3OmxGeCm3MGz8M5nzunz7fGo7vf2HaF3s7P9FOKe5ff2EL112PD9GvZ3s+X1D5+t8PT26KF+xrLUE/Go5Omzy5+v3PYEFO6ntKbC461pmaTA6bto2PD9GvZ3s/MDD+SrwPL3Gp+d2Pj26KFpqbPC3a5rp7XIzZ+v3PYEFO6ntKbC46FotcAEFOan2PgGHeR36d7SGeWawbMKFOervtrI9eBysO3XErx2s7MEFOan2PgGHeR3s7P9FOKe5ff26XXj7fQQ7azcws0X6Jzc8gQQyJ21tMbbtnCttcbcs3Wm8PoO5Kfq6doP");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label12_Click(object sender, EventArgs e)
        {

            new settings().Show();
        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            string result;
            textBox2.Visible = false;
            webControl1.Visible = false;
            string language = textBox1.Text;

            string input_lang = comboBox1.Text;
            if (input_lang == "English")
            {
                result = textBox1.Text;

            }
            else
            {

               var  requesta = (HttpWebRequest)WebRequest.Create("http://myhelper.mcdir.ru/api/translate_to_english.php?to=English&result=" + textBox1.Text );
                var postDataa = "result=" + textBox1.Text;
                var dataa = Encoding.ASCII.GetBytes(postDataa);
                requesta.Method = "POST";
                requesta.ContentType = "application/x-www-form-urlencoded";
                requesta.ContentLength = dataa.Length;
                using (var stream = requesta.GetRequestStream())
                {
                    stream.Write(dataa, 0, dataa.Length);
                }
                var responsea = (HttpWebResponse)requesta.GetResponse();
                var responseStrinag = new StreamReader(responsea.GetResponseStream()).ReadToEnd();
                requesta = (HttpWebRequest)WebRequest.Create(responseStrinag);
                responsea = (HttpWebResponse)requesta.GetResponse();
                responseStrinag = new StreamReader(responsea.GetResponseStream()).ReadToEnd();
                requesta = (HttpWebRequest)WebRequest.Create("http://myhelper.mcdir.ru/api/json.php?data=" + responseStrinag);
                responsea = (HttpWebResponse)requesta.GetResponse();
                responseStrinag = new StreamReader(responsea.GetResponseStream()).ReadToEnd();
              result = responseStrinag;
          }


  

            var request = (HttpWebRequest)WebRequest.Create("http://myhelper.mcdir.ru/api/wolfram.php?lang=" + language);
            var postData = "query=" + result;
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
            if (responseString == "Wolfram|Alpha did not understand your input" || responseString == "gvbfjigjifhkghkfighjfdgkhdfjgjkdfjgfdugjdjfdsbjffg" || responseString == "No short answer available")
            {
                //webControl1.Enabled = true;
                webControl1.Visible = true;
                webControl1.WebView.Url = "https://yandex.ru/search/?text=" + textBox1.Text;
            }
            else
            {
                textBox2.Enabled = true;
                textBox2.Visible = true;




                if (input_lang == "English")
                {
                    textBox2.Text = responseString;



                    string languagez =input_lang;
                    var requestz = (HttpWebRequest)WebRequest.Create("http://myhelper.mcdir.ru/api/text_to_speech.php?lang=" + languagez + "&audio=" + responseString);
                    var postDataz = "audio=" + responseString;
                    var dataz = Encoding.ASCII.GetBytes(postDataz);
                    requestz.Method = "POST";
                    requestz.ContentType = "application/x-www-form-urlencoded";
                    requestz.ContentLength = dataz.Length;
                    using (var stream = requestz.GetRequestStream())
                    {
                        stream.Write(dataz, 0, dataz.Length);
                    }
                    var responsez = (HttpWebResponse)requestz.GetResponse();
                    var responseStringz = new StreamReader(responsez.GetResponseStream()).ReadToEnd();

                    if ((input_lang == "Russian") || (input_lang == "Ukrainian"))
                    {
                        axWindowsMediaPlayer1.URL = responseStringz;
                    }
                    else
                    {
                        axWindowsMediaPlayer1.URL = "temp/test.wav";
                        if (File.Exists("temp/a.mp3"))
                        {
                            File.Delete("temp/a.mp3");
                        }
                        try
                        {
                            File.Delete("temp/a.mp3");
                        }
                        catch (Exception ex) { }

                        byte[] binaryData = Convert.FromBase64String(responseStringz);
                        File.WriteAllBytes("temp/a.mp3", binaryData);
                        axWindowsMediaPlayer1.URL = "temp/a.mp3";
                    }

   




                } else
                {

                    var requesta = (HttpWebRequest)WebRequest.Create("http://myhelper.mcdir.ru/api/translate_to_english.php?result=" + responseString + "&to=" + input_lang);
                    var postDataa = "result=" + textBox1.Text;
                    var dataa = Encoding.ASCII.GetBytes(postDataa);
                    requesta.Method = "POST";
                    requesta.ContentType = "application/x-www-form-urlencoded";
                    requesta.ContentLength = dataa.Length;
                    using (var stream = requesta.GetRequestStream())
                    {
                        stream.Write(dataa, 0, dataa.Length);
                    }
                    var responsea = (HttpWebResponse)requesta.GetResponse();
                    var responseStrinag = new StreamReader(responsea.GetResponseStream()).ReadToEnd();
                    requesta = (HttpWebRequest)WebRequest.Create(responseStrinag);
                    responsea = (HttpWebResponse)requesta.GetResponse();
                    responseStrinag = new StreamReader(responsea.GetResponseStream()).ReadToEnd();
                    requesta = (HttpWebRequest)WebRequest.Create("http://myhelper.mcdir.ru/api/json.php?data=" + responseStrinag);
                    responsea = (HttpWebResponse)requesta.GetResponse();
                   string responseStrinaga = new StreamReader(responsea.GetResponseStream()).ReadToEnd();
 




                    textBox2.Text = responseStrinaga;





                    if (input_lang == "English" || input_lang == "Dutch" || input_lang == "Japanese" || input_lang == "Portuguese" || input_lang == "Russian" || input_lang == "French" || input_lang == "German" || input_lang == "Spanish" || input_lang == "Swedish" || input_lang == "Ukrainian")
                    {





                        string languagez = input_lang;
                        var requestz = (HttpWebRequest)WebRequest.Create("http://myhelper.mcdir.ru/api/text_to_speech.php?lang=" + languagez + "&audio=" + responseString);
                        var postDataz = "audio=" + responseString;
                        var dataz = Encoding.ASCII.GetBytes(postDataz);
                        requestz.Method = "POST";
                        requestz.ContentType = "application/x-www-form-urlencoded";
                        requestz.ContentLength = dataz.Length;
                        using (var stream = requestz.GetRequestStream())
                        {
                            stream.Write(dataz, 0, dataz.Length);
                        }
                        var responsez = (HttpWebResponse)requestz.GetResponse();
                        var responseStringz = new StreamReader(responsez.GetResponseStream()).ReadToEnd();

                        if ((input_lang == "Russian") || (input_lang == "Ukrainian"))
                        {
                            axWindowsMediaPlayer1.URL = responseStringz;
                        }
                        else
                        {
                            axWindowsMediaPlayer1.URL = "temp/test.wav";
                            if (File.Exists("temp/a.mp3"))
                            {
                                File.Delete("temp/a.mp3");
                            }
                            try
                            {
                                File.Delete("temp/a.mp3");
                            }
                            catch (Exception ex) { }

                            byte[] binaryData = Convert.FromBase64String(responseStringz);
                            File.WriteAllBytes("temp/a.mp3", binaryData);
                            axWindowsMediaPlayer1.URL = "temp/a.mp3";
                        }











                    }










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
                if (webControl1.Visible==false)
                {
                    if (o == "true")
                    {
                        if (comboBox1.Text != "Russian" & comboBox1.Text != "English")
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

                            if (comboBox1.Text == "Russian")
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












            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void ask_Load(object sender, EventArgs e)
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
                button1.Text = "Ask a question";
                label2.Text = "Ask a question";
                label11.Text = "Support";
                label12.Text = "Settings";
                label3.Text = "eghregrh";
            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
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
