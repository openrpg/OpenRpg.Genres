using Moq;
using Newtonsoft.Json;
using OpenRpg.Core.Utils;
using OpenRpg.Genres.Extensions;
using OpenRpg.Genres.Fantasy.Builders;
using OpenRpg.Genres.Fantasy.Persistence.Items.Equipment;
using OpenRpg.Genres.Persistence.Classes;
using OpenRpg.Genres.Persistence.Items.Inventory;
using OpenRpg.Genres.UnitTests.Persistence.TestImplementations;
using OpenRpg.Items;
using OpenRpg.Items.Templates;
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
            var classMapper = new TestClassMapper();
            var characterMapper = new TestCharacterMapper(new TestItemMapper(), classMapper,
                new MultiClassMapper(classMapper), new FantasyEquipmentMapper(itemMapper), 
                new InventoryMapper(itemMapper));
            
            var characterBuilder = new FantasyCharacterBuilder(characterMapper, mockRandomizer.Object);
            var character = characterBuilder
                .CreateNew()
                .WithRaceId(1)
                .WithClassId(1, 1)
                .WithInventoryItem(new DefaultItem(){ ItemTemplate = new DefaultItemTemplate() })
                .Build();
            
            Assert.NotNull(character);

            var characterData = character.ToDataModel();
            var characterRegenerated = characterMapper.Map(characterData);
            
            Assert.NotNull(characterRegenerated);

            // We just serialize the 2 objects to make deep comparison easier
            var expected = JsonConvert.SerializeObject(character);
            var actual = JsonConvert.SerializeObject(characterRegenerated);
            Assert.Equal(expected, actual);
        }
    }
}