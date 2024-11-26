using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Odd_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Sum_Odd = 0;
            Console.Write("please enter num : ");
            int Enter_Num = int.Parse(Console.ReadLine());
            while (Enter_Num>1)
            {
                for (int i = 1; i < Enter_Num + 1; i++)
                {
                    int CalCute = i % 2;
                    if (CalCute == 1)
                    {
                        Sum_Odd += i;
                    }
                }
                Console.WriteLine($"the sum odd your num is = {Sum_Odd}");
                Sum_Odd = 0;
                Console.Write("please enter num : ");
                Enter_Num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("the num is Incorrect !!");
            Console.ReadKey();
        }
    }
}
