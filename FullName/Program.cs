using System;

namespace FullName
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja käest eesnime
            //programm küsib kasutaja käest perekonna nime
            //programm tervitab kasutajat kasutades neid andmeid
            Console.WriteLine("What is your first name");
            string firstname = Console.ReadLine();

            Console.WriteLine($"Hello, {firstname}!");
            Console.WriteLine($"What is your last name?");
            string lastname = Console.ReadLine();
            Console.WriteLine($"Pleasure to meet you {firstname} {lastname}");
            Console.WriteLine($"How old are you {lastname}");                                


            Console.Read();
        }
    }
}
