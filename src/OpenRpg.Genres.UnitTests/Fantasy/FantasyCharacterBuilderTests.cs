using Moq;
using OpenRpg.Core.Types;
using OpenRpg.Core.Utils;
using OpenRpg.Genres.Characters;
using OpenRpg.Genres.Fantasy.Builders;
using OpenRpg.Genres.Fantasy.Extensions;
using OpenRpg.Genres.Fantasy.Types;
using OpenRpg.Genres.Persistence.Characters;
using OpenRpg.Genres.Persistence.Items.Equipment;
using OpenRpg.Genres.Types;
using OpenRpg.Items.Equipment;
using Xunit;

namespace OpenRpg.Genres.UnitTests.Fantasy
{
    public class FantasyCharacterBuilderTests
    {
        [Fact]
        public void should_correctly_setup_slots_for_mapping_when_has_equipment()
        {
            var mockRandomizer = new Mock<IRandomizer>();
            var mockCharacterMapper = new Mock<ICharacterMapper>();
            mockCharacterMapper
                .Setup(x => x.Map(It.IsAny<CharacterData>()))
                .Returns(new DefaultCharacter());
            
            var characterBuilder = new FantasyCharacterBuilder(mockCharacterMapper.Object, mockRandomizer.Object);

            characterBuilder.CreateNew().Build();
            
            mockCharacterMapper.Verify(x => x.Map(It.Is<CharacterData>(y => 
                y.Variables.ContainsKey(GenreEntityVariableTypes.Equipment) && 
                (y.Variables[GenreEntityVariableTypes.Equipment] as EquipmentData).Slots.ContainsKey(EquipmentSlotTypes.BackSlot) &&
                (y.Variables[GenreEntityVariableTypes.Equipment] as EquipmentData).Slots.ContainsKey(EquipmentSlotTypes.HeadSlot) &&
                (y.Variables[GenreEntityVariableTypes.Equipment] as EquipmentData).Slots.ContainsKey(EquipmentSlotTypes.UpperBodySlot) &&
                (y.Variables[GenreEntityVariableTypes.Equipment] as EquipmentData).Slots.ContainsKey(EquipmentSlotTypes.LowerBodySlot) &&
                (y.Variables[GenreEntityVariableTypes.Equipment] as EquipmentData).Slots.ContainsKey(EquipmentSlotTypes.FootSlot) &&
                (y.Variables[GenreEntityVariableTypes.Equipment] as EquipmentData).Slots.ContainsKey(EquipmentSlotTypes.WristSlot) &&
                (y.Variables[GenreEntityVariableTypes.Equipment] as EquipmentData).Slots.ContainsKey(EquipmentSlotTypes.MainHandSlot) &&
                (y.Variables[GenreEntityVariableTypes.Equipment] as EquipmentData).Slots.ContainsKey(EquipmentSlotTypes.OffHandSlot) &&
                (y.Variables[GenreEntityVariableTypes.Equipment] as EquipmentData).Slots.ContainsKey(EquipmentSlotTypes.NeckSlot) &&
                (y.Variables[GenreEntityVariableTypes.Equipment] as EquipmentData).Slots.ContainsKey(EquipmentSlotTypes.Ring1Slot) &&
                (y.Variables[GenreEntityVariableTypes.Equipment] as EquipmentData).Slots.ContainsKey(EquipmentSlotTypes.Ring2Slot) )));
        }
    }
}