using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
            1- Dictionary sinifi icinde sizin belirleyeceginiz bir key e uygun olarak deger saklar
            zorunlulugu var.
            2- key turunu belirtmeniz sart (string, int vs...)

            */

            Dictionary <string, int> nameAndAge = new Dictionary<string, int>();
            nameAndAge.Add("Amy", 25);
            nameAndAge.Add("Mehmet", 30);
            nameAndAge.Add("Birisi", 15);

            foreach (var nameAndAges in nameAndAge)
            {
                Console.WriteLine(nameAndAges);
            }

            //Sayma ozelligi mevcuttur.

            var countOfNameAndAge = nameAndAge.Count();
            Console.WriteLine();
            Console.WriteLine("Count of Items : " + countOfNameAndAge);

            //Silme ozelligi mevcuttur.

            nameAndAge.Remove("Birisi");
            Console.WriteLine();
            foreach (var nameAndAges in nameAndAge)
            {
                Console.WriteLine(nameAndAges);
            }

            Console.ReadLine();


        }
    }

    
}
