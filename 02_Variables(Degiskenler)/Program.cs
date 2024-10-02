using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables_Degiskenler_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double number;
            //number = 5;
            //Console.WriteLine(number);

            #region Double Değişkenler 
            //Console.WriteLine("***** Market Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, lemonPrice, patatoPrice, strawberryPrice;
            //applePrice=15.75;
            //orangePrice = 12.50;
            //lemonPrice = 25.25;
            //strawberryPrice = 85;
            //patatoPrice = 11.50;

            //Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("---- Elma Birim Fiyatı: "+applePrice + " ₺");
            //Console.WriteLine("---- Portakal Birim Fiyatı: "+orangePrice + " ₺");
            //Console.WriteLine("---- Limon Birim Fiyatı: "+lemonPrice + " ₺");
            //Console.WriteLine("---- Çilek Birim Fiyatı: "+strawberryPrice + " ₺");
            //Console.WriteLine("---- Patates Birim Fiyatı: " + patatoPrice + " ₺");

            //double appleGram, orangeGram, lemonGram, strawberryGram, potatoGram;
            //appleGram = 2.545;
            //orangeGram = 3.784;
            //lemonGram = 1.984;
            //strawberryGram = 0.754;
            //potatoGram = 8.120;

            //double appleTotalPrice, orangeTotalPrice, lemonTotalPrice, strawberryTotalPrice, potatoTotalPrice;

            //appleTotalPrice = appleGram * applePrice;
            //orangeTotalPrice = orangeGram * orangePrice;
            //lemonTotalPrice = lemonGram * lemonPrice;
            //strawberryTotalPrice = strawberryGram * strawberryPrice;
            //potatoTotalPrice = potatoGram * patatoPrice;

            //Console.WriteLine();
            //Console.WriteLine("***** Market Fişiniz *****");
            //Console.WriteLine();

            //Console.WriteLine("Alınan Ürün: "+"Elma Birim Fiyatı: "+applePrice+ "₺ Gramı: " + appleGram+" ----Toplam: "+appleTotalPrice + " ₺");
            //Console.WriteLine("Alınan Ürün: "+ "Portakal Birim Fiyatı: " + orangePrice+ "₺ Gramı: " + orangeGram+" ----Toplam: "+orangeTotalPrice + " ₺");
            //Console.WriteLine("Alınan Ürün: "+ "Limon Birim Fiyatı: " + lemonPrice+ "₺ Gramı: " + lemonGram+" ----Toplam: "+ lemonTotalPrice + " ₺");
            //Console.WriteLine("Alınan Ürün: "+ "Çilek Birim Fiyatı: " + strawberryPrice+ "₺ Gramı: " + strawberryGram+" ----Toplam: "+ strawberryTotalPrice + " ₺");
            //Console.WriteLine("Alınan Ürün: "+ "Patates Birim Fiyatı: " + patatoPrice+ "₺ Gramı: " + potatoGram+" ----Toplam: "+ potatoTotalPrice + " ₺");

            //double totalPrice;
            //totalPrice = appleTotalPrice + orangeTotalPrice + lemonTotalPrice + strawberryTotalPrice + potatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine("Toplam Tutar: " + totalPrice + "₺");
            #endregion

            #region Char Değişkenler

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string passangerName, passangerSurname, passangerDistrict, passangerCity, passangerAge, passangerIdentityNumber;
            //Console.Write("Yolcu Adı: ");
            //passangerName= Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passangerSurname = Console.ReadLine();

            //Console.Write("İlçe: ");
            //passangerDistrict = Console.ReadLine();

            //Console.Write("Şehir: ");
            //passangerCity = Console.ReadLine();

            //Console.Write("Yaş: ");
            //passangerAge = Console.ReadLine();

            //Console.Write("Kimlik Numarası:");
            //passangerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("-------------------------");
            //Console.WriteLine("Yolcunun Kimlik Numarası: "+passangerIdentityNumber+" - Yolcu Adı Soyadı: "+passangerName+" "+passangerSurname +" Yaş: "+passangerAge+" "+ passangerDistrict+"/"+passangerCity);

            #endregion

            #region Klavyeden Tam Sayı Girişleri Ve Dönüşümler

            //int shoesPrice, computerPrice, tvPrice, chairPrice, phonePrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //tvPrice = 15000;
            //chairPrice = 2000;
            //phonePrice = 25000;

            //int shoesCount, computerCount, tvCount, chairCount, phoneCount;

            //Console.Write("Lütfen Ayakkabı Adedini Yazınız:");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Bilgisayar Adedini Yazınız:");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Televizyon Adedini Yazınız:");
            //tvCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Sandalye Adedini Yazınız:");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Telefon Adedini Yazınız:");
            //phoneCount = int.Parse(Console.ReadLine());

            //int totalPrice = (shoesCount * shoesPrice) + (computerCount * computerPrice) + (tvCount * tvPrice) + (chairCount * chairPrice) + (phoneCount * phonePrice);

            //Console.WriteLine();
            //Console.Write("Total Hesap: " + totalPrice);

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Birinci Sınav Notunuz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("İkinci Sınav Notunuz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Üçüncü Sınav Notunuz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız : " +result);

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);
            #endregion
            Console.Read();
        }
    }
}
