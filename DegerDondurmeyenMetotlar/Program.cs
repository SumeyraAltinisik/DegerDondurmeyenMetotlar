using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerDondurmeyenMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tarih bilgisini görmek için 1'e, saat bilgisini görmek için 2'ye basınız.");
            int secim = int.Parse(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    TarihGoster();
                    break;
                case 2:
                    SaatGoster();
                    break;
                default:
                    Uyari();
                    break;
            }
            Console.ReadKey();
        }

        private static void Uyari()
        {
            Console.WriteLine("Geçerli seçim yapılmadı");
        }

        private static void SaatGoster()
        {
            //saat gösterme işlemleri
            Console.WriteLine(DateTime.Now.TimeOfDay);
        }

        static void TarihGoster()
        {
            //tarih gösterme işlemleri
            Console.WriteLine(DateTime.Now.Date);
        }

       
    }
}
