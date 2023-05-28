using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace random_sayı_buldurma_ödev_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int sayı = rnd.Next(1, 100);
            int hak = 5;
            Console.WriteLine("Random Çıkan Sayı:" + sayı);

            while (0 < hak)
            {
                Console.WriteLine("Random Çıkan Sayıyı Tahmin Ediniz:");
                int tahmin = Convert.ToInt32(Console.ReadLine());
                if (tahmin == sayı)
                {
                    Console.WriteLine("Tebrikler Doğru Tahminde Bulundunuz");
                    Thread.Sleep(3000);
                    Environment.Exit(0);
                }
                else if (hak == 1)
                {
                    Console.WriteLine("Yanlış Tahminde Bulundunuz Hakkınız Bitti ");
                    break;

                }

                else if (tahmin < sayı)
                {
                    Console.WriteLine("Sayıdan Az Tahminde Bulundunuz Tekrar Deneyiniz");
                    hak--;
                    Console.WriteLine("Kalan Deneme Hakkınız:" + hak);

                }
                else
                {
                    Console.WriteLine("Sayıdan Yüksek Tahminde Bulundunuz Tekrar Deneyiniz");
                    hak--;
                    Console.WriteLine("Kalan Deneme Hakkınız:" + hak);
                }



            }
            Console.WriteLine("Sizi 3 Evetle Uğurluyorum");
            Thread.Sleep(3000);
            Environment.Exit(0);
        }
    }
}
