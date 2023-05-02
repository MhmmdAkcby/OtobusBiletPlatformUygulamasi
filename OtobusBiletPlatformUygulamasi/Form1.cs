namespace OtobusBiletPlatformUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        string ad, soyad, tc, telefonNo, nereden, nereye, cinsiyet;
        int toplamfiyat, teklikoltukfiyat, camkenarifiyat, ekstrabagjfiyat, mediaplayerfiyat;

        public void temizle()
        {
            MskTC.Text = "";
            TxtAD.Text = "";
            TxtSOYAD.Text = "";
            MskTELEFON.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ad = TxtAD.Text;
            soyad = TxtSOYAD.Text;
            tc = MskTC.Text;
            telefonNo = MskTELEFON.Text;

            teklikoltukfiyat = 100;
            camkenarifiyat = 85;
            ekstrabagjfiyat = 50;
            mediaplayerfiyat = 75;


            if (tc.Length != 11)
            {
                MessageBox.Show("Lütfen geçerli bir TC kimlik numarasý girin.");
                return;
            }
            if (string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(soyad))
            {
                MessageBox.Show("Lütfen ad ve soyad alanlarýný doldurun.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (telefonNo.Length != 14)
            {
                MessageBox.Show("Lütfen geçerli bir telefon numarasý girin.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (string.IsNullOrWhiteSpace(nereden) || string.IsNullOrWhiteSpace(nereye))
            {
                MessageBox.Show("Lütfen nereden ve nereye alanlarýný doldurun.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ChkERKEK.Checked == false && ChkKADIN.Checked == false)
            {
                MessageBox.Show("Lütfen cinsiyet seçiniz", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ChkERKEK.Checked == true && ChkKADIN.Checked == true)
            {
                MessageBox.Show("Ayný anda iki cinsiyet seçemezsiniz", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            listBox1.Items.Add("TC: " + tc);
            listBox1.Items.Add("Ad: " + ad);
            listBox1.Items.Add("Soyad: " + soyad);
            listBox1.Items.Add("Telefon Numarasý: " + telefonNo);
            listBox1.Items.Add("Nereden: " + nereden);
            listBox1.Items.Add("Nereye: " + nereye);
            listBox1.Items.Add("Bilet Tarihi:" + dateTimePicker1.Text);
            listBox1.Items.Add("Bilet Türü: " + comboBox3.Text);


            int selectedExtrasCount = 0;
            int toplamfiyat = Convert.ToInt32(comboBox3.Text);

            if (ChkTekliKoltuk.Checked)
            {
                toplamfiyat += teklikoltukfiyat;
                listBox1.Items.Add("Tekli Koltuk: " + ChkTekliKoltuk.Text);
                selectedExtrasCount++;
            }

            if (ChkCamKenari.Checked)
            {
                toplamfiyat += camkenarifiyat;
                listBox1.Items.Add("Cam Kenarý: " + ChkCamKenari.Text);
                selectedExtrasCount++;
            }

            if (ChkEkstraBagaj.Checked)
            {
                toplamfiyat += ekstrabagjfiyat;
                listBox1.Items.Add("Bagaj: " + ChkEkstraBagaj.Text);
                selectedExtrasCount++;
            }

            if (ChkMediaPlayer.Checked)
            {
                toplamfiyat += mediaplayerfiyat;
                listBox1.Items.Add("Media Player: " + ChkMediaPlayer.Text);
                selectedExtrasCount++;
            }


            if (ChkERKEK.Checked == true)
            {
                cinsiyet = "Erkek";
                ChkKADIN.Checked = false;
                listBox1.Items.Add("Cinsiyet: " + cinsiyet);
            }
            else if (ChkKADIN.Checked == true)
            {
                cinsiyet = "Kadýn";
                ChkERKEK.Checked = false;
                listBox1.Items.Add("Cinsiyet: " + cinsiyet);
            }

            listBox1.Items.Add("Toplam Fiyat: " + toplamfiyat);

            listBox2.Items.Add("Seferiniz Baþarýyla oluþtu lütfen iþlemi onaylayýn");
            listBox2.Items.Add("Tarih: " + DateTime.Now);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            nereden = comboBox1.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            nereye = comboBox2.Text;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ýþlem baþarýyla gerçekleþti iyi günler", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Restart();
        }
    }
}