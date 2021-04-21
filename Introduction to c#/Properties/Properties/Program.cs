using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        public class student
        {
            public int ID;
            public string Name;
            public int PassMark = 35;
        }
        static void Main(string[] args)
        {
            student c1 = new student();
            c1.ID = -101;
            c1.Name = null;
            c1.PassMark = 0;
            Console.WriteLine("ID={0} && Name={1} && PassMark={2}", c1.ID, c1.Name, c1.PassMark);
        }
    }
}
