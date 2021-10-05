using GDLibrary.Interfaces;
using GDLibrary.Types;
using System;
using System.Numerics;

namespace GDLibrary
{
    //EX - 6
    /// <summary>
    /// Represents a Player entity in the game and stores name, texture and transformation related variables
    /// </summary>
    //aggregate objects => "has-a"
    public class Player : ICloneable, IDeepCloneable
    {
        #region Variables

        private string name, texture;
        private Integer3 translation;
        private Vector3 rotation, scale;

        #endregion Variables

        #region Properties

        public string Name { get => name; set => name = value; } //Expression bodied member
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
        public Player(string name, string texture)
            : this("", "", new Integer3(0, 0, 0), Vector3.Zero /*new Vector3(0,0,0)*/, Vector3.One)
        {
        }

        //default
        public Player() : this("", "")
        {
            //Name = "";
            //Texture = "";
            //Translation = new Integer3(0,0,0);
            //Rotation = Vector3.Zero;
            //Scale = Vector3.One;
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
            return this; //reference to the object - shallow
        }

        //Clone - Deep
        public object DeepClone() //Lets add a new method that ALWAYS returns a deep copy
        {
            //new keyword indicates that memory is being assigned
            return new Player(name, //value-type
                texture,  //value-type
                translation.DeepClone() as Integer3,  //reference-type because its a class
                rotation, //value-type because its a struct
                scale);  //value-type because its a struct
        }

        #endregion Overridden
    }
}