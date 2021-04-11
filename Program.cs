using System;

namespace ConsoleMatrix
{
    class Program
    {
        static void Main()
        {
            int timesMatrix = 0;
            var rand = new Random();
            bool matrixIsOn = true;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Insert a name for the MATRIX: ");
            char[] name = Console.ReadLine().Trim().ToCharArray();

            while (matrixIsOn)
            {
                timesMatrix++;
                int qtdToDisplay = rand.Next(name.Length, name.Length * rand.Next(2, 11));
                for (int i = 0; i < qtdToDisplay; i++) Console.Write($"{name[rand.Next(name.Length)]}");
                Console.Write("\n");

                if (timesMatrix == 999999)
                {
                TimesMade:
                    Console.WriteLine($"\nHEY YOU MADE A MATRIX {timesMatrix} TIMES !\n\nDo you want to stop ?\n\n1. Yes / 2. No / 3. NEVER !\n");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            matrixIsOn = false;
                            break;

                        case "2":
                        case "3":
                            break;

                        default:
                            goto TimesMade;
                    }
                }
            }
        }
    }
}
