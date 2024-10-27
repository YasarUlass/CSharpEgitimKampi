using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt Alta 10 Tane Yıldız Oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i + "*");
            //}
            //Console.Read();

            #endregion

            #region Yan Yana 10 Tane Yıldız Oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int x = 1; x <= 10; x++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}

            #endregion

            #region Alt Alta 10 Tane Yıldız Oluşturma Her Satırda 10 Tane Yıldız Olsun

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}

            #endregion

            #region  Dik Üçgen
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Tersten Dik Üçgen

            //for(int i = 5; i >= 1; i--)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Dik Ve Ters Üçgen Çizdirme
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 4; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region  Baklava Dilimi 
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = n - 1; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = n - 1; i > 0; i--)
            {
                for (int k = n - 1; k > 0; k--)
                {
                    Console.Write(" ");
                }
                for (int m = 1; m <= 2 * i - 1; m++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion

            #region Piramit Oluşturma
            //int n = 5;

            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= n - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ters Piramit Oluşturma

            //int n = 5;

            //for (int i = n; i>=1; i--){
            //    for (int j = n-i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2*i-1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            //for(int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("*");
            //}
            //for(int i = 0; i < 10; i++)
            //{
            //    Console.Write("*");
            //}

            //for(int i = 0; i < 10; i++)
            //{
            //    for(int j = 0; j < 10; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for(int i = 1; i <= 5; i++)
            //{
            //    for(int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.Write("Kaç Satırlı yıldız üçgen oluşsun: ");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = n; i > 0; i--)
            //{
            //    for(int j = 1; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //int n = 10;
            //for(int i = 0; i < n; i++)
            //{
            //    for(int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for(int i = n; i >= 0; i--)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}



            Console.Read();


        }
    }
}
