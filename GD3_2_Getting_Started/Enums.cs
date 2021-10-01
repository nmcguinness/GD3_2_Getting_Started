/// <summary>
/// Represents commonly used user-defined value type enums within our game engine
/// Remember, an enum is a user-defined value type with a fixed number of states or values (e.g. mage, flight)
/// </summary>
namespace GDLibrary.Enums //Types
{
    /// <summary>
    /// Enum indicating possible player types
    /// </summary>
    /// <example>
    /// Player p = new Player(PlayerType.Sniper, "", 1, 100);
    /// </example>
    public enum PlayerType : sbyte   //byte has range -127-> 0 -> 127, sbyte (signed byte) has range 0 -> 255
    {
       // internal representation is as an integer i.e. 0,1,2,3
        Sniper, Mage, Hunter, Thief
    }

    public enum CameraType : sbyte
    {
        FirstPerson, ThirdPerson, 
        Static, Flight, God, Security, 
        Rail, Curve
    }

}