using OpenRpg.Genres.Fantasy.Types;
using OpenRpg.Items;

using OpenRpg.Items.Equipment;

namespace OpenRpg.Genres.Fantasy.Equipment.Slots
{
    public class MainHandSlot : DefaultEquipmentSlot<IItem>
    {
        public override int SlotType => ItemTypes.GenericWeapon;
    }
}