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
            do
            {
                int count = ReadInt("Enter the amount of salaries you want to process: ");
                Console.WriteLine(count);

                if (count >= 2)
                {
                    ProcessSalaries(count);  //om nu count är mindre än 2 så kommer else att skriva ut texten med felmeddelande och be personen skriva ut antal igen som är lika med 2 eller mer!
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Not a valid amount of salaries please try again! Must be more than 2");
                    Console.ResetColor();

                    Console.WriteLine();

                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Press any key to continue or press ESC to Close!");
                    Console.ResetColor();
                }
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);  // här använder vi oss av en do/while där vi avslutar med en tangent och avsluta med escape knappen!
        }
             
                
        static int ReadInt(string Prompt)
        {
            Console.Write(Prompt);
            int NewValue = int.Parse(Console.ReadLine());  //här skrivs det i static void längst upp in
            return NewValue;
        }
        static void ProcessSalaries(int count)
        {
            int MedianOne;
            int MedianTwo;
            int Median;
            int[] Salaries = new int[count];  // nu ska personen skriva in alla löner
            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter salary nr  : ");
                Salaries[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\n");

            Array.Sort(Salaries);

            if (count % 2 == 0)
            {
                MedianOne = count / 2;
                MedianTwo = MedianOne - 1;

                Median = (Salaries[MedianOne] + Salaries[MedianTwo]) / 2;

                Console.WriteLine("The median is: {0:c}", Median);

            }
            else
            { 
                Median = count / 2;
                Console.WriteLine("The median is: {0:c}", Salaries[Median]);
            }
            
            //foreach (int Element in i ) Console.Write(Element + " ");  //Skriver arrayen, Antal beror på inskrivet antal i count! i ordning!
            //{
            //    Console.WriteLine();
            //}



        }
    }
}
