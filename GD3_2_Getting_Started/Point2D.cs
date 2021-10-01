/// <summary>
/// Represents a point in 2D space and provides related methods and operators
/// </summary>
namespace  GDLibrary.Types
{
    public struct Point2D
    {
        #region Member Variables
        private int x; //age
        private int y;
        #endregion

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
        #endregion

        #region Constructor
        //public Point2D()
        //{
        //    this.x = 0;
        //    this.y = 0;
        //}
        public Point2D(int x, int y)
        {
            this.x = x;
            this.y = y;
            
        } 
        #endregion

        //EX - 4
        public override string ToString()
        {
            return $"{x},{y}"; //x + "," + y
        }


    }
} 