using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace RecruitmentTask
{
    internal class Program

    {
        const int lowerLimit = 10;
        const int upperLimit = 100;
        static public int iterationsNumber = 0;
        static void Main(string[] args)
        {

            StreamWriter sw = new StreamWriter("C:\\Users\\agata\\Desktop\\log\\log.txt", false, Encoding.ASCII);
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            

            var sum = 0;

            TakeNumberAndCheckLimits();

            for (int i = 1; i <= iterationsNumber; i++)
            {
                if (i % 2 != 0)
                {
                    sw.WriteLine(i);
                    sum += i;
                }
            }

            sw.Close();
            Console.WriteLine($"Result: {sum}");
            Console.ReadLine();
        }

        static void TakeNumberAndCheckLimits()
        {
            string chosenNumber;

            while (iterationsNumber < lowerLimit || iterationsNumber > upperLimit)
            {
                Console.WriteLine("Please give a number in range 10 to 100: ");
                chosenNumber = Console.ReadLine();
                Int32.TryParse(chosenNumber, out iterationsNumber);
            }
        }
    }
}
