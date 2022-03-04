using System;

namespace TASK1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 1; i < 874; i++)
            {
                if (i%7==0)
                {
                    count++;
                }
            }
            Console.WriteLine("sayi:" + count);
        }
    }
}
