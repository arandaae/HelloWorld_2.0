using System;


namespace HelloWorld_2._0
{
    class Program
    {
        static void Main()
        {
            string name = "";
            string age = "";

            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine("Hello " + name);
            Console.ReadLine();

            Console.WriteLine("How old are you: ");
            age = Console.ReadLine();

            Console.WriteLine($"You are {age} years old.");
            Console.ReadLine();




        }
    }
}
