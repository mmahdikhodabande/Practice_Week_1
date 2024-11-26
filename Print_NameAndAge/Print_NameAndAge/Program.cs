using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_NameAndAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write your Name : ");
            string Name = Console.ReadLine();
            Console.Write("Write your Age : ");
            int Age = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Hello, {Name}. You are {Age} years old.");

            Console.ReadKey();
        }
    }
}
