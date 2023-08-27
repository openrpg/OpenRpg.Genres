using System.Linq;
using OpenRpg.Core.Classes;
using OpenRpg.Core.Races;
using OpenRpg.Genres.Characters;
using OpenRpg.Genres.Persistence.Classes;
using OpenRpg.Genres.Persistence.Items;
using OpenRpg.Genres.Persistence.Items.Equipment;
using OpenRpg.Genres.Persistence.Items.Inventory;
using OpenRpg.Genres.Variables;
using OpenRpg.Items.Equipment;

namespace OpenRpg.Genres.Persistence.Characters
{
    public abstract class CharacterMapper : ICharacterMapper
    {
        public IItemMapper ItemMapper { get; }
        public IClassMapper ClassMapper { get; }
        public IEquipmentMapper EquipmentMapper { get; }
        public IInventoryMapper InventoryMapper { get; }

        protected CharacterMapper(IItemMapper itemMapper, IClassMapper classMapper, IEquipmentMapper equipmentMapper, IInventoryMapper inventoryMapper)
        {
            ItemMapper = itemMapper;
            ClassMapper = classMapper;
            EquipmentMapper = equipmentMapper;
            InventoryMapper = inventoryMapper;
        }

        public ICharacter Map(CharacterData data)
        {
            var characterVariables = new DefaultCharacterVariables(data.Variables
                .ToDictionary(x => x.Key, x => x.Value));

            var characterState = new DefaultCharacterStateVariables(data.StateVariables
                .ToDictionary(x => x.Key, x => x.Value));

            var raceTemplate = GetRaceTemplateFor(data.RaceTemplateId);
            var characterClass = ClassMapper.Map(data.ClassData);
            var equipment = EquipmentMapper.Map(data.EquipmentData);
            
            return InitializeCharacter(data, characterState, characterVariables, raceTemplate, characterClass, equipment);
        }

        public virtual ICharacter InitializeCharacter(CharacterData data, ICharacterStateVariables state, ICharacterVariables variables, IRaceTemplate raceTemplate, IClass @class, IEquipment equipment)
        {
            return new DefaultCharacter
            {
                NameLocaleId = data.NameLocaleId,
                DescriptionLocaleId = data.DescriptionLocaleId,
                UniqueId = data.Id,
                Variables = variables,
                Class = @class,
                Race = raceTemplate,
                Equipment = equipment,
                State = state,
                GenderType = data.GenderType
            };
        }
        
        public abstract IRaceTemplate GetRaceTemplateFor(int raceTemplateId);
    }
}