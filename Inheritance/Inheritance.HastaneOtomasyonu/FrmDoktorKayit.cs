using Inheritance.HastaneOtomasyonu.CommonTools;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Inheritance.HastaneOtomasyonu
{
    public partial class FrmDoktorKayit : Form
    {
        private List<Bolum> bolum;

        public FrmDoktorKayit()
        {
            InitializeComponent();
        }

        public FrmDoktorKayit(List<Bolum> bolum) : this()
        {
            this.bolum = bolum;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text == string.Empty)
            {
                MessageBox.Show("Ad Soyad kısmı boş geçilemez..");
            }
            else if (cmbBolumler.SelectedItem == null)
            {
                MessageBox.Show("Bölüm alanı boş bırakılamaz");
            }
            else if (mskdTel.MaskFull == false)
            {
                MessageBox.Show("Lütfen telefon numaranızı tam giriniz..");
            }
            else if (txtmail.Text.Contains("@") == false)
            {
                MessageBox.Show("Lütfe mail adresinizi tam girin..");
            }
            else
            {
                lstDoktor.Items.Add(
                    new Doktor()
                    {
                        AdSoyad = txtAdSoyad.Text.ToUpper(),
                        Mail = txtmail.Text,
                        CepTel = mskdTel.Text,
                       //DoktorunBolumu = cmbBolumler.SelectedItem as Bolum
                        BolumAdi = cmbBolumler.SelectedItem.ToString()
                    }
                    );
                MessageBox.Show(txtAdSoyad.Text + " isimli doktor " + cmbBolumler.Text + " bölümüne eklendi.."); 
                btnGec.Enabled = true;
                Temizle();
            }
        }

        private void Temizle()
        {
            txtmail.Text = txtAdSoyad.Text = mskdTel.Text = string.Empty;
            cmbBolumler.SelectedItem = null;
        }

        Doktor guncellenenDoktor = null;
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstDoktor.SelectedItem == null) return;
            else
            {
                guncellenenDoktor = (Doktor)lstDoktor.SelectedItem;
                guncellenenDoktor.AdSoyad = txtAdSoyad.Text;
                guncellenenDoktor.CepTel = mskdTel.Text;
                guncellenenDoktor.BolumAdi = cmbBolumler.SelectedItem.ToString();
                lstDoktor.Items.Add(guncellenenDoktor);
                lstDoktor.Items.RemoveAt(lstDoktor.SelectedIndex);
                Temizle();
                MessageBox.Show("Güncelleme gerçekleştirildi..");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstDoktor.SelectedItem == null) return;
            else
            {
                lstDoktor.Items.RemoveAt(lstDoktor.SelectedIndex);
                Temizle();
                MessageBox.Show("Silme işlemi tamamlandı");
            }
        }

        private void btnGec_Click(object sender, EventArgs e)
        {
            List<Doktor> doktor = new List<Doktor>();
            foreach (Doktor item in lstDoktor.Items)
            {
                doktor.Add(item);
            }

            FrmRandevuEkrani frandevu = new FrmRandevuEkrani(bolum, doktor);
            frandevu.Show();
        }
        Doktor secilendoktor = null;
        private void lstDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDoktor.SelectedItem == null) return;
            secilendoktor = (Doktor)lstDoktor.SelectedItem;
            txtAdSoyad.Text = secilendoktor.AdSoyad;
           //cmbBolumler.Text = secilendoktor.DoktorunBolumu.BolumAdi;
            cmbBolumler.Text = secilendoktor.BolumAdi;
            mskdTel.Text = secilendoktor.CepTel;
            txtmail.Text = secilendoktor.Mail;
        }

        private void FrmDoktorKayit_Load(object sender, EventArgs e)
        {
            foreach (Bolum item in bolum)
            {
                cmbBolumler.Items.Add(item);
            }
        }
    }
}