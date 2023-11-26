using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul._9
{
    class Manager : Employee
    {
        public decimal Bonus { get; set; }
        public Manager(string name, int age, int Salary, decimal bonus)
            : base(name, age, Salary)
        {
            Bonus = bonus;
        }

        public override virtual decimal CalculateAnnualSalary()
        {
            decimal AnnualSalary = base.CalculateAnnualSalary();
            return AnnualSalary + Bonus;
        }
    }
}
