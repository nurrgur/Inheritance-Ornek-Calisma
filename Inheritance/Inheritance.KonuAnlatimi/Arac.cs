using System;

namespace Inheritance.KonuAnlatimi
{
    //Motor ve Araba sınıfları bu classı miras alacağı için Arac classı base classdır.
    public class Arac
    {
        public string Marka { get; set; }
        public string TekerSayisi { get; set; }
        public int Hiz { get; set; }
        public bool KapiVarMi  { get; set; }

        public Arac()
        {
            Console.WriteLine("Arac sınıfındaki boş constructor a girildi..");
        }
        public Arac(string a)
        {
            Console.WriteLine("Arac sınıfındaki string parametre alınan constructor a girildi..");
        }

        public virtual void HareketEt()
        {
            Console.WriteLine("Hareket ediliyor..");
        }

    }
}
