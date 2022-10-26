using System.Collections.Generic;
using System.Linq;
using OpenRpg.Items;
using OpenRpg.Items.Inventory;

namespace OpenRpg.Genres.Persistence.Items.Inventory
{
    public class InventoryData
    {
        public IReadOnlyCollection<ItemData> Items { get; }
        public IReadOnlyDictionary<int, object> Variables { get; }

        public InventoryData(IReadOnlyCollection<ItemData> items, IReadOnlyDictionary<int, object> variables)
        {
            Items = items;
            Variables = variables;
        }

        public InventoryData(IInventory inventory)
        {
            Items = inventory.Items.Select(x => new ItemData(x as IUniqueItem)).ToArray();
            Variables = inventory.Variables;
        }
    }
}