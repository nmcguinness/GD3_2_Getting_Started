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
using System.Numerics;
using GDLibrary.Actor;
using GDLibrary.Interfaces;
using System.Collections.Generic;

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

            Actor wall
                = new Actor(new Vector3(0, 2, 0));

            Camera3D mainHallSecurity
                 = new Camera3D(
                 new Vector3(20, 5, 0),
                 80, 1.6f,
                 new Vector3(0, 0, 1),
                 new Vector3(0, 1, 0));

            DrawnActor soldier1
                = new DrawnActor(new Vector3(0, 0, 0),
                "soldier_enemy.jpg",
                "soldier.fbx",
                "white"); //no blend color

            List<IActor> actorList = new List<IActor>();
            actorList.Add(mainHallSecurity);
            actorList.Add(soldier1);

            foreach (IActor actor in actorList)
                actor.Update();
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