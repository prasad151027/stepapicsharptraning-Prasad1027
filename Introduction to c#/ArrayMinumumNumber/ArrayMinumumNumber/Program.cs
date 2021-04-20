using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMinumumNumber
{
    public class Program
    {
        public int PrintMin(int[] arr)
        {
            int minimum=arr[0];
            foreach(int i in arr)
            {
                if(minimum > i)
                {
                    minimum = i;
                }
                
            }
            return minimum;
        }
        static void Main(string[] args)
        {
            int[] arr1 = { 10, 3, 2, 5, 6, 0, 6 };
            Program obj = new Program();
            int num=obj.PrintMin(arr1);
            Console.WriteLine("Minimum Number is:"+num);

        }
    }
}
