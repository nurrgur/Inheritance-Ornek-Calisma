using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.HastaneOtomasyonu.CommonTools
{
    public class Randevu: Doktor
    {
        public string HastaAdi { get; set; }
        public string RandevuTarihi { get; set; }
        public string RandevuSaati { get; set; }
        public string Not { get; set; }

        #region Kalıtımsız hali
        //public Bolum RandevuBolum { get; set; }
        //public Doktor RandevuDoktor { get; set; } 
        #endregion
    }
}
