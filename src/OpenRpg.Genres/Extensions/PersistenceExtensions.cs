using OpenRpg.Core.Classes;
using OpenRpg.Genres.Characters;
using OpenRpg.Genres.Persistence.Characters;
using OpenRpg.Genres.Persistence.Classes;
using OpenRpg.Genres.Persistence.Items;
using OpenRpg.Genres.Persistence.Items.Equipment;
using OpenRpg.Genres.Persistence.Items.Inventory;
using OpenRpg.Items;
using OpenRpg.Items.Equipment;
using OpenRpg.Items.Inventory;

namespace OpenRpg.Genres.Extensions
{
    public static class PersistenceExtensions
    {
        public static CharacterData ToDataModel(this ICharacter character)
        { return new CharacterData(character); }
        
        public static ItemData ToDataModel(this IUniqueItem item)
        { return new ItemData(item); }

        public static InventoryData ToDataModel(this IInventory inventory)
        { return new InventoryData(inventory); }
        
        public static EquipmentData ToDataModel(this IEquipment equipment)
        { return new EquipmentData(equipment); }
        
        public static ClassData ToDataModel(this IClass @class)
        { return new ClassData(@class); }
    }
}