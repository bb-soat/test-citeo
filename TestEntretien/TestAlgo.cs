﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace TestEntretien
{
    public class TestAlgo
    {

        /// <summary>
        /// grouper les anagrammes 
        /// 10 min
        /// </summary>
        public static void RemoveDuplicate()
        {
            Console.WriteLine("RemoveDuplicate start");
            List<List<int>> datas = new List<List<int>>()
            {
                new List<int>() { 1,2,3,4,5,6,7,8,9},
                new List<int>() { 6,10,11,8,13,14,15,23},
                new List<int>() { 6,23,7,8},
                new List<int>() { 2,50,100,88},
            };

            var duplicates = datas.SelectMany(n => n).ToList();
            var uniques = duplicates.Distinct().ToList();
            uniques.ForEach(n => duplicates.Remove(n));

            Console.WriteLine("duplicates: {0}", string.Join(',', duplicates));

            Console.WriteLine("result: ");
            for (var i = 0; i < datas.Count; i++)
            {
                datas[i].RemoveAll(n => duplicates.Contains(n));
                Console.WriteLine(string.Join(',', datas[i]));
            }
        }
    }
}
