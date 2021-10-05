/// <summary>
/// Represents a point in 2D space and provides related methods and operators
/// </summary>
namespace GDLibrary.Types
{
    /// <summary>
    /// Represents a 2D point within the game and is most typically used for drawing menu textures to screen
    /// </summary>
    public struct Point2D
    {
        #region Member Variables

        private int x; //age
        private int y;

        #endregion Member Variables

        #region Properties

        public int X //Age
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value >= 0 ? value : 0; //ternary operator

                if (value >= 0)
                {
                    this.x = value;
                }
                else
                {
                    this.x = 0;
                }
            }
        }

        #endregion Properties

        #region Constructors

        public Point2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        #endregion Constructors

        #region Overridden

        public override string ToString()
        {
            return $"{x},{y}"; //x + "," + y
        }

        //Clone - shallow
        public object Clone()
        {
            return this;
        }

        //Clone - Deep
        public object DeepClone() //Lets add a new method that ALWAYS returns a deep copy
        {
            return new Point2D(x, y);
        }

        #endregion Overridden
    }
}