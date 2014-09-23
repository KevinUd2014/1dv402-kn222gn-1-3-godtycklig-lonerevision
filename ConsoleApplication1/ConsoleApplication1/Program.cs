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
                Console.Clear();
                int count = ReadInt("Enter the amount of salaries you want to process: ");
                Console.Write("\n");


                if (count > 2)
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
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }  // här använder vi oss av en do/while där vi avslutar med en tangent och avsluta med escape knappen!
            
        
        static int ReadInt(string Prompt)
        {
            
           while(true)
           {    
            Console.Write(Prompt);
            string input = Console.ReadLine();
            try
            {
                int NewValue = int.Parse(input);  //Den här satsen refererar jag olika saker till den gör olika beroende på vad jag skickar till den!
                return NewValue;
            }

            catch
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("'{0}' is in wrong format!", input);
                Console.ResetColor();
            }

        }

        }
        static void ProcessSalaries(int count)
        {
            int MedianOne;                    // här har vi olika variablar som underlättar när jag räknar ut medianen då jag använder de två översta i "min" och "max".
            int MedianTwo;
            int Median;
            int[] unsortedSalaries = new int[count];  // här har vi en ny array där dom osorterade lönerna ska delas upp och sparas när man kopierar!
            int number = 0;
            int[] Salaries = new int[count];  // nu ska personen skriva in alla löner
            for (int i = 0; i < count; i++)
            {
                number += 1;
                Salaries[i] = ReadInt("Enter Salarie NR " + (i+1) + (": "));
                
            }

            Console.Write("\n");

            Array.Copy(Salaries, unsortedSalaries, count); // kopierar arrayen så att den sparas till senare!
            Array.Sort(Salaries);

            Console.WriteLine("-------------------------------------------");
            if (count % 2 == 0)
            {
                MedianOne = count / 2;  // här delar programmet antalet löner på 2 och tar ut dom två som finns i mitten! denna sats tar ut det höga talet i mitten!
                MedianTwo = MedianOne - 1; // sedan så tar denna sats ut det mindre talet i mitten!

                Median = (Salaries[MedianOne] + Salaries[MedianTwo]) / 2; // och här i det slutliga skedet så tar vi de båda mittentalen och plussar dem för att sedan dela det på två!

                Console.WriteLine("The median is:          {0,10:c0}", Median);

            }
            else
            { 
              Median = count / 2;
              Console.WriteLine("The median Salarie is:  {0,10:c0}", Salaries[Median]);
            }

              Salaries.Average();
              Console.WriteLine("The average salarie is: {0,10:c0}", Salaries.Average());
           

              Console.WriteLine("The diffrence is:       {0,10:c0} ", Salaries.Max() - Salaries.Min() );


              Console.WriteLine("-------------------------------------------");

              for (int i = 0; i < count; i++)  // här loopar vi if satsen i en for loop för att få så många rader som behövs därför används count!
              {
                  if (i % 3 == 0)  // här gör vi dock att varje gång modulus blir 0 så byter den rad, vilket är var tredje gång vilket resulterar i att det är 3 på varje rad.
                  {
                      Console.Write("\n");
                  }
                  Console.Write("{0,10}", unsortedSalaries[i]);
              }
              Console.WriteLine();

            
            
              Console.Write("\n");
              Console.BackgroundColor = ConsoleColor.Green;
              Console.ForegroundColor = ConsoleColor.Red;
              Console.WriteLine("Press any key for new calculation or ESC to close!");
              Console.ResetColor();

  
            }
    }
}
