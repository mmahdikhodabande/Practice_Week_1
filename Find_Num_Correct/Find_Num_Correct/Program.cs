using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Num_Correct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Enter_num = 0;
            int Target_Num = 1;
            int Count = 5;
            bool correct = false;
            Console.Write("please enter num between 1 to 10 :  ");
            Enter_num = int.Parse(Console.ReadLine());
            if (Enter_num <= 10)
            {
                for (int i = 0; i < Count - 1; i++)
                {
                    Console.Write("please enter num between 1 to 10 :  ");
                    Enter_num = int.Parse(Console.ReadLine());
                    if (Enter_num == Target_Num)
                    {
                        correct = true;
                        break;
                    }
                }
                if (correct)
                {
                    Console.Write("*****your choeses is correct*****");
                }
                else
                {
                    Console.WriteLine($"you Chances is Down ! The num target is[ {Target_Num} ].");
                }
            }
            else
            {
                Console.WriteLine("the num input is invalide");
            }

            Console.ReadKey();
        }


       
    }
}
