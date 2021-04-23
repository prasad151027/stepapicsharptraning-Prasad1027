using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee() { ID = 101, Name = "Marry", Salary = 5400, Experience = 5 });
            emplist.Add(new Employee() { ID = 101, Name = "Mike", Salary = 4000, Experience = 4 });
            emplist.Add(new Employee() { ID = 101, Name = "John", Salary = 6000, Experience = 6 });
            emplist.Add(new Employee() { ID = 101, Name = "Todd", Salary = 3000, Experience = 3 });

            //IsPromotable isPromotable = new IsPromotable(Promote);

            Employee.PromoteEmployee(emplist,emp => emp.Experience>=5);
        }
        //public static bool Promote(Employee emp)
        //{
        //    if (emp.Experience >= 5)
        //    {
        //        return true;
        //
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
    delegate bool IsPromotable(Employee empl);
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float Salary { get; set;}
        public int Experience { get; set; }
        public static void PromoteEmployee(List<Employee> employeelist, IsPromotable IsEligibleToPromote)
        {
             foreach(Employee employee in employeelist)
            {
                //if (employee.Experience >= 5)
                if(IsEligibleToPromote(employee))
                {
                    Console.WriteLine(employee.Name + " promoted ");
                }
            }
        }
        

    }
}
