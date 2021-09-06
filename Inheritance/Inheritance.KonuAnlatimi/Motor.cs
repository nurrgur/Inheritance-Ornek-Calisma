using System;

namespace Inheritance.KonuAnlatimi
{
    //Motor sınıfı Arac sınıfından miras alıyor.
    public class Motor:Arac
    {
        public bool YarisMotoruMu { get; set; }


        //HareketEt Metodunun içinde base classın metodu tekrar çağırıldığı için hem üst sınıfın
        //HareketEt metodu çalıştırılır hem de devamında buradaki HareketEt metodunun kodları çalıştırılır.
        public override void HareketEt()
        {
            base.HareketEt();
            Console.WriteLine("Motor hareket etti..");
        }
    }
}
