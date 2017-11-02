using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Cat
    {

        public string Name = string.Empty;
        public int Age = 0;

        public void Hiss()
        {
            Console.WriteLine("Hiss");
        }

        public static void Meow()
        {
            Console.WriteLine("Meow");
        }

        public int GetAge()
        {
            return Age;
        }

        public void SetAge(int nAge)
        {
            Age = nAge;
        }

        /// <summary>
        /// Lets get Funky
        /// </summary>
        /// <param name="Time">The number of times to perform</param>
        /// <param name="Action">The action to perform</param>
        public void Funky(int Time, string Action)
        {
            for (int i = 0; i < Time; i++)
            {
                Console.WriteLine(Action + " " + i + " times");
            }
        }
    }
}
