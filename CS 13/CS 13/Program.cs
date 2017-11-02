using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //here

            Cat cCat = new Cat();
            cCat.Hiss();

            Cat.Meow();

            cCat.SetAge(18);
            Console.WriteLine(cCat.GetAge());

            cCat.Funky(8, "Jump");

            Console.Read();
        }
    }
}
