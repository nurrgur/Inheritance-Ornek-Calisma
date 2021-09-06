using Inheritance.HastaneOtomasyonu.CommonTools;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Inheritance.HastaneOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            bool kontrol = false;

            if (txtBolum.Text == string.Empty || txtAcıklama.Text == string.Empty)
            {
                MessageBox.Show("Lütfen istenen yerleri doldurunuz..");
                kontrol = true;
            }
            if (kontrol == false)
            {
                try
                {
                    Bolum bolum = new Bolum();
                    bolum.BolumAdi = txtBolum.Text;
                    bolum.Acıklama = txtAcıklama.Text;
                    lstBolum.Items.Add(bolum);
                    MessageBox.Show(bolum.BolumAdi + "  Bölümü başarılı bir şekilde eklendi"); 
                    btnGec.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("hata verdi");
                }
                finally
                {
                    Temizle();
                }
            }
        }

        private void Temizle()
        {
            txtBolum.Text = txtAcıklama.Text = "";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstBolum.SelectedItem == null)
            {
                MessageBox.Show("İşleminizi lütfen kontrol edin..");
            }
            else
            {
                int silinecekSatir = lstBolum.SelectedIndex;
                lstBolum.Items.RemoveAt(silinecekSatir);
                Temizle();
            }
        }
        Bolum guncelBolum = null;
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (lstBolum.SelectedItem == null)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz satırı seçin..");
            }
            else
            {
                guncelBolum = (Bolum)lstBolum.SelectedItem;
                guncelBolum.BolumAdi = txtBolum.Text;
                guncelBolum.Acıklama = txtAcıklama.Text;
                lstBolum.Items.Add(guncelBolum);
                lstBolum.Items.RemoveAt(lstBolum.SelectedIndex);
                Temizle();
            }
        }

        private void btnGec_Click(object sender, EventArgs e)
        {
            List<Bolum>bolum = new List<Bolum>();

            foreach (Bolum item in lstBolum.Items)
            {
                bolum.Add(item);
            }

            FrmDoktorKayit f = new FrmDoktorKayit(bolum);
            f.Show();

        }
        Bolum secilmisBolum = null;
        private void lstBolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilmisBolum = (Bolum)lstBolum.SelectedItem;
            if (secilmisBolum == null) return;

            txtBolum.Text = secilmisBolum.BolumAdi;
            txtAcıklama.Text = secilmisBolum.Acıklama;
        }

    }
    
}
