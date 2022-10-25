using System.Linq;
using OpenRpg.Items.Inventory;

namespace OpenRpg.Genres.Persistence.Items.Inventory
{
    public class InventoryMapper : IInventoryMapper
    {
        public ItemMapper ItemMapper { get; }

        protected InventoryMapper(ItemMapper itemMapper)
        {
            ItemMapper = itemMapper;
        }

        public IInventory Map(PersistedInventory persistedData)
        {
            var inventoryVariables = new DefaultInventoryVariables(persistedData.Variables
                .ToDictionary(x => x.Key, x => x.Value));

            var items = persistedData.Items.Select(ItemMapper.Map);
            return new DefaultInventory(items)
            {
                Variables = inventoryVariables
            };
        }
    }
}