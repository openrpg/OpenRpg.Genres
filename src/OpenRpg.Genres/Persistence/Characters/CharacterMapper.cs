using System.Linq;
using OpenRpg.Core.Races;
using OpenRpg.Core.Stats.Variables;
using OpenRpg.Genres.Characters;
using OpenRpg.Genres.Extensions;
using OpenRpg.Genres.Persistence.Classes;
using OpenRpg.Genres.Persistence.Items;
using OpenRpg.Genres.Persistence.Items.Equipment;
using OpenRpg.Genres.Persistence.Items.Inventory;
using OpenRpg.Genres.Variables;

namespace OpenRpg.Genres.Persistence.Characters
{
    public abstract class CharacterMapper : ICharacterMapper
    {
        public ItemMapper ItemMapper { get; }
        public IClassMapper ClassMapper { get; }
        public IEquipmentMapper EquipmentMapper { get; }
        public InventoryMapper InventoryMapper { get; }
        public IStatPopulator StatsPopulator { get; }

        protected CharacterMapper(ItemMapper itemMapper, IClassMapper classMapper, IEquipmentMapper equipmentMapper, InventoryMapper inventoryMapper, IStatPopulator statsPopulator)
        {
            ItemMapper = itemMapper;
            ClassMapper = classMapper;
            EquipmentMapper = equipmentMapper;
            InventoryMapper = inventoryMapper;
            StatsPopulator = statsPopulator;
        }

        public ICharacter Map(PersistedCharacter persistedData)
        {
            var characterVariables = new DefaultCharacterVariables(persistedData.Variables
                .ToDictionary(x => x.Key, x => x.Value));

            var character = new DefaultCharacter
            {
                UniqueId = persistedData.Id,
                Variables = characterVariables,
                Class = ClassMapper.Map(persistedData.Class),
                Race = GetRaceTemplateFor(persistedData.RaceTemplateId),
                Equipment = EquipmentMapper.Map(persistedData.Equipment)
            };
            
            StatsPopulator.Populate(character.Stats, character.GetEffects().ToArray(), null);
            return character;
        }

        public abstract IRaceTemplate GetRaceTemplateFor(int raceTemplateId);
    }
}