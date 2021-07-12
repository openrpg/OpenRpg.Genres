using System.Linq;
using OpenRpg.Combat.Attacks;
using OpenRpg.Combat.Processors;
using OpenRpg.Core.Stats;
using OpenRpg.Genres.Fantasy.Extensions;

namespace OpenRpg.Genres.Fantasy.Combat
{
    public class BasicAttackGenerator : IAttackGenerator
    {
        public Attack GenerateAttack(IStatsVariables stats)
        {
            var damages = stats.GetDamageReferences()
                .Where(x => x.StatValue != 0)
                .Select(x => new Damage(x.StatType, x.StatValue))
                .ToArray();

            return new Attack(damages);
        }
    }
}