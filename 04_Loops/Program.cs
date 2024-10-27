using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            //Döngüler 1+2+3+4+5+6+7+8+9
            //3+3=6+4=10+5=15+6=21

            //for(x;y;z)
            //x:başlangıç
            //y:bitiş
            //z:artma-azalma

            //int i;
            //for(i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}
            //for (int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);

            //}
            //int number;
            //Console.Write("Lütfen Erkrana Yazılmasını İstediğiniz Adedi Yazınız: ");
            //number = int.Parse(Console.ReadLine());

            //for(int i = 0; i <= number; i++)
            //{
            //    Console.WriteLine(i); 
            //}

            #endregion

            #region For Döngüsü İle Karar Yapıları

            //for(int i = 0; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue =0;
            //for(int i = 0; i <= 10; i++)
            //{
            //    totalValue +=i;
            //}
            //Console.WriteLine(totalValue);

            //int totalValue = 0;
            //for (int i = 0; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }



            //}

            //Console.WriteLine("Sonuc: " + totalValue);


            //int count = 0;
            //for(int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        Console.WriteLine(i);
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //int bacterium = 1;
            //for(int i = 1; i <= 24; i++)
            //{

            //    bacterium *= 2;
            //    Console.WriteLine(i+". Saat sonunda: "+bacterium);

            //}
            #endregion

            #region While Döngüsü

            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int result = 0;
            //while (i <= 10)
            //{
            //    result += i;
            //    i++;
            //}
            //Console.WriteLine(result);
            #endregion

            #region Örnek Sınav Sorusu

            //int number,sum,ones,tens,hundreds;
            
            //Console.Write("3 Basamaklı Bir Sayı Giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //ones = number % 10;
            //tens = (number % 100) / 10;
            //hundreds = number / 100;
            //sum = hundreds + tens + ones;
            //Console.WriteLine("Yüzler: "+hundreds+" Onlar: "+tens +" Birler: "+ones+" Basamak Değeri: "+sum);


            #endregion
            Console.Read();

        }
    }
}
