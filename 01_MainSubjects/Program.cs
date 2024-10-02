using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            //Console.WriteLine("Hello");

            //Console.Write("Selam");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemek");
            //Console.WriteLine("3-Soğuk Başangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion

            #region String Değişkenler
            //String
            //Değişken_türü Değiken_adı;

            //string name;
            //name = "Yaşar";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, distric, city;

            //customerName = "Yaşar";
            //customerSurname = "Ulaş";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = "deneme@dnm.com";
            //distric = "Sivaslı";
            //city = "UŞAK";

            //Console.WriteLine("***** Rezervasyon Kartı *****");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------------------");
            //Console.WriteLine("Müşteri:"+ " " + customerName+ " "+ customerSurname);
            //Console.WriteLine("İletişim:" + " " + customerPhone );
            //Console.WriteLine("Email: " + customerEmail);
            //Console.WriteLine("Adres: " + distric + "/" + city);
            //Console.WriteLine("--------------------------------------------------");
            //Console.WriteLine();

            //customerName = "Ali";
            //customerSurname = "Can";
            //customerPhone = "+90 400 300 20 10";
            //customerEmail = "test@tst.com";
            //distric = "Bornova";
            //city = "İZMİR";

            //Console.WriteLine("--------------------------------------------------");

            //Console.WriteLine("Müşteri:" + " " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim:" + " " + customerPhone);
            //Console.WriteLine("Email: " + customerEmail);
            //Console.WriteLine("Adres: " + distric + "/" + city);
            //Console.WriteLine("--------------------------------------------------");
            #endregion

            #region Int değişkenler
            //int number = 25;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 300;

            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger : " + hamburgerPrice + "TL");
            Console.WriteLine("-----Pizza : " + pizzaPrice + "TL");
            Console.WriteLine("-----Kızartma Tabağı : " + friesPrice + "TL");
            Console.WriteLine("-----Limonata : " + lemonadePrice + "TL");
            Console.WriteLine("-----Kola : " + cokePrice + "TL");
            Console.WriteLine("-----Su : " + waterPrice + "TL");

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            hamburgerCount = 3;
            pizzaCount = 0;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            lemonadeCount=0;

            int totalHambuger;
            int totalPizza;
            int totalCoke;
            int totalWater;
            int totalFries;
            int totalLemonade;

            totalHambuger = hamburgerCount * hamburgerPrice;
            totalPizza = pizzaCount * pizzaPrice;
            totalWater = waterCount * waterPrice;
            totalFries = friesCount * friesPrice;
            totalCoke = cokeCount * cokePrice;
            totalLemonade = lemonadeCount * lemonadePrice;


            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Hamburger Tutarı: "+ totalHambuger);
            Console.WriteLine("Kola Tutarı: "+ totalCoke);
            Console.WriteLine("Su Tutarı: "+ totalWater);
            Console.WriteLine("Kızartma Tutarı: "+ totalFries);
            Console.WriteLine("Pizza Tutarı: "+ totalPizza);
            Console.WriteLine("Limonata Tutarı: "+ totalLemonade);

            int totalPrice;
            totalPrice= totalHambuger + totalCoke + totalWater + totalFries + totalPizza + totalLemonade;
            Console.WriteLine();
            Console.WriteLine("Toplam Hesap: " + totalPrice + " TL");
            #endregion

            Console.Read(); 
        }
    }
}
