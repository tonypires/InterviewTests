using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTest
{
    /// <summary>
    /// Implement the UniqueNames method.  When pased two arrays of names, it will return an array containing the names that appear in either or both
    /// arrays.  The returned array should have no duplicates.
    /// 
    /// For example:  calling MergeNames.UniqueNames(new string[] { "Jack", "John" }, new string[] { "Jack", "Paul" }) should return 
    /// an array containing:  Jack, John and Paul in any order.
    /// </summary>

    class UniqueNames
    {
        public static string[] UniqueNames(string[] names1, string[] names2)
        {
            throw new NotImplementedException();
        }

        public static void Run()
        {
            string[] names1 = new string[] { "Mark", "Lauren", "Paul" };
            string[] names2 = new string[] { "Paul", "Sophia", "Lauren" };
            Console.WriteLine(string.Join(", ", UniqueNames(names1, names2))); // should print Mark, Lauren, Paul, Sophia
        }
    }
}
