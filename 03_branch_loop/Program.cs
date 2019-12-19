using System;

namespace _03_branch_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 6;
            if (a < b)
            {
                Console.WriteLine($"The {a} is less than {b}");
            }
            else
                Console.WriteLine($"The {a} is grater than {b}");
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"The counter is {counter}");
                counter++;
            }
            int counter1 = 0;
            do
            {
                Console.WriteLine($"The counter1 is {counter1}");
                counter1++;
            } while (counter1 < 10);

            for (int counter2 = 0; counter2 < 10; counter2++)
            {
                Console.WriteLine($"The counter2 is {counter2}");
            }
            int sum = 0;
            for (int num = 1; num < 21; num++)
            {
                if (num % 3 == 0)
                {
                    sum += num;
                }
            }
            Console.WriteLine($"The sum is {sum}");
        }
        /*
            The 5 is less than 6
            The counter is 0
            The counter is 1
            The counter is 2
            The counter is 3
            The counter is 4
            The counter is 5
            The counter is 6
            The counter is 7
            The counter is 8
            The counter is 9
            The counter1 is 0
            The counter1 is 1
            The counter1 is 2
            The counter1 is 3
            The counter1 is 4
            The counter1 is 5
            The counter1 is 6
            The counter1 is 7
            The counter1 is 8
            The counter1 is 9
            The counter2 is 0
            The counter2 is 1
            The counter2 is 2
            The counter2 is 3
            The counter2 is 4
            The counter2 is 5
            The counter2 is 6
            The counter2 is 7
            The counter2 is 8
            The counter2 is 9
            The sum is 63
        */
    }
}