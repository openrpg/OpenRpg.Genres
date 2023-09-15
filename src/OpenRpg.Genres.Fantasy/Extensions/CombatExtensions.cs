using OpenRpg.Combat.Attacks;
using OpenRpg.Genres.Fantasy.Types;

namespace OpenRpg.Genres.Fantasy.Extensions
{
    public static class CombatExtensions
    {
        public static string TypeToName(this Damage damage)
        {
            if (damage.Type == FantasyGenreDamageTypes.IceDamage) return "Ice";
            if (damage.Type == FantasyGenreDamageTypes.FireDamage) return "Fire";
            if (damage.Type == FantasyGenreDamageTypes.WindDamage) return "Wind";
            if (damage.Type == FantasyGenreDamageTypes.EarthDamage) return "Earth";
            if (damage.Type == FantasyGenreDamageTypes.DarkDamage) return "Dark";
            if (damage.Type == FantasyGenreDamageTypes.LightDamage) return "Light";
            
            if (damage.Type == FantasyGenreDamageTypes.SlashingDamage) return "Slashing";
            if (damage.Type == FantasyGenreDamageTypes.BluntDamage) return "Blunt";
            if (damage.Type == FantasyGenreDamageTypes.PiercingDamage) return "Piercing";
            if (damage.Type == FantasyGenreDamageTypes.UnarmedDamage) return "Unarmed";

            return "Unknown";
        }
    }
}