//x, y position, integers

namespace  GDLibrary.Types
{
    public struct Point2D
    {
        #region Member Variables
        private int x; //age
        private int y;
        #endregion

        //property (getter, setter)
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
    }
}