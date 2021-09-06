using Inheritance.HastaneOtomasyonu.CommonTools;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Inheritance.HastaneOtomasyonu
{
    public partial class FrmRandevuEkrani : Form
    {
        private List<Bolum> bolum;
        private List<Doktor> doktor;

        public FrmRandevuEkrani()
        {
            InitializeComponent();
        }

        public FrmRandevuEkrani(List<Bolum> bolum, List<Doktor> d) : this()
        {
            this.bolum = bolum;
            this.doktor = d;
            foreach (Bolum item in bolum)
            {
                cmbBolum.Items.Add(item.BolumAdi);
            }
            foreach (Doktor item in doktor)
            {
                lstDoktor.Items.Add(item);
            }

        }
        Randevu[] randevular = new Randevu[0];
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cmbBolum.SelectedItem == null || lstDoktor.SelectedItem == null)
            {
                MessageBox.Show("Lütfen Bölüm ve Doktor seçimi yaptığınızdan emin olun..");
            }
            else if (txtHastaAdi.Text == string.Empty || dateTimePicker1.Value == null || txtnot.Text == string.Empty || mskdSaat.MaskFull == false)
            {
                MessageBox.Show("Lütfen bilgilerinizi eksiksiz doldurun..");
            }
            else
            {
                Randevu randevu = new Randevu();
                //randevu.RandevuBolum = cmbBolum.SelectedItem as Bolum;
                //randevu.RandevuDoktor = lstDoktor.SelectedItem as Doktor;
                randevu.BolumAdi = cmbBolum.SelectedItem.ToString();
                randevu.AdSoyad = lstDoktor.SelectedItem.ToString();
                randevu.HastaAdi = txtHastaAdi.Text;
                randevu.RandevuTarihi = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                randevu.RandevuSaati = mskdSaat.Text;
                randevu.Not = txtnot.Text;
                Array.Resize(ref randevular, randevular.Length + 1);
                randevular[randevular.Length - 1] = randevu;

                MessageBox.Show("Randevunuz eklendi...");
                btnGunSonu.Enabled = true;
            }
        }

        private void txtDrAra_TextChanged(object sender, EventArgs e)
        {
            lstDoktor.Items.Clear();

            foreach (Doktor doktor in doktor)
            {
                if (doktor.AdSoyad.StartsWith(txtDrAra.Text.ToUpper()) || (doktor.AdSoyad.StartsWith("") && (txtDrAra.Text == "")))
                {
                    lstDoktor.Items.Add(doktor);
                }
            }
        }

        private void FrmRandevuEkrani_Load(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToLongDateString();

        }

        private void btnGunSonu_Click(object sender, EventArgs e)
        {
            FrmGunSonu gunSonu = new FrmGunSonu(bolum,doktor,randevular);
            gunSonu.Show();
        }

        private void cmbBolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstDoktor.Items.Clear();
            foreach (var item in doktor)
            {
                if (item.BolumAdi == cmbBolum.SelectedItem)
                {
                    lstDoktor.Items.Add(item);
                }
            }
        }
    }
}
