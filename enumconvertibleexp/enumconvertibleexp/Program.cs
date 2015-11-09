using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace enumconvertibleexp
{

    enum Color
    {
        Yellow,
        Blue,
        Green
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] names;
            names = Color.GetNames(typeof(Color));
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }

}
