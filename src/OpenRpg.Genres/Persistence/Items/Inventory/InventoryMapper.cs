using System.Linq;
using OpenRpg.Items.Inventory;

namespace OpenRpg.Genres.Persistence.Items.Inventory
{
    public class InventoryMapper : IInventoryMapper
    {
        public IItemMapper ItemMapper { get; }

        public InventoryMapper(IItemMapper itemMapper)
        {
            ItemMapper = itemMapper;
        }

        public IInventory Map(InventoryData data)
        {
            var inventoryVariables = new DefaultInventoryVariables(data.Variables
                .ToDictionary(x => x.Key, x => x.Value));

            var items = data.Items.Select(ItemMapper.Map);
            return new DefaultInventory(items)
            {
                Variables = inventoryVariables
            };
        }
    }
}