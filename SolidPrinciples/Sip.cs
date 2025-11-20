using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    public class Invoice
    {
        public void GenerateInvoice() => Console.WriteLine("Invoice Generated");

    }
    public class Database
    {
        public void SaveToDatabase() => Console.WriteLine("Invoice saved in Database");
    }

    public class Sending
    {
        public void SendEmail() => Console.WriteLine("Invoice sended via Email");
    }
}