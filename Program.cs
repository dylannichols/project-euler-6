using System;

namespace project_euler_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            var sumSquare = 0;
            for (int i = 0; i <= 100; i++)
            {
               sum += i;
               sumSquare += (i*i);
            }
            Console.WriteLine("The answer is: "+ ((sum*sum) - sumSquare));
            Console.WriteLine(sumSquare);
            Console.WriteLine(sum^2);
        }
    }
}
