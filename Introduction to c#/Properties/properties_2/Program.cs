using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties_2
{
    public class employee
    {
        private string name;
        private static int counter;

        public employee()//Constructor 
        {
            counter++;  //if an objet is created then yhe counter will be incremented
        }

        public string Name //To access the Private string name outside the class
        {
            get      //Read the data member
            {
                return name;

            }
            set     //Write the  data member 
            {
                name = value + " Good Morning";

            }
        }
        public static int Counter
        {
            get
            {
                return counter;
            }

        }

    }  
    class Program
    {
        
        public static void Main(string[] args)
        {
            employee p1 = new employee();
            employee p2 = new employee();
            employee p3 = new employee();
            p1.Name = "Prasad";
            p2.Name = "Hari";
            p3.Name = "Mohan";
            Console.WriteLine("Employee:" + p1.Name);
            Console.WriteLine("Employee:" + p2.Name);
            Console.WriteLine("Employee:" + p3.Name);

            Console.WriteLine("No.of Employees:" + employee.Counter);

        }
    }
}
