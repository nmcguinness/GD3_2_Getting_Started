using System;

namespace GDLibrary.Utility
{
    /// <summary>
    /// Provide math functions for...game
    /// </summary>
    /// <see cref="GDLibrary.Program"/>
    /// <seealso cref="GDLibrary.Program"/>
    /// <example>
    /// int rand = MathUtility.GetRandInRange(1, 100);
    /// </example>
    class MathUtility
    {
        /// <summary>
        /// Returns an int in the range lo - hi
        /// </summary>
        /// <param name="lo">Integer value <=hi</param>
        /// <param name="hi">Integer value >= lo</param>
        /// <returns>Random integer</returns>
        public static int GetRandInRange(int lo, int hi)
        {
            if ((hi == lo) || (hi < lo))
                throw new ArgumentException("hi must be >= to lo");

            Random rand = new Random();
            return rand.Next(lo, hi);
        }

        //  (-10, 10, 0)
        /// <summary>
        /// Returns an int in the range lo - hi, excluding excl value
        /// </summary>
        /// <param name="lo">Integer value <=hi</param>
        /// <param name="hi">Integer value >= lo</param>
        /// <param name="excl">Integer value which will be excluded from lo-hi range</param>
        /// <returns>Random integer</returns>
        public static int RandInRangeExcl(int lo, int hi, int excl)
        {
            throw new NotImplementedException("It's end of class! Do next class!");
        }


    }
}
