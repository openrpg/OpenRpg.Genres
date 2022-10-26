using Moq;
using Newtonsoft.Json;
using OpenRpg.Core.Stats.Variables;
using OpenRpg.Core.Utils;
using OpenRpg.Genres.Builders;
using OpenRpg.Genres.Extensions;
using OpenRpg.Genres.Fantasy.Persistence.Items.Equipment;
using OpenRpg.Genres.Persistence.Items.Inventory;
using OpenRpg.Genres.UnitTests.Persistence.TestImplementations;
using Xunit;

namespace OpenRpg.Genres.UnitTests.Persistence
{
    public class CharacterBuilderAndMapperSanityTests
    {
        [Fact]
        public void should_build_and_map_correctly()
        {
            var mockStatsPopulator = new Mock<IStatPopulator>();
            var mockRandomizer = new Mock<IRandomizer>();
            
            var itemMapper = new TestItemMapper();
            var characterMapper = new TestCharacterMapper(new TestItemMapper(), new TestClassMapper(),
                new FantasyEquipmentMapper(itemMapper), new InventoryMapper(itemMapper), mockStatsPopulator.Object);
            
            var characterBuilder = new CharacterBuilder(characterMapper, mockRandomizer.Object);
            var character = characterBuilder
                .CreateNew()
                .Build();
            
            Assert.NotNull(character);

            var characterData = character.ToDataModel();
            var characterRegenerated = characterMapper.Map(characterData);
            
            Assert.NotNull(characterRegenerated);

            var expected = JsonConvert.SerializeObject(character);
            var actual = JsonConvert.SerializeObject(characterRegenerated);
            Assert.Equal(expected, actual);
        }
    }
}