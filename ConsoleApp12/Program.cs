using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Information input");
            Console.WriteLine("What is your first name");
            string name = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string last = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello, " + name + " " + last + "! You are " + age + " years old and your favorite color is " + color + ".");
            Console.ReadLine();
        }
    }
}
