
namespace Inheritance.HastaneOtomasyonu
{
    partial class FrmRandevuEkrani
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
            this.lblTarih = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDrAra = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGunSonu = new System.Windows.Forms.Button();
            this.txtnot = new System.Windows.Forms.TextBox();
            this.mskdSaat = new System.Windows.Forms.MaskedTextBox();
            this.txtHastaAdi = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lstDoktor = new System.Windows.Forms.ListBox();
            this.cmbBolum = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(659, 20);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(63, 20);
            this.lblTarih.TabIndex = 35;
            this.lblTarih.Text = "TARİH";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(19, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Doktor Ara";
            // 
            // txtDrAra
            // 
            this.txtDrAra.Location = new System.Drawing.Point(23, 403);
            this.txtDrAra.Name = "txtDrAra";
            this.txtDrAra.Size = new System.Drawing.Size(193, 26);
            this.txtDrAra.TabIndex = 33;
            this.txtDrAra.TextChanged += new System.EventHandler(this.txtDrAra_TextChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(554, 359);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(74, 38);
            this.btnEkle.TabIndex = 32;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGunSonu
            // 
            this.btnGunSonu.Enabled = false;
            this.btnGunSonu.Location = new System.Drawing.Point(584, 454);
            this.btnGunSonu.Name = "btnGunSonu";
            this.btnGunSonu.Size = new System.Drawing.Size(204, 38);
            this.btnGunSonu.TabIndex = 31;
            this.btnGunSonu.Text = "Gün Sonu Raporu";
            this.btnGunSonu.UseVisualStyleBackColor = true;
            this.btnGunSonu.Click += new System.EventHandler(this.btnGunSonu_Click);
            // 
            // txtnot
            // 
            this.txtnot.Location = new System.Drawing.Point(428, 241);
            this.txtnot.Multiline = true;
            this.txtnot.Name = "txtnot";
            this.txtnot.Size = new System.Drawing.Size(200, 110);
            this.txtnot.TabIndex = 30;
            // 
            // mskdSaat
            // 
            this.mskdSaat.Location = new System.Drawing.Point(428, 194);
            this.mskdSaat.Mask = "00:00";
            this.mskdSaat.Name = "mskdSaat";
            this.mskdSaat.Size = new System.Drawing.Size(100, 26);
            this.mskdSaat.TabIndex = 29;
            this.mskdSaat.ValidatingType = typeof(System.DateTime);
            // 
            // txtHastaAdi
            // 
            this.txtHastaAdi.Location = new System.Drawing.Point(428, 107);
            this.txtHastaAdi.Name = "txtHastaAdi";
            this.txtHastaAdi.Size = new System.Drawing.Size(200, 26);
            this.txtHastaAdi.TabIndex = 28;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(428, 149);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // lstDoktor
            // 
            this.lstDoktor.FormattingEnabled = true;
            this.lstDoktor.ItemHeight = 20;
            this.lstDoktor.Location = new System.Drawing.Point(23, 165);
            this.lstDoktor.Name = "lstDoktor";
            this.lstDoktor.Size = new System.Drawing.Size(193, 204);
            this.lstDoktor.TabIndex = 26;
            // 
            // cmbBolum
            // 
            this.cmbBolum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBolum.FormattingEnabled = true;
            this.cmbBolum.Location = new System.Drawing.Point(23, 101);
            this.cmbBolum.Name = "cmbBolum";
            this.cmbBolum.Size = new System.Drawing.Size(193, 28);
            this.cmbBolum.TabIndex = 25;
            this.cmbBolum.SelectedIndexChanged += new System.EventHandler(this.cmbBolum_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(307, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Hasta Adı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(19, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Doktorlarımız";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(289, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Rand. Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(348, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Saat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(358, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Not";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Bölüm Seçiniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(139, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 59);
            this.label1.TabIndex = 18;
            this.label1.Text = "RANDEVU EKRANI";
            // 
            // FrmRandevuEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDrAra);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnGunSonu);
            this.Controls.Add(this.txtnot);
            this.Controls.Add(this.mskdSaat);
            this.Controls.Add(this.txtHastaAdi);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lstDoktor);
            this.Controls.Add(this.cmbBolum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRandevuEkrani";
            this.Text = "FrmRandevuEkrani";
            this.Load += new System.EventHandler(this.FrmRandevuEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDrAra;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGunSonu;
        private System.Windows.Forms.TextBox txtnot;
        private System.Windows.Forms.MaskedTextBox mskdSaat;
        private System.Windows.Forms.TextBox txtHastaAdi;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox lstDoktor;
        private System.Windows.Forms.ComboBox cmbBolum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}