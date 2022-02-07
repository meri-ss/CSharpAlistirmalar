using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlıştırmaları
{
    class Program
    {
        static void Main(string[] args)
        {
            #region    //ALIŞTIRMA 1:Ad ve Soyad Bilgisini string değişenlere alarak ekranda yazdırma




            string ad, soyad;
            Console.Write("Adınız :");
            ad = Console.ReadLine();
            Console.Write("Soyadınız :");
            soyad = Console.ReadLine();
            Console.WriteLine("Merhaba {0} {1}", ad, soyad);
            Console.ReadKey();

            #endregion

            #region  //ALIŞTIRMA 2:Kullanıcıdan 2 sayı isteyerek bu sayıların toplamını bulan program



            int s1, s2, toplam;

            Console.Write("1.sayıyı giriniz: ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.sayıyı giriniz: ");
            s2 = Convert.ToInt32(Console.ReadLine());
            toplam = s1 + s2;
            Console.WriteLine("{0} ve {1} Sayısının Toplamı : {2}", s1, s2, toplam);

            Console.ReadKey();

            #endregion

            #region //ALIŞTIRMA 3:Dikdörtgenin alanını ve çevresini hesaplayarak ekranda gösteren program

            int kisaKenar, uzunKenar, alan, cevre;
            Console.Write("Kısa kenar uzunluğunu giriniz :");
            kisaKenar = Convert.ToInt32(Console.ReadLine());
            Console.Write("Uzun kenar uzunluğunu giriniz :");
            uzunKenar = Convert.ToInt32(Console.ReadLine());
            alan = kisaKenar * uzunKenar;
            cevre = 2 * (kisaKenar + uzunKenar);
            Console.WriteLine("Dikdörtgenin Alanı = {0},Çevresi={1}", alan, cevre);
            Console.ReadKey();



            #endregion

            #region //ALIŞTIRMA 4:Girilen sayının tek mi çift mi olduğunu bulan program

            int sayi;
            Console.WriteLine("Sayı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi % 2 == 0)
            {
                Console.WriteLine("{0} sayısı çift", sayi);
            }
            else
            {
                Console.WriteLine("{0} sayısı tek", sayi);
            }
            Console.ReadKey();

            #endregion

            #region //ALIŞTIRMA 5:Girilen sayının 0-100 arasında olup olmadığını kontrol eden program

            int number;
            Console.WriteLine("Sayı giriniz: ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number <= 100)
            {
                Console.WriteLine("Girilen sayı 0-100 arasındadır", number);
            }
            else
            {
                Console.WriteLine("100'den büyük");
            }
            Console.ReadKey();

            #endregion

            #region //ALIŞTIRMA 6:Vücut Kitle İndeksi hesaplayan program

            double boy, kilo, indeks = 0;
            Console.Write("Boyunuzu m cinsinden Giriniz : ");
            boy = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kilonuzu Giriniz : ");
            kilo = Convert.ToDouble(Console.ReadLine());
            indeks = kilo / (boy * boy);

            Console.WriteLine("Vücut Kitle İndexiniz : {0}", indeks);

            #endregion

            #region //ALIŞTIRMA 7: Cümledeki harf sayısını bulan program

            Console.Write("Bir Cümle Girin ");
            string cumle = Console.ReadLine();
            string liste = "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ"
                           + "abcçdefgğhiıjklmnoöprsştuüvyz";

            int sayac = 0;
            for (int i = 0; i < cumle.Length; i++)
            {
                
                if (liste.Contains(cumle[i]))
                {
                    sayac++;
                }
            }
            Console.WriteLine("Yukarıdaki ifadede toplam {0} \ntane  harf vardır.", sayac);
            Console.ReadLine();


        }
          #endregion
    }
    
}
