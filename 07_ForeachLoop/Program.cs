using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //Foreach (1;2;3;4)
            //1: Değiken Türü
            //2: Değişken Adı
            //3: In
            //4: Liste, Koleksiyon, Dizi Adı

            //string[] cities = { "Uşak", "Ankara", "Venedik", "Oslo" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 15, 23, 96, 78, 41, 57, 86, 4257, 123, 654, 784512 };
            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 15, 23, 96, 78, 41, 57, 86, 4257, 123, 654, 784512 };
            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 15, 23, 96, 78, 41, 57, 86, 4257, 123, 654, 784512 };
            //int total = 0;
            //foreach (int number in numbers)
            //{

            //    total += number;

            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>() { 15, 48, 79, 35, 154, 90 };
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Merhaba";
            //foreach (char item in word)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.Write("***** C# Eğitim Kampı Sınav Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Öğrencilerin Adının ve Sınıftaki Mevcut Öğrenci Sayısının Girilmesi 

            Console.WriteLine("-----------------------------------");
            Console.Write("Sınıfınızda Kaç Tane Öğrenci Bulunmaktadır: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------");

            string[] studentName = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            //Öğrencilerin 3 Sınav Notunun Girilmesi

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. Öğrencinin Adı Soyadı: ");
                studentName[i] = Console.ReadLine();

                double totalExamResult = 0;

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentName[i]} İsimli Öğrencinin {j + 1}. Sınav notunu giriniz: ");
                    double exam = double.Parse(Console.ReadLine());
                    totalExamResult += exam;

                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;

            }
            //Öğrencilerin Ortalamasının Gösterilmesi
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentName[i]} öğrencinin ortalaması: {studentExamAvg[i]}");
                

                //Öğrencilerin Geçip Kaldığının Gösterilmesi
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentName[i]} dersi geçti");

                }
                else
                {
                    Console.WriteLine($"{studentName[i]} dersi kaldı");

                }
                Console.WriteLine();
            }


            #endregion
            Console.Read();

        }
    }
}
