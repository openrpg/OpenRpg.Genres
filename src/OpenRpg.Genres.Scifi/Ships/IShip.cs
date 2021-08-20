using OpenRpg.Genres.Scifi.Equipment;
using OpenRpg.Genres.Scifi.Variables;
using OpenRpg.Items.Inventory;

namespace OpenRpg.Genres.Scifi.Ships
{
    public interface IShip
    {
        IPilot Pilot { get; }
        IShipTemplate ShipTemplate { get; }
        IShipEquipment Equipment { get; }
        IInventory Inventory { get; }
        IShipStats Stats { get; }
    }
}