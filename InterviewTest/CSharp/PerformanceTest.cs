using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace InterviewTest
{
    /// <summary>
    /// The FindMatches method takes two lists each containing integer values and compares the first list with the second and returns the amount of matches.
    /// The way these two lists are being compared with one another has a time complexity of O(n²).  Your task is to improve the performance of this 
    /// method.
    /// </summary>
    class PerformanceTest
    {
        public static void Run()
        {
            // Populate both lists with the same set of integers
            var listA = new List<int>();
            for (int i = 0; i < 100000; i++)
            {
                listA.Add(i);
            }

            var listB = new List<int>();
            for (int i = 0; i < 100000; i++)
            {
                listB.Add(i);
            }

            Console.WriteLine("Begin search...");

            // Measure the amount of time the FindMatches method takes to perform its task
            var watch = new Stopwatch();
            watch.Start();


            var matches = FindMatches(listA, listB);

            watch.Stop();
            Console.WriteLine($"{matches.Count} matches found in {watch.ElapsedMilliseconds}ms");
        }

        public static List<int> FindMatches(List<int> listA, List<int> listB)
        {
            var matches = new List<int>();

            for (int i = 0; i < listA.Count; i++) 
            {
                for (int x = 0; x < listB.Count; x++)
                {
                    if (listA[i] == listB[x])
                    {
                        matches.Add(i);
                        break;
                    }
                }
            }

            return matches;
        }
    }
}
