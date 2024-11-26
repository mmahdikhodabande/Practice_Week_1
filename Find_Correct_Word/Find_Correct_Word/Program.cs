using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Correct_Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please write the word foe sinc the hidden word system : ");
            string User_word = Console.ReadLine();
            string Target_word = "csharp";
            int Count = 0;

            while (Target_word != User_word)
            {
                Console.Write("Please write the word foe sinc the hidden word system : ");
                User_word = Console.ReadLine();
                Count++;
            }
            Console.WriteLine("******** congratulations ! your word is sinc the hidden word system. ********");
            Console.WriteLine($"Your repetition times are : {Count}");
            Console.ReadKey();
        }
        
    }
}
