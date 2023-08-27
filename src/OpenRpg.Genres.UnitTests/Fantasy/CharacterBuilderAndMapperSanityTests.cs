using Moq;
using Newtonsoft.Json;
using OpenRpg.Core.Stats.Populators;
using OpenRpg.Core.Stats.Variables;
using OpenRpg.Core.Utils;
using OpenRpg.Genres.Builders;
using OpenRpg.Genres.Extensions;
using OpenRpg.Genres.Fantasy.Builders;
using OpenRpg.Genres.Fantasy.Persistence.Items.Equipment;
using OpenRpg.Genres.Persistence.Items.Inventory;
using OpenRpg.Genres.UnitTests.Persistence.TestImplementations;
using Xunit;

namespace OpenRpg.Genres.UnitTests.Fantasy
{
    public class FantasyCharacterBuilderAndMapperSanityTests
    {
        [Fact]
        public void should_build_and_map_correctly()
        {
            var mockRandomizer = new Mock<IRandomizer>();
            
            var itemMapper = new TestItemMapper();
            var characterMapper = new TestCharacterMapper(new TestItemMapper(), new TestClassMapper(),
                new FantasyEquipmentMapper(itemMapper), new InventoryMapper(itemMapper));
            
            var characterBuilder = new FantasyCharacterBuilder(characterMapper, mockRandomizer.Object);
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