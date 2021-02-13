using System;


namespace MyDictionary
    {
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Ahmet");
            myDictionary.Add(2, "Mehmet");
            myDictionary.Add(3, "Suleyman");

            myDictionary.List();
            Console.WriteLine();

            Console.WriteLine("***************");

            Console.WriteLine(myDictionary.Count);
                                  
        }
    }


}
