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
using GDLibrary.Types;

namespace GDLibrary
{
    internal class Program
    {
        public void GetIt() => Console.WriteLine("sdsdfsfd");

        private static void Main(string[] args)
        {
            Program p = new Program();
            p.Start();
        }

        private void Start() //non-static or instance method
        {
            #region Print Demo

            //value types (pass by copy)
            int x = 10;
            double y = 20;
            Print(x, y);
            Console.WriteLine($"{x} and {y}");

            #endregion Print Demo

            #region GetRandInRange Demo

            for (int i = 1; i <= 10; i++)
            {
                int randNum = MathUtility.GetRandInRange(5, 10);
                Console.WriteLine(randNum);
            }

            #endregion GetRandInRange Demo

            #region Point2D Demo

            Point2D p1 = new Point2D(5, 20);
            p1.X = 25;
            Console.WriteLine(p1.X);
            Console.WriteLine(p1);

            #endregion Point2D Demo

            #region Clone Demo

            Integer3 myIntA = new Integer3(1, 2, 3);
            Integer3 cloneMyIntA = (Integer3)myIntA.Clone();
            Integer3 cloneMyIntB = myIntA.Clone() as Integer3;

            //test if we have a shallow or deep copy?
            myIntA.X = 100000;
            Console.WriteLine(myIntA.X);
            Console.WriteLine(cloneMyIntB.X);

            #endregion Clone Demo
        }

        //EX - 1
        /// <summary>
        /// Simple method to demonstrate that value types are passed by copy
        /// and so changing the value INSIDE the method does not affect the variable
        /// values passed from OUTSIDE the method
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        private void Print(int a, double b)
        {
            a = -10;
            b = 1E6; //1000000
            Console.WriteLine($"{a} and {b}");
            //Console.WriteLine(a + " and " + b);
        }

        private int DoSomething()
        {
            //TODO - return to this immediately
            //HACK - works now but fails > 100 input
            throw new NotImplementedException("sdfsdfsdfsdfd");
            return -1;
        }
    }
}