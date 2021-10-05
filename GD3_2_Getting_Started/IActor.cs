namespace GDLibrary.Interfaces
{
    /// <summary>
    /// Any updateable entity within our game will implement
    /// this interface e.g. DrawnActor, PC, NPC, Camera
    /// </summary>
    public interface IActor
    {
        public void Update(/*GameTime gameTime*/);

        //get actors type e.g. Camera, PC, NPC, Prop, Architecture
        //public ActorType GetActorType();
    }
}