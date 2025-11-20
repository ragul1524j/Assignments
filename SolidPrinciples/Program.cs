using System;

namespace SolidPrinciples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n------ SRP ------");
            RunSRP();
            Console.WriteLine("\n------ OCP ------");
            RunOCP();
            Console.WriteLine("\n------ LSP ------");
            RunLSP();
            Console.WriteLine("\n------ ISP ------");
            RunISP();
            Console.WriteLine("\n------ DIP ------");
            RunDIP();
        }
        static void RunSRP()
        {
            Invoice invoice = new Invoice();
            invoice.GenerateInvoice();

            Database database = new Database();
            database.SaveToDatabase();

            Sending sending = new Sending();
            sending.SendEmail();
        }
        static void RunOCP()
        {
            DiscountService discountService = new DiscountService();

            decimal vipDiscount = discountService.ApplyDiscount(new VipType());
            decimal employeeDiscount = discountService.ApplyDiscount(new EmployeeType());

            Console.WriteLine($"VIP discount is: {vipDiscount}");
            Console.WriteLine($"Employee discount is: {employeeDiscount}");
        }
        static void RunLSP()
        {
            Employee emp1 = new PermanentEmployee { Empid = 1, Empname = "Keerthu", EmpDept = 101 };
            Employee emp2 = new ContractEmployee { Empid = 2, Empname = "Sanjay", EmpDept = 102 };
            decimal salary = 5000m;

            Console.WriteLine($"{emp1.Empname} Bonus: {emp1.GetBonus(salary)}");
            Console.WriteLine($"{emp2.Empname} Bonus: {emp2.GetBonus(salary)}");
        }
        static void RunISP()
        {
            IWorker worker = new Worker();
            IEat workerEat = new Worker();
            IWorker managerWork = new Manager();
            IEat managerEat = new Manager();
            IManager managerControl = new Manager();

            Console.WriteLine("-----Worker-----");
            worker.Work();
            workerEat.Eat();

            Console.WriteLine("\n-----Manager-----");
            managerWork.Work();
            managerEat.Eat();
            managerControl.ManageTeams();
        }
        static void RunDIP()
        {
            IDatabase db = new SqlDatabase();
            OrderProcessor orderProcessor = new OrderProcessor(db);
            orderProcessor.Process();
        }
    }
}