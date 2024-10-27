using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar
            //()
            //Geriye değer döndürmeyen metotlar
            //Customer =>>Listele, ekle, sil, güncelle
            //Void

            //void CustomerList()
            //{
            //    Console.WriteLine("Yaşar Ulaş");
            //    Console.WriteLine("Ahmet Ulaş");
            //    Console.WriteLine("Ali Ulaş");
            //    Console.WriteLine("Hasan Ulaş");
            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x+y;

            //    Console.WriteLine(z);

            //}

            //Sum();




            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Yaşar Ulaş");

            //void CustomerCard(string name,string surName)
            //{
            //    Console.WriteLine("Müşteri: "+name+" "+surName);
            //}
            //CustomerCard("Yaşar","Ulaş");
            //CustomerCard("Ali","Tekin");
            //CustomerCard("Ahmet","Taş");


            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1,int number2,int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(4,5,6);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerCard()
            //{
            //    return "Yaşar Ulaş";
            //}

            //CustomerCard();

            //string StudentCard()
            //{
            //    string name = "Yaşar";
            //    string surName = "Ulaş";

            //    return name + " " + surName;
            //}
            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //Console.Write("Girmek İstediğiniz Ülkenin Sayısını Yazınız: ");
            //int count = int.Parse(Console.ReadLine());
            //string[] country = new string[count];

            //for (int i = 0; i < count; i++)
            //{

            //    Console.Write($"{i + 1}.Ülke Giriniz: ");
            //    string countryName = Console.ReadLine();

            //    Console.Write($"{i + 1}.Ülke Başkentini Giriniz: ");
            //    string capitalName = Console.ReadLine();

            //    Console.Write($"{i + 1}.Ülke Bayrak Renklerini Giriniz: ");
            //    string flagColor = Console.ReadLine();

            //    Console.WriteLine("------------------------------------------------");
            //    Console.WriteLine();

            //    string Country(string cName, string caName, string Color)
            //    {

            //        string countryId = $"Ülke: {countryName} - Başkenti: {capitalName} - Bayrak Renkleri: {flagColor}";
            //        return countryId;
            //    };

            //    country[i] = Country(countryName, capitalName, flagColor);

            //}
            //for (int i = 0; i < count; i++)
            //{
            //    Console.WriteLine(country[i]);
            //    Console.WriteLine();
            //}

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1,int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(15, 85));
            //Console.WriteLine(Sum(28, 67));
            //Console.WriteLine(Sum(114, 245));
            //Console.WriteLine(Sum(564, 13));



            #endregion

            #region Örnek Uygulama
            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return $"{student} Sınavı Geçti Ortalaması: "+result;
            //    }
            //    else
            //    {
            //        return $"{student} Sınavdan Kaldı Ortalaması: " + result;
            //    }

            //}

            //Console.WriteLine(ExamResult("Mustafa", 26, 78, 65));

            #endregion

            Console.Read();


        }
    }
}
