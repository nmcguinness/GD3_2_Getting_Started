/// <summary>
/// Project to demonstrate core C# concepts created in Week 2 including:]
/// 1) What is a namespace?
/// 2) Static (class) vs non-static (instance) methods
/// 3) Creating a MathUtility
/// 4) Using Random() to generate a GetRandInRange
/// 5) Solving get GetRandInRangeExcl
///
/// 
/// </summary>
/// 
using GDLibrary.Utility;
using System;

namespace GDLibrary
{
    class Program
    {
        public void GetIt() => Console.WriteLine("sdsdfsfd");

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Start();
        }

        void Start() //non-static or instance method
        {
            #region Print Demo

            //value types (pass by copy)
            int x = 10;
            double y = 20;
            Print(x, y);
            Console.WriteLine($"{x} and {y}");

            #endregion

            #region GetRandInRange Demo
            for (int i = 1; i <= 10; i++)
            {
                int randNum = MathUtility.GetRandInRange(5, 10);
                Console.WriteLine(randNum);
            } 
            #endregion

        }

        /// <summary>
        /// Simple method to demonstrate that value types are passed by copy
        /// and so changing the value INSIDE the method does not affect the variable
        /// values passed from OUTSIDE the method
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        void Print(int a, double b)
        {
            a = -10;
            b = 1E6; //1000000
            Console.WriteLine($"{a} and {b}");
            //Console.WriteLine(a + " and " + b);
        }
    }
}
