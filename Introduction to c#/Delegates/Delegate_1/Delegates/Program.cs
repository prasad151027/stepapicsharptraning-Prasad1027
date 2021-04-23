using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void HelloFunctionDelegate(string Mesage);
    class Program
    {
        public static void Hello(string strMessaage)
        {
            Console.WriteLine(strMessaage);
        }
        static void Main(string[] args)
        {
            //A delegate is a type safe function
            //Singanature of Delegates should match the Signatureof the Function

            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);  //Instance of Delegate
            del("Hello From Delegates...");

        }
    }
}
