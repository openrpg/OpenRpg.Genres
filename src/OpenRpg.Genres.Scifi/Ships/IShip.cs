using OpenRpg.Genres.Characters;
using OpenRpg.Genres.Scifi.Variables;

namespace OpenRpg.Genres.Scifi.Ships
{
    public interface IShip
    {
        ICharacter Pilot { get; }
        IShipTemplate ShipTemplate { get; }
        IShipStatVariables Stats { get; }
        IShipStateVariables State { get; }
        IShipVariables Variables { get; }
    }
}