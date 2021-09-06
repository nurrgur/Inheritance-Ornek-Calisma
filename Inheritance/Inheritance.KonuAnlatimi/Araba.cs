using System;

namespace Inheritance.KonuAnlatimi
{
    //Araba sınıfı Arac sınıfından miras alıyor. 
    public class Araba:Arac
    {
        public string KapiSayisi { get; set; }

        public Araba(string s):base(s) //Base classdaki string parametre alan constructor a girilir.
        {
            Console.WriteLine("Araba sınıfındaki string parametre alınan constructor a girildi..");
        }
        public Araba() : base() //Base classdaki boş constructor a girilir.
        {
            Console.WriteLine("Araba sınıfındaki boş constructor a girildi..");
        }
        public override void HareketEt() //Base classdaki HareketEt metodu yerine buradaki metodun
                                         //içi çalıştırılır.
        {
            Console.WriteLine("Araba Hareket etti");
        }


    }
}
