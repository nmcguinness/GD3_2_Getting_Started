using GDLibrary.Types;
using System.Numerics;

namespace GDLibrary
{
    //EX - 6
    /// <summary>
    /// Represents a Player entity in the game and stores name, texture and transformation related variables
    /// </summary>
    public class Player //aggregate objects => "has-a"
    {
        #region Variables

        private string name, texture;
        private Integer3 translation;
        private Vector3 rotation, scale;

        #endregion Variables

        #region Properties

        public string Name { get => name; set => name = value; }
        public string Texture { get => texture; set => texture = value; }
        public Integer3 Translation { get => translation; set => translation = value; }
        public Vector3 Rotation { get => rotation; set => rotation = value; }
        public Vector3 Scale { get => scale; set => scale = value; }

        #endregion Properties

        #region Constructors

        //full
        public Player(string name, string texture, Integer3 translation, Vector3 rotation, Vector3 scale)
        {
            Name = name;
            Texture = texture;
            Translation = translation;
            Rotation = rotation;
            Scale = scale;
        }

        //name, texture, set all to most appropriate
        public Player(string name, string texture) : this("", "", new Integer3(0, 0, 0), Vector3.Zero, Vector3.One)
        {
        }

        //default
        public Player() : this("", "")
        {
        }

        #endregion Constructors

        #region Overridden

        //ToString
        public override string ToString()
        {
            return $"({name},{texture},{translation},{rotation},{scale})";
        }

        //Clone - shallow
        public object Clone()
        {
            return this;
        }

        //Clone - Deep
        public object DeepClone() //Lets add a new method that ALWAYS returns a deep copy
        {
            return new Player(name, texture, translation.DeepClone() as Integer3, rotation, scale);
        }

        #endregion Overridden
    }
}