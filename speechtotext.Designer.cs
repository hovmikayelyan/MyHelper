namespace MyHelper
{
    partial class speechtotext
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(speechtotext));
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 30);
            this.label3.TabIndex = 71;
            this.label3.Text = "Нач. язык";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(120, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 39);
            this.button2.TabIndex = 70;
            this.button2.Text = "Распознать";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_ClickAsync);
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox12.Image = global::MyHelper.Properties.Resources.turn_off_png_11;
            this.pictureBox12.Location = new System.Drawing.Point(503, 11);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(45, 44);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 69;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Click += new System.EventHandler(this.pictureBox12_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::MyHelper.Properties.Resources.sos;
            this.pictureBox5.Location = new System.Drawing.Point(503, 505);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(45, 45);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 68;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(150, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 22);
            this.label12.TabIndex = 67;
            this.label12.Text = "Настройки";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(13, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 22);
            this.label11.TabIndex = 66;
            this.label11.Text = "Поддержка";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(170, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 30);
            this.label1.TabIndex = 72;
            this.label1.Text = "Язык перевода";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::MyHelper.Properties.Resources.record;
            this.pictureBox1.Location = new System.Drawing.Point(60, 326);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Armenian (Armenia)",
            "Russian (Russia)",
            "Bulgarian (Bulgaria)",
            "Serbian (Serbia)",
            "Ukrainian (Ukraine)",
            "Afrikaans (South Africa)",
            "Amharic (Ethiopia)",
            "Indonesian (Indonesia)",
            "Malay (Malaysia)",
            "Bengali (Bangladesh)",
            "Bengali (India)",
            "Catalan (Spain)",
            "Czech (Czech Republic)",
            "Danish (Denmark)",
            "German (Germany)",
            "English (Australia)",
            "English (Canada)",
            "English (Ghana)",
            "English (United Kingdom)",
            "English (India)",
            "English (Ireland)",
            "English (Kenya)",
            "English (New Zealand)",
            "English (Nigeria)",
            "English (Philippines)",
            "English (South Africa)",
            "English (Tanzania)",
            "English (United States)",
            "Spanish (Argentina)",
            "Spanish (Bolivia)",
            "Spanish (Chile)",
            "Spanish (Colombia)",
            "Spanish (Costa Rica)",
            "Spanish (Ecuador)",
            "Spanish (El Salvador)",
            "Spanish (Spain)",
            "es-US\tSpanish (United States)",
            "Spanish (Guatemala)",
            "Spanish (Honduras)",
            "Spanish (Mexico)",
            "Spanish (Nicaragua)",
            "Spanish (Panama)",
            "Spanish (Paraguay)",
            "Spanish (Peru)",
            "Spanish (Puerto Rico)",
            "Spanish (Dominican Republic)",
            "Spanish (Uruguay)",
            "Spanish (Venezuela)",
            "Basque (Spain)",
            "Filipino (Philippines)",
            "French (Canada)",
            "French (France)",
            "Galician (Spain)",
            "Georgian (Georgia)",
            "Gujarati (India)",
            "Croatian (Croatia)",
            "Zulu (South Africa)",
            "Icelandic (Iceland)",
            "Italian (Italy)",
            "Javanese (Indonesia)",
            "Kannada (India)",
            "Khmer (Cambodia)",
            "Lao (Laos)",
            "Latvian (Latvia)",
            "Lithuanian (Lithuania)",
            "Hungarian (Hungary)",
            "Malayalam (India)",
            "Marathi (India)",
            "Dutch (Netherlands)",
            "Nepali (Nepal)",
            "Norwegian Bokmål (Norway)",
            "Polish (Poland)",
            "Portuguese (Brazil)",
            "Portuguese (Portugal)",
            "Romanian (Romania)",
            "Sinhala (Sri Lanka)",
            "Slovak (Slovakia)",
            "Slovenian (Slovenia)",
            "Sundanese (Indonesia)",
            "Swahili (Tanzania)",
            "Swahili (Kenya)",
            "Finnish (Finland)",
            "Swedish (Sweden)",
            "Tamil (India)",
            "Tamil (Singapore)",
            "Tamil (Sri Lanka)",
            "Tamil (Malaysia)",
            "Telugu (India)",
            "Vietnamese (Vietnam)",
            "اUrdu (Pakistan)",
            "Urdu (India)",
            "Greek (Greece)",
            "Hebrew (Israel)",
            "Arabic (Israel)",
            "Arabic (Jordan)",
            "Arabic (United Arab Emirates)",
            "Arabic (Bahrain)",
            "Arabic (Algeria)",
            "Arabic (Saudi Arabia)",
            "Arabic (Iraq)",
            "Arabic (Kuwait)",
            "Arabic (Morocco)",
            "Arabic (Tunisia)",
            "Arabic (Oman)",
            "Arabic (State of Palestine)",
            "Arabic (Qatar)",
            "Arabic (Lebanon)",
            "Arabic (Egypt)",
            "Persian (Iran)",
            "Hindi (India)",
            "Thai (Thailand)",
            "Korean (South Korea)",
            "Chinese, Mandarin (Traditional, Taiwan)",
            "Chinese, Cantonese (Traditional, Hong Kong)",
            "Japanese (Japan)",
            "Chinese, Mandarin (Simplified, Hong Kong)",
            "Chinese, Mandarin (Simplified, China)"});
            this.comboBox1.Location = new System.Drawing.Point(16, 175);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(115, 21);
            this.comboBox1.TabIndex = 74;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "-----",
            "Albanian",
            "Amharic",
            "English",
            "Arab",
            "Armenian",
            "Afrikaans",
            "Basque",
            "Bashkir",
            "Belorussian",
            "Bengal",
            "Burmese",
            "Bulgarian",
            "Bosnian",
            "Welsh",
            "Hungarian",
            "Vietnamese",
            "Haitian (Creole)",
            "Galician",
            "Dutch",
            "Hill Mari",
            "Greek",
            "Georgian",
            "Gujarati",
            "Danish",
            "Hebrew",
            "Yiddish",
            "Indonesian",
            "Irish",
            "Italian",
            "Icelandic",
            "Spanish",
            "Kazakh",
            "Kannada",
            "Catalan",
            "Kyrgyz",
            "Chinese",
            "Korean",
            "Xhosa",
            "Khmer",
            "Laotian",
            "Latin",
            "Latvian",
            "Lithuanian",
            "Luxembourgish",
            "Malagasy",
            "Malay",
            "Malayalam",
            "Maltese",
            "Macedonian",
            "Maori",
            "Marathi",
            "Mari",
            "Mongolian",
            "German",
            "Nepali",
            "Norwegian",
            "Punjabi",
            "Papiamento",
            "Persian",
            "Polish",
            "Portuguese",
            "Romanian",
            "Russian",
            "Cebuano",
            "Serbian",
            "Sinhalese",
            "Slovak",
            "Slovenian",
            "Swahili",
            "Sudanese",
            "Tajik",
            "Thai",
            "Tagalog",
            "Tamil",
            "Tatar",
            "Telugu",
            "Udmurt",
            "Uzbek",
            "Ukrainian",
            "Urdu",
            "Finnish",
            "French",
            "Hindi",
            "Croatian",
            "Czech",
            "Swedish",
            "Scottish",
            "Estonian",
            "Esperanto",
            "Javanese",
            "Japanese"});
            this.comboBox2.Location = new System.Drawing.Point(185, 175);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(115, 21);
            this.comboBox2.TabIndex = 75;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 216);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(326, 104);
            this.textBox1.TabIndex = 76;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::MyHelper.Properties.Resources.arrow12;
            this.pictureBox2.Location = new System.Drawing.Point(17, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 91;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(379, 160);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(160, 160);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 96;
            this.pictureBox3.TabStop = false;
            // 
            // speechtotext
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyHelper.Properties.Resources.backimage;
            this.ClientSize = new System.Drawing.Size(560, 560);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "speechtotext";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyHelper";
            this.Load += new System.EventHandler(this.speechtotext_LoadAsync);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}