using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface Animal
    {
        void eat();
        void color();
    }
    public class Dog : Animal
    {
        public void eat()
        {
            Console.WriteLine("Eating Bone");
        }
        public  void color()
        {
            Console.WriteLine("Color is Black");
        }
    }
    public class Cat : Animal
    {
        public void eat()
        {
            Console.WriteLine("Eating bread");
        }
        public void color()
        {
            Console.WriteLine("color is white");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal a;
            a = new Dog();
            a.eat();
            a.color();
            a = new Cat();
            a.eat();
            a.color();
        }
    }
}
