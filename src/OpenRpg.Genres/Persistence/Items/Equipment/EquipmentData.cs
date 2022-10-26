using System.Collections.Generic;
using System.Linq;
using OpenRpg.Items;
using OpenRpg.Items.Equipment;

namespace OpenRpg.Genres.Persistence.Items.Equipment
{
    public class EquipmentData
    {
        public IReadOnlyDictionary<int, ItemData> Slots { get; }
        public IReadOnlyDictionary<int, object> Variables { get; }

        public EquipmentData(IReadOnlyDictionary<int, ItemData> slots, IReadOnlyDictionary<int, object> variables = null)
        {
            Slots = slots;
            Variables = variables ?? new Dictionary<int, object>();
        }

        public EquipmentData(IEquipment equipment)
        {
            Slots = equipment.Slots
                .ToDictionary(x => x.Key,
                    x => new ItemData(x.Value.SlottedItem as IUniqueItem));

            Variables = equipment.Variables;
        }
    }
}