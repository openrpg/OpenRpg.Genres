using OpenRpg.Core.Utils;
using OpenRpg.Genres.Builders;
using OpenRpg.Genres.Persistence.Characters;
using OpenRpg.Genres.Scifi.Types;

namespace OpenRpg.Genres.Scifi.Builders
{
    public class ScifiCharacterBuilder : CharacterBuilder
    {
        public ScifiCharacterBuilder(ICharacterMapper characterMapper, IRandomizer randomizer) : base(characterMapper, randomizer)
        {
        }

        protected override void PreCreateCharacterData()
        {
            if(!_equipment.ContainsKey(CharacterEquipmentSlotTypes.ArmourSlot)) { _equipment.Add(CharacterEquipmentSlotTypes.ArmourSlot, null); }
            if(!_equipment.ContainsKey(CharacterEquipmentSlotTypes.WeaponSlot)) { _equipment.Add(CharacterEquipmentSlotTypes.WeaponSlot, null); }
        }
    }
}