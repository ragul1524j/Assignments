using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_Approach_15_12_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CRUD crud = new CRUD();
            //crud.InsertNewEmployee();
            //crud.ShowEmployee();
            //crud.UpdateEmployee();
            //crud.DeleteEmployee();
            //crud.EmpBonusDetails();
            //crud.GetEmployeeByDepartment();
            crud.SumOfDepartment();

            Console.ReadLine();
        }
    }
}
