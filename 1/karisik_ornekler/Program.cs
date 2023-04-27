using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karisik_ornekler
{
    internal class Program
    {
        static void Main(string[] args)
        {


            ///////////////////////////////
            Console.WriteLine("120 sayısının tam bölenlerini yazdıran örnek:");
            Console.ReadLine();

            //int sayi = 120;
            //for (int i = 1; i <= sayi; i++)
            //{
            //    if (sayi % i == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.Read();

            ///////////////////////////////
            Console.WriteLine("Ondan büyük girilen 5 sayıyı toplayan örnek:");
            Console.ReadLine();

            int sayi, toplam = 0;
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine(i + ".Sayıyı Giriniz:");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    if (sayi >= 10)
            //    {
            //        toplam += sayi;
            //    }

            //}
            //Console.WriteLine("SAyıların Toplamı:" + toplam);
            //Console.ReadLine();

            ///////////////////////////////
            Console.WriteLine("Girilen beş sayıdan kaçın tek ve çift olduğunu yazdıran örnek:");
            Console.ReadLine();

            //Console.WriteLine(i + ". Sayıyı Giriniz");
            //sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi % 2 == 0)
            //{
            //    cift++;
            //}
            //else
            //{
            //    tek++;
            //}
            //Console.WriteLine("Çift sayı adedi:" + cift);
            //Console.WriteLine("Tek sayı adedi:" + tek);
            //Console.Read();
                        ///////////////////////////////
            Console.WriteLine("Tutara göre indirim yapan uygulama örneği:");
            Console.ReadLine();

            //double tutar, indirim, odenecek;
            //Console.WriteLine("Alışveriş tutarını giriniz: ");
            //tutar = Convert.ToDouble(Console.ReadLine());
            //if (tutar < 100)
            //{
            //    indirim = tutar * 10 / 100;
            //    odenecek = tutar - indirim;
            //    Console.WriteLine("Ödenecek tutar:" + odenecek);
            //}
            //else if (tutar >= 100 && tutar < 150)
            //{
            //    indirim = tutar * 15 / 100;
            //    odenecek = tutar - indirim;
            //    Console.WriteLine("Ödenecek tutar:" + odenecek);
            //}
            //else if (tutar >= 150 & tutar < 200)
            //{
            //    indirim = tutar * 20 / 0;
            //    odenecek = tutar - indirim;
            //    Console.WriteLine("Ödenecek tutar:" + odenecek);
            //}
            //Console.Read();

            ///////////////////////////////
            Console.WriteLine("Yarıçapı girilen dairenin çevresini ve alanını hesaplayan örnek:");
            Console.ReadLine();

            //double yaricap, cevre, alan;
            //Console.WriteLine("** Daire Çevre Alan Hesap Programı **");
            //Console.WriteLine();
            //Console.Write("Yarıçap Değeri Giriniz: ");
            //yaricap = Convert.ToDouble(Console.ReadLine());
            //cevre = 2 * 3.14 * yaricap;
            //alan = 3.14 * yaricap * yaricap;

            //Console.WriteLine("Dairenin Çevresi: " + cevre);
            //Console.WriteLine("Dairenin Alanı: " + alan);

            //Console.Read();


            ///////////////////////////////
            Console.WriteLine("Öğrenci Not Hesaplama Programı:");
            Console.ReadLine();

            //string ad, soyad, numara;
            //double sinav1, sinav2, sinav3, proje, ortalama;
            //Console.WriteLine();
            //Console.WriteLine("-- Öğrenci Kimlik Bilgileri --");
            //Console.Write("Adınız: ");
            //ad = Console.ReadLine();
            //Console.Write("Soyadınız: ");
            //soyad = Console.ReadLine();
            //Console.Write("Numaranız: ");
            //numara = Console.ReadLine();
            //Console.WriteLine();

            //Console.WriteLine("-- Öğrenci Sınav Bilgileri --");

            //Console.Write("1. Sınav Notunuz: ");
            //sinav1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("2. Sınav Notunuz: ");
            //sinav2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("3. Sınav Notunuz: ");
            //sinav3 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Proje Notunuz: ");
            //proje = Convert.ToDouble(Console.ReadLine());

            //ortalama = (sinav1 + sinav2 + sinav3 + proje) / 4;
            //Console.WriteLine(ad + " " + soyad);
            //Console.WriteLine("Ortalama Puanınız: " + ortalama);

            //Console.Read();

            ///////////////////////////////
            Console.WriteLine("Karenin çevre ve alanını hesaplayan  örnek:");
            Console.ReadLine();

            //int kenar, cevre, alan;
            //int kisaKenar, uzunKenar, dikAlan, dikCevre;

            //Console.WriteLine("*** Program ***");
            //Console.WriteLine();
            //Console.Write("Kenar Uzunluğu Giriniz: ");
            //kenar = Convert.ToInt32(Console.ReadLine());
            //cevre = kenar * 4;
            //alan = kenar * kenar;
            //Console.WriteLine("Karenin Çevresi: " + cevre);
            //Console.WriteLine("Karenin Alanı: " + alan);
            //Console.WriteLine();

            //Console.WriteLine("*Dikdörtgenin Alan ve Çevresini Hesaplayan Program*");
            //Console.Write("Kısa kenar: ");
            //kisaKenar = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Uzun kenar: ");
            //uzunKenar = Convert.ToInt32(Console.ReadLine());
            //dikCevre = (kisaKenar + uzunKenar) * 2;
            //dikAlan = kisaKenar * uzunKenar;

            //Console.WriteLine("Dikdörtgenin Çevresi: " + dikCevre);
            //Console.WriteLine("Dikdörtgenin Alanı: " + dikAlan);
            //Console.Read();

            ///////////////////////////////
            Console.WriteLine("Girilien sayını pozitif-negatif-sıfır olduğunu yazdıran örnek:");
            Console.ReadLine();

            //int sayi;
            //Console.Write("Lütfen bir sayı giriniz: ");
            //sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi > 0)
            //{
            //    Console.WriteLine("Girilen Sayı Pozitif");
            //}
            //else if (sayi < 0)
            //{
            //    Console.WriteLine("Girilen Sayı Negatif");
            //}
            //else
            //{
            //    Console.WriteLine("0 sayısı girildi");
            //}
            //Console.Read();

            ///////////////////////////////
            Console.WriteLine("Girilien sayını yüzde 18'ini yazdıran örnek:");
            Console.ReadLine();

            //double say, sonuc;
            //Console.Write("Sayı Giriniz: ");
            //say = (int)Convert.ToDouble(Console.ReadLine());
            //sonuc = say * 18 / 100;
            //Console.WriteLine("Girilen sayının %18'i: " + sonuc);

            //Console.Read();

            Console.Read();


















            Console.Read();










        }
    }
}
