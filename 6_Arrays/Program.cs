using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //2.4.6.8.10.12
            //mavi,kırmızı,yeşil
            //ankara,uşak,izmir
            //DeğikenTürü [] DiziAdı=new DeğişkenTürü[ElemanSayısı];

            //string[] color = new string[4];
            //color[0]="Kırmızı";
            //color[1]="Sarı";
            //color[2]="Yeşil";
            //color[3]="Beyaz";

            //Console.Write(color[3]);

            //string[] cities = new string[5];
            //cities[0]="Uşak";
            //cities[1]="Venedik";
            //cities[2]="Madrid";
            //cities[3]="Seul";
            //cities[4]="Belgrad";

            //Console.Write(cities[5]);

            //int[] numbers = new int[10];
            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;
            //numbers[4] = 4;
            //numbers[8] = 456;

            //Console.Write(numbers[7]);

            //string[] cities = { "Uşak", "Venedik", "Berlin", "Oslo", "Tokyo" };
            //Console.WriteLine(cities[0]);
            #endregion

            #region Dizideki Tüm Elemanları Sıralama

            //string[] colors = { "Kırmızı", "Sarı", "Yeşil", "Mavi", "Turuncu" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(i + 1 + "-" + colors[i]);
            //}

            //int[] numbers = { 4, 85, 96, 74, 125, 635, 489, 520, 7356, 2365, 11200 };

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] %3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '-', '?' };

            //for(int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 12, 12457, 45, 84, 34, 96, 10, 54899975,125, };
            //int maxNumber = myArray[0];
            //for(int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine("Dizinin En Büyük Sayısı: " + maxNumber);

            //string[] persons = { "ali", "ahmet", "burak", "cemil", "deniz" };
            //Console.Write(persons.Length);


            #endregion

            #region Dizi Metotları
            //int[] numbers = { 15, 48, 75, 64, 20, 84, 95, 65, 110 };
            //Array.Sort(numbers);
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 15, 48, 75, 64, 20, 84, 95, 65, 110 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //string[] costumers = {  "yaşar", "şevval", "selen", "dilara" };
            //int index = Array.IndexOf(costumers, "şevval");
            //Console.WriteLine(index);

            //int[] numbers = { 15, 86, 45, 25, 36, 78, 94, 19 };
            //Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max() + " Dizinin en küçük elemanı: " + numbers.Min());


            #endregion

            #region Kullanıcıdan Değer Alma
            //string[] cities = new string[5];
            //for(int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i+1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = new int[5];
            //int sum = 0;
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. sayıyı giriniz: ");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine($"Sonuç: {sum}");

            //int[] numbers = new int[6];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Sayıyı girininz: ");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Çift Sayılar");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Tek Sayılar");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion
            Console.Read();
        }
    }
}
