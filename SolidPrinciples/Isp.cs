using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    public interface IBonus
    {
        decimal GetBonus(decimal salary);
    }

    public abstract class Employee : IBonus
    {
        public int Empid { get; set; }
        public string Empname { get; set; }
        public int EmpDept { get; set; }

        public virtual decimal GetBonus(decimal salary)
        {
            return salary * 0.10m;
        }
    }

    public class PermanentEmployee : Employee
    {
        public override decimal GetBonus(decimal salary)
        {
            return salary * 0.20m;
        }
    }

    public class ContractEmployee : Employee
    {
        public override decimal GetBonus(decimal salary)
        {
            return 0m;
        }
    }
}