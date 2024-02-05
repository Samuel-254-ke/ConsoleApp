using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good evening");
            char symbol = 'a';
            string name = "samuel";
            string username = symbol + name;

            Console.WriteLine("Your symbol is " + symbol);
            Console.WriteLine("Your username is " + username);

            int a = 321;
            double c = Convert.ToDouble(a) + 0.998;
            string d = "#";
            char e = Convert.ToChar(d);

            Console.WriteLine(c);
            Console.WriteLine(c.GetType());
            Console.WriteLine(e);
            Console.WriteLine(e.GetType());

            Console.WriteLine("Enter your first name:");
            string fname = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Good evening " + fname + ". You are " + age + " years.");
        }
            
    }
}
