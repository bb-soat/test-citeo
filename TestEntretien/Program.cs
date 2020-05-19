using System;

namespace TestEntretien
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("starting..");
            TestAlgo.RemoveDuplicate();
            TestLinq.FindCharWithMaxOccurence();      
            TestLinq.Anagramme();      

            Console.WriteLine("complete");
            Console.ReadLine();
        }
    }
}
