using OpenRpg.Core.Utils;
using OpenRpg.Genres.Builders;
using OpenRpg.Genres.Characters;
using OpenRpg.Genres.Extensions;
using OpenRpg.Genres.Fantasy.Extensions;
using OpenRpg.Genres.Fantasy.Types;
using OpenRpg.Genres.Persistence.Characters;

namespace OpenRpg.Genres.Fantasy.Builders
{
    public class FantasyCharacterBuilder : CharacterBuilder
    {
        public FantasyCharacterBuilder(ICharacterMapper characterMapper, IRandomizer randomizer) : base(characterMapper, randomizer)
        {
        }

        protected override void PreCreateCharacterData()
        {
            base.PreCreateCharacterData();
            
            _equipment.TryAdd(EquipmentSlotTypes.HeadSlot, null);
            _equipment.TryAdd(EquipmentSlotTypes.BackSlot, null);
            _equipment.TryAdd(EquipmentSlotTypes.UpperBodySlot, null);
            _equipment.TryAdd(EquipmentSlotTypes.LowerBodySlot, null);
            _equipment.TryAdd(EquipmentSlotTypes.FootSlot, null);
            _equipment.TryAdd(EquipmentSlotTypes.MainHandSlot, null);
            _equipment.TryAdd(EquipmentSlotTypes.OffHandSlot, null);
            _equipment.TryAdd(EquipmentSlotTypes.NeckSlot, null);
            _equipment.TryAdd(EquipmentSlotTypes.Ring1Slot, null);
            _equipment.TryAdd(EquipmentSlotTypes.Ring2Slot, null);
            _equipment.TryAdd(EquipmentSlotTypes.WristSlot, null);
        }

        protected override void PostProcessCharacter(ICharacter character)
        {
            if (!character.State.ContainsKey(FantasyEntityStateVariableTypes.Health))
            { character.State.Health(character.Stats.MaxHealth()); }
            
            if (!character.State.ContainsKey(FantasyEntityStateVariableTypes.Magic))
            { character.State.Magic(character.Stats.MaxMagic()); }
            
            base.PostProcessCharacter(character);
        }
    }
}