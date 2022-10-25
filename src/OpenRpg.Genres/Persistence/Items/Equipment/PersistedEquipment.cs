using System.Collections.Generic;
using System.Linq;
using OpenRpg.Items;
using OpenRpg.Items.Equipment;

namespace OpenRpg.Genres.Persistence.Items.Equipment
{
    public class PersistedEquipment
    {
        public IReadOnlyDictionary<int, PersistedItem> Slots { get; }
        public IReadOnlyDictionary<int, object> Variables { get; }

        public PersistedEquipment(IReadOnlyDictionary<int, PersistedItem> slots, IReadOnlyDictionary<int, object> variables = null)
        {
            Slots = slots;
            Variables = variables ?? new Dictionary<int, object>();
        }

        public PersistedEquipment(IEquipment equipment)
        {
            Slots = equipment.Slots
                .ToDictionary(x => x.Key,
                    x => new PersistedItem(x.Value.SlottedItem as IUniqueItem));
        }
    }
}