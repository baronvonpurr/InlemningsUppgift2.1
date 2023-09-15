using System;

namespace InlämningsUppgift2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilken är din favorit bok?");
            string favvisbok = Console.ReadLine();
            Console.WriteLine(favvisbok);
            Console.ReadKey();
        }
    }
}