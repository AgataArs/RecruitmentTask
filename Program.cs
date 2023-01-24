using System;
using System.IO;


namespace RecruitmentTask
{
    internal class Program

    {
        public const int LowerLimit = 10;
        public const int UpperLimit = 100;
        
        static void Main(string[] args)
        {

            var sum = 0;
            var iterationsNumber = GetIterationsNumber();
            
            using (var streamWriter = new StreamWriter("log.txt", false))
            {
                for (int i = 1; i <= iterationsNumber; i++)
                {
                    if (i % 2 != 0)
                    {
                        streamWriter.WriteLine(i);
                        sum += i;
                    }
                }
                streamWriter.Close();
            }

            Console.WriteLine($"Wynik: {sum}");
            Console.ReadLine();
        }

        static int GetIterationsNumber()
        {
            string input;
            int iterationsNumber = 0;

            while (iterationsNumber < LowerLimit || iterationsNumber > UpperLimit)
            {
                Console.WriteLine("Proszę podać nr od 10 do 100:" );
                input = Console.ReadLine();
                int.TryParse(input, out iterationsNumber);
            }

            return iterationsNumber;
        }


    }
}
