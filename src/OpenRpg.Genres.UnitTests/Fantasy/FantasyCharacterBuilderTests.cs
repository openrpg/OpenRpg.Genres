using Moq;
using OpenRpg.Core.Utils;
using OpenRpg.Genres.Characters;
using OpenRpg.Genres.Fantasy.Builders;
using OpenRpg.Genres.Fantasy.Extensions;
using OpenRpg.Genres.Fantasy.Types;
using OpenRpg.Genres.Persistence.Characters;
using Xunit;

namespace OpenRpg.Genres.UnitTests.Fantasy
{
    public class FantasyCharacterBuilderTests
    {
        [Fact]
        public void should_correctly_setup_slots_for_mapping()
        {
            var mockRandomizer = new Mock<IRandomizer>();
            var mockCharacterMapper = new Mock<ICharacterMapper>();
            mockCharacterMapper
                .Setup(x => x.Map(It.IsAny<CharacterData>()))
                .Returns(new DefaultCharacter());
            
            var characterBuilder = new FantasyCharacterBuilder(mockCharacterMapper.Object, mockRandomizer.Object);

            characterBuilder.CreateNew().Build();
            mockCharacterMapper.Verify(x => x.Map(It.Is<CharacterData>(y => 
                    y.EquipmentData.Slots.ContainsKey(EquipmentSlotTypes.BackSlot) &&
                    y.EquipmentData.Slots.ContainsKey(EquipmentSlotTypes.HeadSlot) &&
                    y.EquipmentData.Slots.ContainsKey(EquipmentSlotTypes.UpperBodySlot) &&
                    y.EquipmentData.Slots.ContainsKey(EquipmentSlotTypes.LowerBodySlot) &&
                    y.EquipmentData.Slots.ContainsKey(EquipmentSlotTypes.FootSlot) &&
                    y.EquipmentData.Slots.ContainsKey(EquipmentSlotTypes.WristSlot) &&
                    y.EquipmentData.Slots.ContainsKey(EquipmentSlotTypes.MainHandSlot) &&
                    y.EquipmentData.Slots.ContainsKey(EquipmentSlotTypes.OffHandSlot) &&
                    y.EquipmentData.Slots.ContainsKey(EquipmentSlotTypes.NeckSlot) &&
                    y.EquipmentData.Slots.ContainsKey(EquipmentSlotTypes.Ring1Slot) &&
                    y.EquipmentData.Slots.ContainsKey(EquipmentSlotTypes.Ring2Slot)
                )));
        }
    }
}