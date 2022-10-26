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
        public IItemMapper ItemMapper { get; }
        public IClassMapper ClassMapper { get; }
        public IEquipmentMapper EquipmentMapper { get; }
        public IInventoryMapper InventoryMapper { get; }
        public IStatPopulator StatsPopulator { get; }

        protected CharacterMapper(IItemMapper itemMapper, IClassMapper classMapper, IEquipmentMapper equipmentMapper, IInventoryMapper inventoryMapper, IStatPopulator statsPopulator)
        {
            ItemMapper = itemMapper;
            ClassMapper = classMapper;
            EquipmentMapper = equipmentMapper;
            InventoryMapper = inventoryMapper;
            StatsPopulator = statsPopulator;
        }

        public ICharacter Map(CharacterData data)
        {
            var characterVariables = new DefaultCharacterVariables(data.Variables
                .ToDictionary(x => x.Key, x => x.Value));

            var characterState = new DefaultCharacterStateVariables(data.StateVariables.ToDictionary(x => x.Key, x => x.Value));
            
            var character = new DefaultCharacter
            {
                NameLocaleId = data.NameLocaleId,
                DescriptionLocaleId = data.DescriptionLocaleId,
                UniqueId = data.Id,
                Variables = characterVariables,
                Class = ClassMapper.Map(data.ClassData),
                Race = GetRaceTemplateFor(data.RaceTemplateId),
                Equipment = EquipmentMapper.Map(data.EquipmentData),
                State = characterState,
                GenderType = data.GenderType
            };
            
            StatsPopulator.Populate(character.Stats, character.GetEffects().ToArray(), null);
            return character;
        }

        public abstract IRaceTemplate GetRaceTemplateFor(int raceTemplateId);
    }
}