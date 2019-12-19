using System;
using System.Collections.Generic;
namespace _04_list
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "name", "Ana", "Felipe" };
            foreach (var name in names)
            {
                System.Console.WriteLine($"Hello {name.ToUpper()}");
            }
            System.Console.WriteLine();
            names.Add("maria");
            names.Add("Bill");
            names.Remove("Ana");
            foreach (var name in names)
            {
                System.Console.WriteLine($"Hello {name.ToUpper()}");
            }
            System.Console.WriteLine($"My name is {names[3]}");
            System.Console.WriteLine($"The list has {names.Count} name");

            var index = names.IndexOf("Bill");
            System.Console.WriteLine($"The name {names[index]} is at index {index}");
            var notFound = names.IndexOf("Not Found");
            System.Console.WriteLine($"When an item is not found, IndexOf return {notFound}");
            names.Sort();
            foreach (var name in names)
                System.Console.WriteLine($"Hello {name.ToUpper()}");

            var numList = new List<int> { };
            for (int i = 0; i < 20; i++)
            {
                if (i < 2)
                {
                    numList.Add(1);
                }
                else
                {
                    numList.Add(numList[i - 2] + numList[i - 1]);
                }
                System.Console.WriteLine(numList[i]);
            }
        }
        /*
            Hello NAME
            Hello ANA
            Hello FELIPE
            Hello NAME
            Hello FELIPE
            Hello MARIA
            Hello BILL
            My name is Bill
            The list has 4 name
            The name Bill is at index 3
            When an item is not found, IndexOf return -1
            Hello BILL
            Hello FELIPE
            Hello MARIA
            Hello NAME
            1
            1
            2
            3
            5
            8
            13
            21
            34
            55
            89
            144
            233
            377
            610
            987
            1597
            2584
            4181
            6765
         */
    }
}
