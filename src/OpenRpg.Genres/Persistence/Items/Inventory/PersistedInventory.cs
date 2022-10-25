using System.Collections.Generic;
using System.Linq;
using OpenRpg.Items;
using OpenRpg.Items.Inventory;

namespace OpenRpg.Genres.Persistence.Items
{
    public class PersistedInventory
    {
        public IReadOnlyCollection<PersistedItem> Items { get; }
        public IReadOnlyDictionary<int, object> Variables { get; }

        public PersistedInventory(IReadOnlyCollection<PersistedItem> items, IReadOnlyDictionary<int, object> variables)
        {
            Items = items;
            Variables = variables;
        }

        public PersistedInventory(IInventory inventory)
        {
            Items = inventory.Items.Select(x => new PersistedItem(x as IUniqueItem)).ToArray();
            Variables = inventory.Variables;
        }
    }
}