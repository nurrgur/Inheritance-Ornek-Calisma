using Inheritance.HastaneOtomasyonu.CommonTools;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Inheritance.HastaneOtomasyonu
{
    public partial class FrmGunSonu : Form
    {
        private List<Bolum> bolum;
        private List<Doktor> doktor;
        private Randevu[] randevular;

        public FrmGunSonu()
        {
            InitializeComponent();
        }

        public FrmGunSonu(List<Bolum> bolum, List<Doktor> doktor, Randevu[] randevular):this()
        {
            this.bolum = bolum;
            this.doktor = doktor;
            this.randevular = randevular;


            lblTarih.Text = DateTime.Now.ToLongDateString();
            foreach (Randevu randevu in randevular)
            {
                ListViewItem li = new ListViewItem();
                //li.Text = randevu.RandevuBolum.BolumAdi;
                li.Text = randevu.BolumAdi;
                // li.SubItems.Add(randevu.RandevuDoktor.AdSoyad);
                li.SubItems.Add(randevu.AdSoyad);
                li.SubItems.Add(randevu.HastaAdi);
                // li.SubItems.Add(randevu.RandevuTarihi.ToString());
                li.SubItems.Add(randevu.RandevuTarihi);
                li.SubItems.Add(randevu.RandevuSaati);
                li.SubItems.Add(randevu.Not);
                lstRandevu.Items.Add(li);
            }
        }

        private void FrmGunSonu_Load(object sender, EventArgs e)
        {
           

            int sayac = 0;
            foreach (Randevu item in randevular)
            {
                sayac++;
            }

            lblRandevuSayisi.Text = sayac.ToString();
        }
    }
}
