using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Worker
{
    abstract class BaseWorker
    {
        protected int id;
        protected String name;
        protected SalaryType salaryType;
        protected Double salaryValue;

        public abstract Double CalcMounthSalary();

        public byte[] ToByteArray()
        {
            byte[] byteArray;//створює загальний байтовий масив
            //Convert.
            byte[] idBytes = BitConverter.GetBytes(id);//заганяє в байтовий масив id, зконвертувавши його
            byte[] nameBytes = nameToBytes();//заганяє в байтовий масив ім'я
            byte[] suluryBytes = SalaryTyByteArray(salaryValue);

            byteArray = idBytes;//заганяє в загальний байтовий масив байтовий масив з id
            byteArray = nameBytes;//заганяє в загальний байтовий масив байтовий масив з імя'м
            byteArray = suluryBytes;//заганяє в загальний байтовий масив байтовий масив з зарплатою
            

            return byteArray;
        }

        private byte[] nameToBytes()
        {
            byte[] bytes = new byte[name.Length];
            for (int i = 0; i < name.Length; i++)
            {
                bytes[i] = Convert.ToByte(name[i]);
            }

            return bytes;
        }

        /*private byte[] int32ToByteArray(int value)
        {
            //byte[] byteArray = new Byte[4];
            //byteArray[0] = Convert.ToByte(value);
            //Byte.Parse(
            //value << 8;
            //value.ToString(
            
            //return byteArray;
            return null;
        }*/

        private byte[] SalaryTyByteArray(double value)
        {
            byte[] byteArray;
            byteArray = BitConverter.GetBytes(value);
            return byteArray;
        }

       public int Id
        {
            get
            {
                return id;
            }
        }

       public String Name
       {
           get
           {
               return name;
           }

       }

       public SalaryType SalaryType
       {
           get
           {
               return salaryType;
           }
       }


       public Double SalaryValue
       {
           get
           {
               return salaryValue;
           }
           /*set
           {
               salaryValue = value;
           }*/
       }

    }

    enum SalaryType
    {
        HOUR,
        MOUNTH
    }
}
