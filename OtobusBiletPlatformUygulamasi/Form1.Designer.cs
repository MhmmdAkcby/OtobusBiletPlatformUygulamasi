namespace OtobusBiletPlatformUygulamasi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            TxtAD = new TextBox();
            TxtSOYAD = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ChkKADIN = new CheckBox();
            ChkERKEK = new CheckBox();
            groupBox1 = new GroupBox();
            label8 = new Label();
            MskTELEFON = new MaskedTextBox();
            MskTC = new MaskedTextBox();
            button2 = new Button();
            button1 = new Button();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            listBox1 = new ListBox();
            panel1 = new Panel();
            label7 = new Label();
            button3 = new Button();
            listBox2 = new ListBox();
            groupBox2 = new GroupBox();
            comboBox3 = new ComboBox();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label10 = new Label();
            groupBox3 = new GroupBox();
            ChkMediaPlayer = new CheckBox();
            ChkEkstraBagaj = new CheckBox();
            ChkCamKenari = new CheckBox();
            ChkTekliKoltuk = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox2
            // 
            comboBox2.DropDownHeight = 100;
            comboBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.IntegralHeight = false;
            comboBox2.Items.AddRange(new object[] { "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin", "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir", "Kars", "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "K.maraş (Kahramanmaraş)", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak", "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kırıkkale", "Batman", "Şırnak", "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce" });
            comboBox2.Location = new Point(115, 98);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(180, 25);
            comboBox2.TabIndex = 15;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.DropDownHeight = 100;
            comboBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.IntegralHeight = false;
            comboBox1.Items.AddRange(new object[] { "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin", "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir", "Kars", "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "K.maraş (Kahramanmaraş)", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak", "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kırıkkale", "Batman", "Şırnak", "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce" });
            comboBox1.Location = new Point(115, 46);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(180, 25);
            comboBox1.TabIndex = 14;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(27, 98);
            label6.Name = "label6";
            label6.Size = new Size(73, 21);
            label6.TabIndex = 13;
            label6.Text = "Nereye :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(16, 46);
            label5.Name = "label5";
            label5.Size = new Size(84, 21);
            label5.TabIndex = 12;
            label5.Text = "Nereden :";
            // 
            // TxtAD
            // 
            TxtAD.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            TxtAD.Location = new Point(148, 137);
            TxtAD.Name = "TxtAD";
            TxtAD.Size = new Size(147, 25);
            TxtAD.TabIndex = 11;
            // 
            // TxtSOYAD
            // 
            TxtSOYAD.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            TxtSOYAD.Location = new Point(148, 174);
            TxtSOYAD.Name = "TxtSOYAD";
            TxtSOYAD.Size = new Size(147, 25);
            TxtSOYAD.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(359, 95);
            label3.Name = "label3";
            label3.Size = new Size(102, 21);
            label3.TabIndex = 7;
            label3.Text = "Telefon Nu :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(81, 92);
            label4.Name = "label4";
            label4.Size = new Size(40, 21);
            label4.TabIndex = 6;
            label4.Text = "T.C :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(28, 174);
            label2.Name = "label2";
            label2.Size = new Size(93, 21);
            label2.TabIndex = 5;
            label2.Text = "Soyadınız :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(54, 134);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 4;
            label1.Text = "Adınız :";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(562, 138);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 61);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(474, 137);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // ChkKADIN
            // 
            ChkKADIN.AutoSize = true;
            ChkKADIN.BackColor = Color.Transparent;
            ChkKADIN.ForeColor = SystemColors.ButtonHighlight;
            ChkKADIN.Location = new Point(562, 195);
            ChkKADIN.Name = "ChkKADIN";
            ChkKADIN.Size = new Size(68, 25);
            ChkKADIN.TabIndex = 1;
            ChkKADIN.Text = "Kadın";
            ChkKADIN.UseVisualStyleBackColor = false;
            // 
            // ChkERKEK
            // 
            ChkERKEK.AutoSize = true;
            ChkERKEK.BackColor = Color.Transparent;
            ChkERKEK.ForeColor = SystemColors.ButtonHighlight;
            ChkERKEK.Location = new Point(474, 195);
            ChkERKEK.Name = "ChkERKEK";
            ChkERKEK.Size = new Size(67, 25);
            ChkERKEK.TabIndex = 0;
            ChkERKEK.Text = "Erkek";
            ChkERKEK.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(MskTELEFON);
            groupBox1.Controls.Add(MskTC);
            groupBox1.Controls.Add(ChkKADIN);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(ChkERKEK);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(TxtSOYAD);
            groupBox1.Controls.Add(TxtAD);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(36, 231);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(715, 298);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yolcu Kayıt Bilgileri";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(350, 167);
            label8.Name = "label8";
            label8.Size = new Size(79, 21);
            label8.TabIndex = 21;
            label8.Text = "Cinsiyet :";
            // 
            // MskTELEFON
            // 
            MskTELEFON.Location = new Point(488, 92);
            MskTELEFON.Mask = "(999) 000-0000";
            MskTELEFON.Name = "MskTELEFON";
            MskTELEFON.Size = new Size(147, 29);
            MskTELEFON.TabIndex = 20;
            // 
            // MskTC
            // 
            MskTC.Location = new Point(148, 92);
            MskTC.Mask = "00000000000";
            MskTC.Name = "MskTC";
            MskTC.Size = new Size(147, 29);
            MskTC.TabIndex = 19;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkOrange;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(766, 638);
            button2.Name = "button2";
            button2.Size = new Size(246, 40);
            button2.TabIndex = 21;
            button2.Text = "TEMİZLE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(766, 565);
            button1.Name = "button1";
            button1.Size = new Size(246, 42);
            button1.TabIndex = 16;
            button1.Text = "KAYDET";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1099, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(199, 100);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1331, 487);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(67, 42);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 19;
            pictureBox4.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.ControlLightLight;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(1032, 231);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(366, 298);
            listBox1.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(22, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1382, 127);
            panel1.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Black;
            label7.Font = new Font("Modern No. 20", 71.99999F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(23, 7);
            label7.Name = "label7";
            label7.Size = new Size(1029, 98);
            label7.TabIndex = 20;
            label7.Text = "Otobüs Bilet Satış Paneli";
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(1032, 638);
            button3.Name = "button3";
            button3.Size = new Size(366, 43);
            button3.TabIndex = 22;
            button3.Text = "SEFERİ ONAYLA";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 21;
            listBox2.Location = new Point(1032, 544);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(366, 88);
            listBox2.TabIndex = 21;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(comboBox3);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(36, 525);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(715, 154);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "İstikamet Bilgileri";
            // 
            // comboBox3
            // 
            comboBox3.DropDownHeight = 100;
            comboBox3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox3.FormattingEnabled = true;
            comboBox3.IntegralHeight = false;
            comboBox3.Items.AddRange(new object[] { "500 ", "1000 ", "1500 " });
            comboBox3.Location = new Point(446, 98);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(184, 25);
            comboBox3.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(381, 97);
            label9.Name = "label9";
            label9.Size = new Size(51, 21);
            label9.TabIndex = 18;
            label9.Text = "Fiyat:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(446, 40);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(180, 29);
            dateTimePicker1.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(370, 42);
            label10.Name = "label10";
            label10.Size = new Size(52, 21);
            label10.TabIndex = 16;
            label10.Text = "Tarih:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(ChkMediaPlayer);
            groupBox3.Controls.Add(ChkEkstraBagaj);
            groupBox3.Controls.Add(ChkCamKenari);
            groupBox3.Controls.Add(ChkTekliKoltuk);
            groupBox3.ForeColor = SystemColors.ButtonHighlight;
            groupBox3.Location = new Point(777, 231);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(249, 298);
            groupBox3.TabIndex = 24;
            groupBox3.TabStop = false;
            groupBox3.Text = "Özelleştir";
            // 
            // ChkMediaPlayer
            // 
            ChkMediaPlayer.AutoSize = true;
            ChkMediaPlayer.Location = new Point(32, 211);
            ChkMediaPlayer.Name = "ChkMediaPlayer";
            ChkMediaPlayer.Size = new Size(171, 25);
            ChkMediaPlayer.TabIndex = 3;
            ChkMediaPlayer.Text = "Media Player (+75₺)";
            ChkMediaPlayer.UseVisualStyleBackColor = true;
            // 
            // ChkEkstraBagaj
            // 
            ChkEkstraBagaj.AutoSize = true;
            ChkEkstraBagaj.Location = new Point(32, 167);
            ChkEkstraBagaj.Name = "ChkEkstraBagaj";
            ChkEkstraBagaj.Size = new Size(204, 25);
            ChkEkstraBagaj.TabIndex = 2;
            ChkEkstraBagaj.Text = "Ekstra 15kg Bagaj (+50₺)";
            ChkEkstraBagaj.UseVisualStyleBackColor = true;
            // 
            // ChkCamKenari
            // 
            ChkCamKenari.AutoSize = true;
            ChkCamKenari.Location = new Point(32, 125);
            ChkCamKenari.Name = "ChkCamKenari";
            ChkCamKenari.Size = new Size(161, 25);
            ChkCamKenari.TabIndex = 1;
            ChkCamKenari.Text = "Cam Kenarı (+85₺)";
            ChkCamKenari.UseVisualStyleBackColor = true;
            // 
            // ChkTekliKoltuk
            // 
            ChkTekliKoltuk.AutoSize = true;
            ChkTekliKoltuk.Location = new Point(32, 78);
            ChkTekliKoltuk.Name = "ChkTekliKoltuk";
            ChkTekliKoltuk.Size = new Size(168, 25);
            ChkTekliKoltuk.TabIndex = 0;
            ChkTekliKoltuk.Text = "Tekli Koltuk (+100₺)";
            ChkTekliKoltuk.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1428, 767);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(button2);
            Controls.Add(listBox2);
            Controls.Add(button3);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(pictureBox4);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private CheckBox ChkKADIN;
        private CheckBox ChkERKEK;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label6;
        private Label label5;
        private TextBox TxtAD;
        private TextBox TxtSOYAD;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private ListBox listBox1;
        private Button button1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Panel panel1;
        private Label label7;
        private MaskedTextBox MskTC;
        private MaskedTextBox MskTELEFON;
        private Button button2;
        private Button button3;
        private ListBox listBox2;
        private GroupBox groupBox2;
        private Label label8;
        private Label label9;
        private DateTimePicker dateTimePicker1;
        private Label label10;
        private ComboBox comboBox3;
        private GroupBox groupBox3;
        private CheckBox ChkMediaPlayer;
        private CheckBox ChkEkstraBagaj;
        private CheckBox ChkCamKenari;
        private CheckBox ChkTekliKoltuk;
    }
}