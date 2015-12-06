using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Worker
{
    class MounthWorker : BaseWorker
    {
        public MounthWorker(int Id, String name, Double salaryValue)
        {
            this.id = Id;
            this.name = name;
            this.salaryType = SalaryType.MOUNTH;
            this.salaryValue = salaryValue;
        }

        override public Double CalcMounthSalary()
        {
            return salaryValue;
        }

    }
}
