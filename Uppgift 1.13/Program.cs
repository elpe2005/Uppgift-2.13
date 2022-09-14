using System;
namespace Uppgift_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Var snäll och skriv lönen av dina anställda. ");
            int lön = int.Parse(Console.ReadLine());
            int lön2 = lön + int.Parse(Console.ReadLine());
            int lön3 = lön2 + int.Parse(Console.ReadLine());
            Console.WriteLine(lön3);

        }
    }
}