using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTest.CSharp
{
    /// <summary>
    /// The code below has a code smell.  Can you describe what it is and how you would code about resolving it?
    /// </summary>
    class CodeSmell
    {
        public static void Run()
        {
            WriteOne();
            WriteTwo();
            WriteThree();
        }

        private static void WriteOne()
        {
            var city = "New Jersey";
            var state = "Newark";
            var name = "John Doe";
            var age = 30;

            Console.WriteLine($"{name} lives in {city}, {state} and he is {age} years old!");
        }

        private static void WriteTwo()
        {
            var city = "New Jersey";
            var state = "Atlantic City";
            var name = "Jane Doe";
            var age = 29;

            Console.WriteLine($"{name} lives in {city}, {state} and he is {age} years old!");
        }


        private static void WriteThree()
        {
            var city = "New Jersey";
            var state = "Paterson";
            var name = "Joe Bloggs";
            var age = 45;

            Console.WriteLine($"{name} lives in {city}, {state} and he is {age} years old!");
        }
    }
}
