using GDLibrary.Interfaces;
using System;

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
        private int x;

        //private ActorType actorType;
        //public ActorType ActorType
        //{
        //    get
        //    {
        //        return this.actorType;
        //    }
        //    set
        //    {
        //        this.actorType = value;
        //    }
        //}

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