using System.Linq;
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
        {
            return new CharacterData(character.UniqueId,
                character.NameLocaleId, character.DescriptionLocaleId, character.GenderType,
                character.Race.Id, character.Class.ToDataModel(), character.State,
                character.Equipment.ToDataModel(), character.Variables);
        }

        public static ItemData ToDataModel(this IUniqueItem item)
        {
            if (item == null) { return null; }
            return new ItemData(item.UniqueId,
                item.ItemTemplate.Id,
                item.Modifications.Select(x => x.Id).ToArray(),
                item.Variables);
        }

        public static InventoryData ToDataModel(this IInventory inventory)
        {
            var items = inventory.Items.Select(x => (x as IUniqueItem).ToDataModel()).ToArray();
            return new InventoryData(items, inventory.Variables);
        }

        public static EquipmentData ToDataModel(this IEquipment equipment)
        {
            var slots = equipment.Slots
                .ToDictionary(x => x.Key,
                    x => (x.Value.SlottedItem as IUniqueItem).ToDataModel());
            
            return new EquipmentData(slots, equipment.Variables);
        }
        
        public static ClassData ToDataModel(this IClass @class)
        { return new ClassData(@class.ClassTemplate.Id, @class.Level, @class.Variables); }
    }
}