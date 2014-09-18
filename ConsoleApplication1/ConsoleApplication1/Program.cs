using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = ReadInt("Enter the amount of salaries you want to process: ");
            int Amount = ReadInt("Enter the amount of the salaries (kr): ");

        }
        static int ReadInt(string Prompt)
        {
            Console.Write(Prompt);
            int Newcount = int.Parse(Console.ReadLine());
            return Newcount;
        }
    }
}
