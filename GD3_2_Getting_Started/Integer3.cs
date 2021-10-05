//EX - 5
namespace GDLibrary.Types
{
    /// <summary>
    /// Represent a triplet of integer values (x, y, z) and provide
    /// methods to show, add, distance, provide overloaded operators (+, -, *)
    /// Remember, this is a reference type i.e. pass-by-address
    /// </summary>
    public class Integer3
    {
        #region Member Variables

        private int x, y, z;

        #endregion Member Variables

        #region Properties

        public int X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }

        public int Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }

        public int Z
        {
            get
            {
                return this.z;
            }
            set
            {
                this.z = value;
            }
        }

        #endregion Properties

        #region Constructors

        public Integer3(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Integer3() : this(0, 0, 0)
        {
            //this.x = 0;
            //this.y = 0;
            //this.z = 0;
        }

        #endregion Constructors

        #region Overridden

        public override string ToString()
        {
            return $"{x},{y},{z}";
        }

        //public object Clone() //Shallow copy
        //{
        //    return this; //reference to the current object
        //}

        //public object Clone() //Deep copy - v1
        //{
        //    return new Integer3(x,y,z); //reference to a new object
        //}

        public object Clone() //Deep copy - v2
        {
            return this.MemberwiseClone();
            //reference to a new object where all value types are copied and all
            //reference types are copied only by address
            //remember the example of the DrawnObject(x,y,z, model, texture) and the trees
        }

        public object DeepClone() //Lets add a new method that ALWAYS returns a deep copy
        {
            return new Integer3(x, y, z); //reference to a new object
        }

        #endregion Overridden
    }
}