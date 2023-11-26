using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul._9
{
    public record Employee(string Name, int Age, int Salary)
    {
        public void GetInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Salary: {Salary}");
        }

        public decimal CalculateAnnualSalary()
        {
            return Salary * 12;
        }
    }

    public class Manager : Employee
    {
        public int Bonus { get; set; }

        public Manager(string name, int age, int salary, int bonus) : base(name, age, salary)
        {
            Bonus = bonus;
        }

        public new void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Bonus: {Bonus}");
        }

        public new decimal CalculateAnnualSalary()
        {
            return base.CalculateAnnualSalary() + Bonus;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("Aigerim", 20, 140000, 159000);
            manager.GetInfo();
            decimal annualSalaryWithBonus = manager.CalculateAnnualSalary();
            Console.WriteLine($"Annual Salary (With Bonus): {annualSalaryWithBonus}");
            Console.ReadKey();
        }
    }
}
