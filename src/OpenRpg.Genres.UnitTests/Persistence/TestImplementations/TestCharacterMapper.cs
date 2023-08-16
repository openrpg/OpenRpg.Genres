using OpenRpg.Core.Races;
using OpenRpg.Core.Stats.Populators;
using OpenRpg.Genres.Persistence.Characters;
using OpenRpg.Genres.Persistence.Classes;
using OpenRpg.Genres.Persistence.Items;
using OpenRpg.Genres.Persistence.Items.Equipment;
using OpenRpg.Genres.Persistence.Items.Inventory;

namespace OpenRpg.Genres.UnitTests.Persistence.TestImplementations
{
    public class TestCharacterMapper : CharacterMapper
    {
        private readonly DefaultRaceTemplate DefaultRaceTemplate = new DefaultRaceTemplate();
        
        public TestCharacterMapper(IItemMapper itemMapper, IClassMapper classMapper, IEquipmentMapper equipmentMapper, IInventoryMapper inventoryMapper, IStatPopulator statsPopulator) 
            : base(itemMapper, classMapper, equipmentMapper, inventoryMapper, statsPopulator)
        {
        }

        public override IRaceTemplate GetRaceTemplateFor(int raceTemplateId)
        {
            return DefaultRaceTemplate;
        }
    }
}