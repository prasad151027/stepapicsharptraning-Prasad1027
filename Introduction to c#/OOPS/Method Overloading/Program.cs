using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    public class Employee
    {
        public string name;
        public float salary;
        public static string company = "Sails Software solutions";
        public Employee(string name,float salary)
        {
            this.name = name;
            this.salary = salary;
        }
        public void address(string village,string mandal)
        {
            Console.WriteLine("Name:{0}\n Salary:{1}\n Company:{2}\n village:{3}\n mandal:{4}\n ", name, salary,company, village, mandal);
        }
        public void address(string village,string mandal,string dist)
        {
            Console.WriteLine("Name:{0}\n Salary:{1}\n Company:{2}\n village:{3}\n mandal:{4}\n District:{5}\n ", name, salary,company,village, mandal,dist);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {

            Employee e1 = new Employee("Prasad" ,30000.00f);
            Employee e2 = new Employee("Mohan", 25000.00f);
            e1.address("Rana", "Jalumuru");
            e2.address("Undi", "Bheemavarm", "West Godavari");



        }
    }
}
