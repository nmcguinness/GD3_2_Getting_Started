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
        private int x, y, z;
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

        public Integer3()
        {

        }

        public Integer3()
        {
        }
    }
}
