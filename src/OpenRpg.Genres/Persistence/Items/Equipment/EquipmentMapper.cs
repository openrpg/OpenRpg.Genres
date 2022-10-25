using System.Linq;
using OpenRpg.Items.Equipment;
using OpenRpg.Items.Variables;

namespace OpenRpg.Genres.Persistence.Items.Equipment
{
    public abstract class EquipmentMapper : IEquipmentMapper
    {
        public IEquipment Map(PersistedEquipment persistedData)
        {
            var equipmentVariables = new DefaultEquipmentVariables(persistedData.Variables
                .ToDictionary(x => x.Key, x => x.Value));

            var slots = new DefaultEquipmentSlots(persistedData.Slots
                .ToDictionary(x => x.Key, x => GetSlotFor(x.Key, x.Value)));
            
            return new DefaultEquipment
            {
                Variables = equipmentVariables,
                Slots = slots
            };
        }

        public abstract IEquipmentSlot GetSlotFor(int slotType, PersistedItem slottedItem);
    }
}