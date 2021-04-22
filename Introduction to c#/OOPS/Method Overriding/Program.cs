using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overriding
{
    public class Animal
    {
        public string color = "White";
        public virtual void eat()
        {
            Console.WriteLine("eating");
        }
    }
    public class Dog : Animal
    {
        public string color = "Black";
        public  void bark()
        {
            Console.WriteLine("Barking");
        }
        public override void eat()
        {
            Console.WriteLine("Eating bread");

        }
        public void Showcolor()
        {
            Console.WriteLine("Base class color:"+ base.color);//base keyword is used to access the base class members
            Console.WriteLine("Derived class colr:"+color);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog d1 = new Dog();
            d1.eat();
            d1.bark();
            d1.Showcolor();
        }
    }
}
