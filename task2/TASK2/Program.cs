using System;

namespace TASK2
{
    class Program
    {
        static void Main(string[] args)
        {
            string month;
            Console.WriteLine("Ay daxil edin");
            month = Console.ReadLine();

            switch (month)
            {
                case "yanvar":
                case "mart":
                case "may":
                case " iyul":
                case "avqust":
                case "oktyabr":
                case "dekabr":
                    Console.WriteLine("bu ayda 31 gun var");
                    break;

                case "aprel":
                case "iyun":
                case "sentyabr":
                case "noyabr":
                    Console.WriteLine("bu ayda 30 gun var");
                    break;

                case "fevral":
                    Console.WriteLine("bu ayda ya 28 ya da 29 gun ola biler");
                    break;

                default:
                    Console.WriteLine("bele bir ay yoxdur");
                    break;

            }
        }
    }
}
