//sniper, mage, hunter, thief
//firstperson,thirdperson,static,flight,security
//an enum is a user-defined value type with a fixed number of
//states or values (e.g. mage, flight)
namespace GDLibrary.Enums //Types
{
    /// <summary>
    /// Enum indicating possible player types
    /// </summary>
    /// <example>
    /// Player p = new Player(PlayerType.Sniper, "", 1, 100);
    /// </example>
    public enum PlayerType : sbyte   //byte has range -127-> 0 -> 127
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