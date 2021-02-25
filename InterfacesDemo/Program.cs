using System;

namespace InterfacesDemo
{
    class Program
    {

        //SOLID, Interface Segregation
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Worker(),
                new Manager(),
                new Robot()

            };

            foreach (var worker in workers)
            {
                worker.Work();
            }


            IEat[] eats = new IEat[]
            {
                new Worker(),
                new Manager()
            };

            ISalary[] salary = new ISalary[]
            {
                new Manager(),
                new Worker()

            };
        }
    }

    interface IWorker
    {
        void Work();
        

    }

    interface IEat
    {
        void Eat();

    }

    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker, IEat, ISalary
    {
        public void Work()
        {
        }

        public void Eat()
        {
        }

        public void GetSalary()
        {
        }
    }

    class Worker : IWorker, IEat, ISalary
    {
        public void Work()
        {
        }

        public void Eat()
        {
        }

        public void GetSalary()
        {
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
        }
    }
}
