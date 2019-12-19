using System;

namespace _01_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string aFriend = "Bill";
            Console.WriteLine(aFriend);
            aFriend = "Maira";
            Console.WriteLine(aFriend);
            Console.WriteLine($"Hello,{aFriend}");
            string firstFriend = "Maria";
            string secondFriend = "Sage";
            Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters");
            Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters");
            string greeting = "        Hello World!       ";
            Console.WriteLine($"[{greeting}]");
            string trimedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimedGreeting}]");
            trimedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimedGreeting}]");
            trimedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimedGreeting}]");

            string sayHillo = "Hello World!";
            Console.WriteLine(sayHillo);
            sayHillo = sayHillo.Replace("Hello", "Greating");
            Console.WriteLine(sayHillo);
            Console.WriteLine(sayHillo.ToUpper());
            Console.WriteLine(sayHillo.ToLower());

            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));
        }
        /*
            Maira
            Hello,Maira
            The name Maria has 5 letters
            The name Sage has 4 letters
            [        Hello World!       ]
            [Hello World!       ]
            [        Hello World!]
            [Hello World!]
            Hello World!
            Greating World!
            GREATING WORLD!
            greating world!
            True
            False
        */
    }
}
