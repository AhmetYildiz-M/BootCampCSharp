using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            //type safety - tip güvenliği
            //Do not repeat yourself - Kendini tekrarlama
            //değer tutucu, alias

            string categoryTags = "Kategoriler";
            int countOfStudents = 32000;
            double interestRate = 1.45;
            bool checkLoginStatus = true;
            double dollarYesterday = 7.55;
            double dollarToday = 7.55;

            if (dollarYesterday > dollarToday)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dollarYesterday < dollarToday)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }

            if (checkLoginStatus == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            Console.WriteLine();
            Console.WriteLine(categoryTags);
            Console.WriteLine("Hello world!!");
                                  
        }

    }
}
