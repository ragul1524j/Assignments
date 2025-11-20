using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    public interface IWorker
    {
        void Work();
    }

    public interface IEat
    {
        void Eat();
    }

    public interface IManager
    {
        void ManageTeams();
    }

    public class Worker : IWorker, IEat
    {
        public void Work()
        {
            Console.WriteLine("Worker is working");
        }

        public void Eat()
        {
            Console.WriteLine("Worker is eating");
        }
    }
    public class Manager : IWorker, IEat, IManager
    {
        public void Work()
        {
            Console.WriteLine("Manager is working");
        }

        public void Eat()
        {
            Console.WriteLine("Manager is eating");
        }

        public void ManageTeams()
        {
            Console.WriteLine("Manager is managing the team");
        }
    }

}
