using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Shape
    {
        public virtual void draw()
        {
            Console.WriteLine("drawing...");
        }
    }
    public class Rectangle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("drawing rectangle...");
        }

    }
    public class Circle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("drawing circle...");
        }

    }
    /* public class Animal
     {
         public virtual void eat()
         {
             Console.WriteLine("eating...");
         }
     }
     public class Dog : Animal
     {
         public override void eat()
         {
             Console.WriteLine("eating bread...");
         }

     }*/
    class Program
    {
        static void Main(string[] args)
        {
            /*Animal a = new Dog();
            a.eat();*/
            Shape s;
            s = new Shape();
            s.draw();
            s = new Rectangle();
            s.draw();
            s = new Circle();
            s.draw();
        }
    }
}
