using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    public interface IDatabase
    {
        void Save();
    }

    public class SqlDatabase : IDatabase
    {
        public void Save()
        {
            Console.WriteLine("Saving to SQL");
        }
    }

    public class OrderProcessor
    {
        private readonly IDatabase Database;

        public OrderProcessor(IDatabase database)
        {
            Database = database;
        }

        public void Process()
        {
            Database.Save();
        }
    }
}