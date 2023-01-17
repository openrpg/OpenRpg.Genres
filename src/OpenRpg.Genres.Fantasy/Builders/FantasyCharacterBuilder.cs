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
            if(!_equipment.ContainsKey(EquipmentSlotTypes.HeadSlot)) { _equipment.Add(EquipmentSlotTypes.HeadSlot, null); }
            if(!_equipment.ContainsKey(EquipmentSlotTypes.BackSlot)) { _equipment.Add(EquipmentSlotTypes.BackSlot, null); }
            if(!_equipment.ContainsKey(EquipmentSlotTypes.UpperBodySlot)) { _equipment.Add(EquipmentSlotTypes.UpperBodySlot, null); }
            if(!_equipment.ContainsKey(EquipmentSlotTypes.LowerBodySlot)) { _equipment.Add(EquipmentSlotTypes.LowerBodySlot, null); }
            if(!_equipment.ContainsKey(EquipmentSlotTypes.FootSlot)) { _equipment.Add(EquipmentSlotTypes.FootSlot, null); }
            if(!_equipment.ContainsKey(EquipmentSlotTypes.MainHandSlot)) { _equipment.Add(EquipmentSlotTypes.MainHandSlot, null); }
            if(!_equipment.ContainsKey(EquipmentSlotTypes.OffHandSlot)) { _equipment.Add(EquipmentSlotTypes.OffHandSlot, null); }
            if(!_equipment.ContainsKey(EquipmentSlotTypes.NeckSlot)) { _equipment.Add(EquipmentSlotTypes.NeckSlot, null); }
            if(!_equipment.ContainsKey(EquipmentSlotTypes.Ring1Slot)) { _equipment.Add(EquipmentSlotTypes.Ring1Slot, null); }
            if(!_equipment.ContainsKey(EquipmentSlotTypes.Ring2Slot)) { _equipment.Add(EquipmentSlotTypes.Ring2Slot, null); }
            if(!_equipment.ContainsKey(EquipmentSlotTypes.WristSlot)) { _equipment.Add(EquipmentSlotTypes.WristSlot, null); }
        }

        protected override void PostProcessCharacter(ICharacter character)
        {
            if (!character.State.ContainsKey(CharacterStateVariableTypes.Health))
            { character.State.Health(character.Stats.MaxHealth()); }
            
            if (!character.State.ContainsKey(CharacterStateVariableTypes.Magic))
            { character.State.Magic(character.Stats.MaxMagic()); }
            
            base.PostProcessCharacter(character);
        }
    }
}