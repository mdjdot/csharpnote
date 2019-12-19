using System;

namespace _02_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 6;
            int c = a + b;
            Console.WriteLine(c);
            c = a - b;
            Console.WriteLine(c);
            c = a * b;
            Console.WriteLine(c);
            c = a / b;
            Console.WriteLine(c);
            c = a % b;
            Console.WriteLine(c);
            int d = a + b * c;
            Console.WriteLine(d);
            d = (a + b) * c;
            Console.WriteLine(d);
            d = (a + b) - 6 * c + 12 * 4 / 3 + 12;
            Console.WriteLine(d);

            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");
            int flow = max + 3;
            if (flow == min + 2)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            double aa = 5;
            double bb = aa / 4;
            Console.WriteLine(aa);
            Console.WriteLine(bb);
            decimal cc = 3.2M;
            decimal dd = 4.5M;
            Console.WriteLine($"{cc} {dd}");
            double radius = 2.50;
            double area = Math.PI * radius * radius;
            Console.WriteLine(area);
        }
        /*
            23
            11
            102
            2
            5
            47
            115
            21
            The range of integers is -2147483648 to 2147483647
            True
            5
            1.25
            3.2 4.5
            19.634954084936208
        */
    }
}
