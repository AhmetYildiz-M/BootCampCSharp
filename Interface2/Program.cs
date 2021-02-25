using System;

namespace Interface2
{
    class Program
    {
        //Interface'ler new'lenemez.
        static void Main(string[] args)
        {
            //IPersonManager customerManager = new CustomerManager();
            

            //IPersonManager employeeManager = new EmployeeManager();

            ProjectManager projectManager = new ProjectManager();
            //projectManager.Add(customerManager);
            //projectManager.Update(customerManager);

            projectManager.Add(new InternManager());

        }
    }

    interface IPersonManager
    {
        //Unimplemented operation
        void Add();
        void Update();

    }

    //Inherits - class -------------- implements - interface
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //Musteri ekleme kodlari
            Console.WriteLine("Musteri Eklendi!!");
        }

        public void Update()
        {
            Console.WriteLine("Musteri Guncellendi!!");

        }
    }

   
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer Eklendi!!");

        }

        public void Update()
        {
            Console.WriteLine("Stajyer Guncellendi!!");

        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Musteri Eklendi!!");
        }

        public void Update()
        {
            Console.WriteLine("Calisan Guncellendi!!");

        }
        
    }
    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
            
        }

        public void Update(IPersonManager personManager)
        {
            personManager.Update();
        }

       
    }
}