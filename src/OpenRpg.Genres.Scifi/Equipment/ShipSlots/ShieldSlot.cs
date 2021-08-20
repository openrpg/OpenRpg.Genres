using OpenRpg.Genres.Scifi.Types;
using OpenRpg.Items;
using OpenRpg.Items.Equipment;

namespace OpenRpg.Genres.Scifi.Equipment.ShipSlots
{
    public class ShieldSlot : DefaultEquipmentSlot<IItem>
    {
        public override int SlotType => ShipItemTypes.Shield;
    }
}