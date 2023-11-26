using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul._9
{
    class Developer :
    {
        public int LinesOfCodePerDay { get; set; }
        public Developer(string name, int age, int Salary, int linesOfCodePerDay)
            : base(name, age, Salary)
        {
            LinesOfCodePerDay = linesOfCodePerDay;
        }

        public override decimal CalculateAnnualSalary()
        {
            decimal baseAnnualSalary = base.CalculateAnnualSalary();

            decimal additionalSalary = LinesOfCodePerDay * 0.03m;

            return baseAnnualSalary + additionalSalary;
        }
    }
}
