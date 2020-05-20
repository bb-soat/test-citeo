using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestEntretien
{
    public class TestLinq
    {        
        public static void FindCharWithMaxOccurence()
        {
            List<string> input = new List<string>()
            {
                "aabccccc",
                "ddflfccccc"
            };

            
            var output = input.SelectMany(word => word).GroupBy(
                letter => letter,
                (letter, letters) => new
                {
                    Key = letter,
                    Count = letters.Count()
                });

            var result = output.OrderByDescending(o => o.Count).FirstOrDefault();
            
            Console.WriteLine("{0} win", result);

        }

        public static void Anagramme()
        {
            string[] input = { "reza", "eat", "tea", "tan", "ate", "nat", "bat", "bta", "azer" };

            var output = input.ToLookup(word => String.Concat(word.OrderBy(letter => letter)), word => word);

            // Show result
            foreach (IGrouping<string, string> group in output)
            {
                Console.WriteLine(group.Key);
                foreach (string str in group)
                    Console.WriteLine("    {0}", str);
            }
        }

        public static void MergeIndexAndRemoveDuplicate()
        {
            /* RESULTAT ATTENDU
            * 
            * Dictionary<string, List<int>> c = new Dictionary<string, List<int>>()
           {

               {"a", {1} },{"b", {45} }, {"c",{45,22,30} }
           };
           */

            List<Dictionary<string, int>> input = new List<Dictionary<string, int>>()
            {
                new Dictionary<string, int>()
                {
                    {"a",1 },{"b",20},{"c",45}
                },
                new Dictionary<string, int>()
                {
                    {"a",10 },{"c",22},{"b",45}
                },
                new Dictionary<string, int>()
                {
                    {"a",10 },{"c",30},{"b",20}
                }
            };

            var output = input.SelectMany(dico => dico.ToList())
                .Where(kv => input.Count(dic => dic[kv.Key] == kv.Value) == 1)
                .GroupBy(kv => kv.Key)
                .ToDictionary(kv => kv.Key);

            foreach (var item in output)
            {
                Console.WriteLine($"{item.Key}: {String.Join(", ", item.Value)}");
            }
            
        }
            
        

        }
    }
