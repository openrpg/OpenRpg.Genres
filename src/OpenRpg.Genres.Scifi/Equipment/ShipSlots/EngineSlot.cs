using OpenRpg.Genres.Scifi.Types;
using OpenRpg.Items;
using OpenRpg.Items.Equipment;

namespace OpenRpg.Genres.Scifi.Equipment.ShipSlots
{
    public class EngineSlot : DefaultEquipmentSlot<IItem>
    {
        public override int SlotType => ShipItemTypes.Engine;
    }
}