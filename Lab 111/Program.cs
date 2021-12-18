using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lab11;

namespace Lab_111
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Мурка", "Рыжий", 1);
            cat.Say();
            Console.ReadKey();
        }
    }
}

