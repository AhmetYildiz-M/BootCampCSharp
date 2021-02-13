using System;
using System.Collections.Generic;

namespace Generics2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cities1 = new List<string>();
            cities1.Add("Ankara");
            cities1.Add("Kenya");
            cities1.Add("Osmaniye");
            cities1.Add("Ankara");
            cities1.Add("Ankara");
            cities1.Add("Ankara");
            cities1.Add("Ankara");
            Console.WriteLine();
            Console.WriteLine("Count of cities1 : " + cities1.Count);



            cities1.Remove("Kenya");
            Console.WriteLine();
            foreach (var remove in cities1)
            {
                Console.WriteLine("One city has removed : " + remove);
            }

            Console.WriteLine("Count of cities1 : " + cities1.Count);


            MyList<string> cities2 = new MyList<string>();
            cities2.Add("Ankara");
            cities2.Add("Ankara");
            cities2.Add("Ankara");
            cities2.Add("Ankara");
            cities2.Add("Ankara");
            cities2.Add("Ankara");
            cities2.Add("Ankara");
            Console.WriteLine(cities2.Count);

            

        }
    }

    class MyList<T> // Generic Class
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }

        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length - 1] = item; 
        }
       
              
        public int Count
        {
            get { return _array.Length; }
            
        }

    }
}
