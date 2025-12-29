using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_Approach_15_12_2025
{
    public class CRUD
    {

        // 1. Perform CRUD operations using Lambda expressions

        Model1 dc = new Model1();
        public void InsertNewEmployee()
        {
            try
            {
                List<Employee> employees = new List<Employee>()
{
    new Employee()
    {
        Empid = "E201",
        EmpName = "Arun",
        DepartmentName = "Developer",
        Salary = 45000,
        YearOfJoining = 2018
    },
    new Employee()
    {
        Empid = "E202",
        EmpName = "Karthik",
        DepartmentName = "Developer",
        Salary = 50000,
        YearOfJoining = 2017
    },
    new Employee()
    {
        Empid = "E203",
        EmpName = "Priya",
        DepartmentName = "HR",
        Salary = 42000,
        YearOfJoining = 2019
    },
    new Employee()
    {
        Empid = "E204",
        EmpName = "Meena",
        DepartmentName = "HR",
        Salary = 48000,
        YearOfJoining = 2016
    },
    new Employee()
    {
        Empid = "E205",
        EmpName = "Ravi",
        DepartmentName = "Support",
        Salary = 38000,
        YearOfJoining = 2021
    },
    new Employee()
    {
        Empid = "E206",
        EmpName = "Suresh",
        DepartmentName = "Support",
        Salary = 40000,
        YearOfJoining = 2020
    },
    new Employee()
    {
        Empid = "E207",
        EmpName = "Divya",
        DepartmentName = "Finance",
        Salary = 49000,
        YearOfJoining = 2015
    }
};


                dc.Employees.AddRange(employees);
                int res = dc.SaveChanges();
                Console.WriteLine($"Total Records Inserted is : {res}");
            }
            catch(Exception ex)
            {
                var res = dc.GetValidationErrors();
                foreach(var item in res)
                {
                    if(item.ValidationErrors.Count > 0)
                    {
                        foreach(var err in item.ValidationErrors)
                        {
                            Console.WriteLine(err.ErrorMessage);
                        }
                    }
                }
            }
        }

        public void ShowEmployee()
        {
            try
            {
                var res = from t in dc.Employees select t;
                foreach (var item in res)
                {
                    Console.WriteLine($"{item.Empid} : {item.EmpName} : {item.DepartmentName} : {item.Salary} : {item.YearOfJoining}");
                }
            }
            catch (Exception ex)
            {
                var res = dc.GetValidationErrors();
                foreach (var item in res)
                {
                    if (item.ValidationErrors.Count > 0)
                    {
                        foreach (var err in item.ValidationErrors)
                        {
                            Console.WriteLine(err.ErrorMessage);
                        }
                    }
                }
            }
        }


        public void UpdateEmployee()
        {
            try
            {
                string id;
                Console.Write("Enter the EmployeeID to Update : ");
                id = Console.ReadLine();
                var res = (from t in dc.Employees where t.Empid == id select t).FirstOrDefault();

                if (res != null)
                {
                    res.Salary = 45000;
                    dc.SaveChanges();
                    Console.WriteLine($"Updated Successfully");
                }
                else
                {
                    Console.WriteLine("Updation Failed");
                }
            }
            catch (Exception ex)
            {
                var res = dc.GetValidationErrors();
                foreach (var item in res)
                {
                    if (item.ValidationErrors.Count > 0)
                    {
                        foreach (var err in item.ValidationErrors)
                        {
                            Console.WriteLine(err.ErrorMessage);
                        }
                    }
                }
            }
        }


        public void DeleteEmployee()
        {
            try
            {
                string id;
                Console.Write("Enter the EmpId to Delete the Record : ");
                id = Console.ReadLine();
                var res = (from t in dc.Employees where t.Empid == id select t).FirstOrDefault();

                if(res != null)
                {
                    dc.Employees.Remove(res);
                    dc.SaveChanges();
                    Console.WriteLine("Employee Deleted Successfully");
                }
                else
                {
                    Console.WriteLine("Deletion Failed");
                }
            }
            catch (Exception ex)
            {
                var res = dc.GetValidationErrors();
                foreach (var item in res)
                {
                    if (item.ValidationErrors.Count > 0)
                    {
                        foreach (var err in item.ValidationErrors)
                        {
                            Console.WriteLine(err.ErrorMessage);
                        }
                    }
                }
            }
        }

        /* 2. Create a view in database which displays department Name ,sum of salary
 (department wise sum of salary) */


        public void SumOfDepartment()
        {
            try
            {
                var res = dc.Database.SqlQuery<DepartmentSalary>(
        "SELECT DepartmentName, SUM(Salary) AS TotalSalary FROM Employees GROUP BY DepartmentName"
    ).ToList();

                foreach (var item in res)
                {
                    Console.WriteLine($"{item.DepartmentName} : {item.TotalSalary}");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }




        /* 3. Create procedure which accepts department Name as a parameter and 
 display all employee of that department */
        public void GetEmployeeByDepartment()
        {
            try
            {
                Console.Write("Enter Department Name: ");
                string dept = Console.ReadLine();

                var res = dc.Database.SqlQuery<Employee>(
                    "EXEC  sp_EmployeeOnDepartment  @DeptName",
                    new SqlParameter("@DeptName", dept)
                ).ToList();

                if (res.Count > 0) {
                    foreach (var emp in res)
                    {
                        Console.WriteLine($"{emp.Empid} | {emp.EmpName} | {emp.DepartmentName} | {emp.Salary}");
                    }
                }
                else
                {
                    Console.WriteLine("Enter the Correct Department");
                }
            }
            catch (Exception ex)
            {
                var res = dc.GetValidationErrors();
                foreach (var item in res)
                {
                    if (item.ValidationErrors.Count > 0)
                    {
                        foreach (var err in item.ValidationErrors)
                        {
                            Console.WriteLine(err.ErrorMessage);
                        }
                    }
                }
            }
        }


        /* 4. Create Extension Method By Name EmpBonus( calculates 30% on salary
)and display all records along with bonus column */

        public decimal EmpBonus(Employee emp)
        {
            return emp.Salary * 0.30m;
        }

        public void EmpBonusDetails()
        {
            Console.WriteLine("\n\n");
            var res = from t in dc.Employees select t;

            foreach(var item in res)
            {
                Console.WriteLine($"{item.EmpName} : {item.Salary} : Bonus:{EmpBonus(item)}");
            }
            
        }
    }
}
