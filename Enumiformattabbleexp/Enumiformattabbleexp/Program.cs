using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enumiformattabbleexp
{
    internal enum Color
    {
        Yellow,
        Green,
        Blue

    }
    
    
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Color.Format(typeof(Color),Color.Yellow,"X"));
            Console.WriteLine(Color.Format(typeof(Color),Color.Green,"d"));
        }
    }
}
