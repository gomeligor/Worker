using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Worker
{
    class HourWorker : BaseWorker
    {
        public HourWorker(int Id, String name, Double salaryValue)
        {
            this.id = Id;
            this.name = name;
            this.salaryType = SalaryType.HOUR;
            this.salaryValue = salaryValue;
        }

        override public Double CalcMounthSalary()// override використовується для перевизначення віртуального методу
        {
            return 20.8 * 8 * salaryValue;
        }

        

    }
}
