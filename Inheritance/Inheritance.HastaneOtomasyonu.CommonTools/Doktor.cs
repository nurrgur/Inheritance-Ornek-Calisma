using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.HastaneOtomasyonu.CommonTools
{
    public class Doktor:Bolum
    {
        public string AdSoyad { get; set; }
        public string CepTel { get; set; }
        public string Mail { get; set; }

        #region Kalıtımsız Hali
        //public Bolum DoktorunBolumu { get; set; } 
        #endregion

        public override string ToString()
        {
            return AdSoyad + " " + BolumAdi;
        }
    }
}
