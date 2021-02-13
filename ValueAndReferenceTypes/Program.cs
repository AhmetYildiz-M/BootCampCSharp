using System;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //int, double, string değer tip olarak çalışır. Bu nedenle yeni atanan değerler değişiklik oluşturmaz.
            //Bunun için "ref ve out keyword" araçları kullanılır.

            int number1 = 10;
            int number2 = 30;
            number1 = number2;
            number2 = 65;
            //number1 ?? 30

            

            //Arraylar, classlar, methodlar referans tip olarak çalışırlar. 
            //Bu nedenle değer atandığında yeni değeri ya da veriyi referans alarak çalışırlar.

            int[] numbers1 = new int[] { 10, 20, 30 };
            int[] numbers2 = new int[] { 100, 200, 300 };
            numbers1 = numbers2;
            numbers2[0] = 999;
            //numbers1[0] 999



        }
    }
}
