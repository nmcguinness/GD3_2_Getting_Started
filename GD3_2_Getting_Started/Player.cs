using System.Numerics;
using GDLibrary.Types;

namespace GDLibrary
{
    public class Player //aggregate objects => "has-a"
    {
        private string name, texture;
        private Integer3 translation;
        private Vector3 rotation, scale;

        //properties
        public string Name { get; set; }
        public string Texture { get; set; }

        public Integer3 Translation
        {
            get
            {
                return this.translation;
            }
            set
            {
                this.translation = value;
            }
        }

        //constructors - call one constructor from another (hint: this)
        //default
        //name, texture, set all to most appropriate
        //full

        //ToString

        //Clone - shallow
        //Clone - Deep
    }
}
