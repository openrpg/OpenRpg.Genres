using OpenRpg.Genres.Fantasy.Types;
using OpenRpg.Items;

using OpenRpg.Items.Equipment;

namespace OpenRpg.Genres.Fantasy.Equipment.Slots
{
    public class LowerBodySlot : DefaultEquipmentSlot
    {
        public LowerBodySlot(IItem slottedItem = null) : base(slottedItem)
        {}

        public override bool CanEquipItemType(int itemType)
        { return itemType == FantasyGenresItemTypes.LowerBodyArmour; }
    }
}