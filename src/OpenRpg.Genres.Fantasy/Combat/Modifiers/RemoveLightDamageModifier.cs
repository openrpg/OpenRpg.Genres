using System.Linq;
using OpenRpg.Combat.Attacks;
using OpenRpg.Combat.Processors.Modifiers;
using OpenRpg.Genres.Fantasy.Types;

namespace OpenRpg.Genres.Fantasy.Combat.Modifiers
{
    /// <summary>
    /// This can be useful for those scenarios where you only want light to be seen as a healing mechanism not a damage one
    /// </summary>
    /// <remarks>
    /// This is a purely optional helper
    /// </remarks>
    public class RemoveLightDamageModifier : IAttackModifier
    {
        public bool ShouldApply(Attack attack) => true;

        public Attack ModifyValue(Attack attack)
        {
            attack.Damages = attack.Damages.Where(x => x.Type != DamageTypes.LightDamage).ToArray();
            return attack;
        }
    }
}