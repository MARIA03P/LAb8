using System;

namespace LAb8
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double z = Convert.ToDouble(Console.ReadLine());
            double func = 1 / 3.0 + 2 * y / 7.0 - z / 2.0 + Math.Min(z, x);
            for (int i = 0; i < 10; i++)
                Console.WriteLine(func);
                
            
        }
    }
}
