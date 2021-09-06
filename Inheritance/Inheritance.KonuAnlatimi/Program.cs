using System;

namespace Inheritance.KonuAnlatimi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir sınıftan yeni bir sınıf oluşturma işlemine kalıtım denir.Kalıtım kullanımında hangi
            // sınıftan kalıtım alınıyorsa o sınıfa ait metotlar ve özellikler yeni sınıfta da olur.
            // İstenirse yeni sınıfa farklı özellik ve metotlar eklenebilir. Bir sınıf sadece bir sınıftan türetilebilir.

            // Base Class: Kalıtım (miras) veren sınıftır.
            // Derived Class: Kalıtım alan sınıftır. Her derived sınıfın yalnızca bir base classı vardır.

            // Bir sınıf kalıtım aldığında base classın constructorı tetiklenmektedir. Birden fazla constructor 
            // olduğu durumlarda base keyword ü kullanılarak tetiklenmek istenen constructor a yönlendirirlir.
            // Eğer boş constructor tetiklensin istiyorsak base keywordünü kullanmaya gerek yoktur.
            // Ayrıca base class da bir member a ulaşmak istiyorsak yine base keywordünü kullanarak o member
            // çağırılabilir.



            //Araba sınıfı Arac sınıfından türediği için Arac sınıfının özelliklerini alabilir.
            //Constructor boş gönderildiği için Araba sınıfındaki boş constructor çalıştırılır.
            Araba arb = new Araba();
            arb.KapiSayisi = "4";
            arb.Hiz = 100;
            arb.KapiVarMi = true;
            arb.Marka = "Honda";
            arb.TekerSayisi = "4";
            arb.HareketEt();  //Araba classında override edilen HareketEt Metodun da
                              //base keywordü kullanılmadığı için üst sınıftaki HareketEt metodu çalıştırılmaz.
            Console.WriteLine("--------------------------------------------");

            Araba arb2 = new Araba("deneme"); //arb2 nesnesi oluşturulurken constructor a string parametre
                                              //girildiği için Araba classındaki dolu constructor çalıştırılır.
            arb2.KapiSayisi = "4";
            arb2.Hiz = 180;
            arb2.KapiVarMi = true;
            arb2.Marka = "Mercedes";
            arb2.TekerSayisi = "4";
            arb2.HareketEt();
            Console.WriteLine("--------------------------------------------");

            //Oluşturulan motor nesnesinin HareketEt metodunda hem base class içindeki HareketEt metodu
            //hem de Motor classındaki override edilen HareketEt metodu çalıştırılır.
            Motor motor = new Motor();
            motor.Hiz = 130;
            motor.KapiVarMi = false;
            motor.Marka = "Yamaha";
            motor.TekerSayisi = "2";
            motor.YarisMotoruMu = true;
            motor.HareketEt(); 

            Console.ReadLine();
        }
    }
}
