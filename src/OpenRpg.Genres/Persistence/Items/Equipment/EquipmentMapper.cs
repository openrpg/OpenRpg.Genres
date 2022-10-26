using System.Linq;
using OpenRpg.Items.Equipment;
using OpenRpg.Items.Variables;

namespace OpenRpg.Genres.Persistence.Items.Equipment
{
    public abstract class EquipmentMapper : IEquipmentMapper
    {
        public IEquipment Map(EquipmentData data)
        {
            var equipmentVariables = new DefaultEquipmentVariables(data.Variables
                .ToDictionary(x => x.Key, x => x.Value));

            var slots = new DefaultEquipmentSlots(data.Slots
                .ToDictionary(x => x.Key, x => GetSlotFor(x.Key, x.Value)));
            
            return new DefaultEquipment
            {
                Variables = equipmentVariables,
                Slots = slots
            };
        }

        public abstract IEquipmentSlot GetSlotFor(int slotType, ItemData slottedItemData);
    }
}