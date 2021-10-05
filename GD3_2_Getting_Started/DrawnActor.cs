using System.Numerics;

namespace GDLibrary.Actor
{
    /// <summary>
    /// Represents any entity in the systems, inheriting from
    /// Actor that also adds a Draw method
    /// e.g. Player, Pickup, Door
    /// </summary>
    public class DrawnActor : Actor //":" is like extends in Java
    {
        private string texture, model, color;

        public DrawnActor(Vector3 translation, string texture,
            string model, string color) : base(translation)
        {
            this.texture = texture;
            //...
        }
    }
}