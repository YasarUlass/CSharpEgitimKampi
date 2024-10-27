using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If else

            //Console.Write("Lütfen Şifrenizi Yazınız: ");
            //string password;
            //password= Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülke Giriniz: ");
            //country = Console.ReadLine();

            //if(capital=="ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("Bilgiler Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Bilgiler Hatalı");
            //}

            //int number;
            //Console.Write("Sayı Giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı Doğru.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Hatalı");
            //}

            //int exam1, exam2, exam3, average;
            //string result;

            //Console.Write("Sınav 1 giriniz:");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav 2 giriniz:");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav 3 giriniz:");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Ortalamanız: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç: Vasat";

            //}
            //if (average > 50 & average < 70)
            //{
            //    result = "Sonuç: Orta";

            //}
            //if (average >= 70 & average < 80)
            //{
            //    result = "Sonuç: İyi";

            //}
            //if (average >= 80 & average < 100)
            //{
            //    result = "Sonuç: Mükemmel";

            //}
            //if (average<0)
            //{
            //    result = "Sonuç: Hata!";

            //}
            //else
            //{
            //    result = "Sonuç: Sınavlara Girmedi";
            //}
            //Console.WriteLine(result);

            //string city;
            //Console.Write("Şehir Giriniz: ");
            //city = Console.ReadLine();

            //if (city == "ankara" | city == "bursa" | city == "uşak" | city == "trabzon")
            //{
            //    Console.WriteLine("Şehir Mavcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Mavcut Değil!!!");
            //}

            //Console.Write("Kullanıcı Adı Giriniz: ");
            //string name = Console.ReadLine();

            //if (name !="admin")
            //{
            //    Console.WriteLine("Kullanıcı Adı Kabul Edilemez...");
            //}
            //else
            //{
            //    Console.WriteLine("Hoşgeldiniz");
            //}

            #endregion

            #region Mod İşlemleri

            //int number;
            //number=26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1.Sayıyı Giriniz: ");
            //int sayi1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sayıyı Giriniz: ");
            //int sayi2 = int.Parse(Console.ReadLine());

            //int result = sayi1 % sayi2;

            //Console.Write("1. sayının 2. sayıya bölümünden kalan: " + result);

            //int sayi;
            //Console.Write("Sayıyı Giriniz: ");
            //sayi = int.Parse(Console.ReadLine());

            //if (sayi % 2 == 0)
            //{
            //    Console.Write("Sayı Çifttir");
            //}
            //else
            //{
            //    Console.Write("Sayı Tektir");
            //}
            #endregion

            #region Char Karakterleri ile Karar yapıları
            //char team;
            //Console.Write("Karakter Giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g'| team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if (team == 'f'| team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if (team == 'b'| team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            #endregion

            #region Örnek Proje Uygulaması
            //Console.WriteLine("***** C# Eğitim Kampı Restorant *****");
            //Console.WriteLine(" ");
            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------");

            //int menuItem;
            //Console.Write("Detayını göremk istediğiniz menüyü seçiniz: ");
            //menuItem = int.Parse(Console.ReadLine());

            //if (menuItem == 1)
            //{
            //    Console.WriteLine("----------- 1-Ana Yemekler -----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-İskender");
            //    Console.WriteLine("2-Beyti");
            //    Console.WriteLine("3-Tavuk Döner");
            //    Console.WriteLine("4-Kuru Pilav");
            //    Console.WriteLine("5-Suşi");
            //    Console.WriteLine("----------- 1-Ana Yemekler -----------");

            //}
            //if (menuItem == 2)
            //{
            //    Console.WriteLine("----------- 2-Çorbalar -----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kelle Paça");
            //    Console.WriteLine("2-Mercimek");
            //    Console.WriteLine("3-Tarhana");
            //    Console.WriteLine("4-Tavuk Suyu");
            //    Console.WriteLine("----------- 2-Çorbalar -----------");

            //}
            //if (menuItem == 3)
            //{
            //    Console.WriteLine("----------- 3-Pizzalar -----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Karışık Pizza");
            //    Console.WriteLine("2-Special Pizza");
            //    Console.WriteLine("3-Sucuklu Pizza");
            //    Console.WriteLine("4-Vejeteryan Pizza");
            //    Console.WriteLine("----------- 3-Pizzalar -----------");

            //}
            //if (menuItem == 4)
            //{
            //    Console.WriteLine("----------- 4-İçecekler -----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Ayran");
            //    Console.WriteLine("2-Kola");
            //    Console.WriteLine("3-Şalgam");
            //    Console.WriteLine("4-Su");
            //    Console.WriteLine("----------- 4-İçecekler -----------");

            //}
            //if (menuItem == 5)
            //{
            //    Console.WriteLine("----------- 5-Tatlılar -----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Magnolia");
            //    Console.WriteLine("2-Sütlaç");
            //    Console.WriteLine("3-Trileçe");
            //    Console.WriteLine("4-Baklava");
            //    Console.WriteLine("----------- 5-Tatlılar -----------");

            //}
            #endregion

            #region Switch Case

            //Console.Write("Lütfen Ay Girişi Yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağutos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;
            //    default: Console.WriteLine("Hatalı Veri Girişi"); break;

            //}

            #endregion

            #region Hesap Makinesi Uygulaması

            //int result;
            //Console.Write("1. sayıyı Giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("2. sayıyı Giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Toplama(+), Çıkarma(-), Çarpma(*), Bölme(/)");
            //Console.Write("Yapacağınız İşlemi Seçiniz:");

            //char symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = (number1 + number2);
            //        Console.WriteLine("Sonuç: " + result); break;
            //    case '-':
            //        result = (number1 - number2);
            //        Console.WriteLine("Sonuç: " + result); break;
            //    case '*':
            //        result = (number1 * number2);
            //        Console.WriteLine("Sonuç: " + result); break;
            //    case '/':
            //        result = (number1 / number2);
            //        Console.WriteLine("Sonuç: " + result); break;

            //    default: Console.WriteLine("Hatalı İşlem!!!"); break;
            //}
            #endregion

            Console.Read();

        }
    }
}
