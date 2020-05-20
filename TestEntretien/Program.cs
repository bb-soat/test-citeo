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
            TestLinq.MergeIndexAndRemoveDuplicate();

            Console.WriteLine("complete");
            Console.ReadLine();
        }
    }
}
