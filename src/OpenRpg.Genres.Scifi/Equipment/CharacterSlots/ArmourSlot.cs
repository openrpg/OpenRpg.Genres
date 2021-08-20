using OpenRpg.Genres.Scifi.Types;
using OpenRpg.Items;
using OpenRpg.Items.Equipment;

namespace OpenRpg.Genres.Scifi.Equipment.CharacterSlots
{
    public class ArmourSlot : DefaultEquipmentSlot<IItem>
    {
        public override int SlotType => ItemTypes.Armour;
    }
}