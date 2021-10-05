using GDLibrary.Interfaces;
using System;
using System.Numerics;

namespace GDLibrary.Actor
{
    /// <summary>
    /// Concrete (can be instantiated) class which is the
    /// parent of all updateable entities
    /// e.g.
    /// Camera (updateable)
    /// or
    /// DrawnActor (updateable, drawable)
    /// </summary>
    public class Actor : IActor
    {
        private Vector3 translation;

        public Actor(Vector3 translation)
        {
            this.translation = translation;
        }

        public void Update()
        {
            Console.WriteLine("Updating...");
        }

        //void IActor.Update()
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}