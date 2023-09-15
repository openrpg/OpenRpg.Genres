using OpenRpg.Genres.Fantasy.Types;

namespace OpenRpg.Genres.Fantasy.Effects
{
    public static class EffectTypeGroups
    {
        public static int[] DamageEffectTypes =
        {
            FantasyGenreEffectTypes.SlashingDamageAmount, FantasyGenreEffectTypes.PiercingDamageAmount, FantasyGenreEffectTypes.BluntDamageAmount, FantasyGenreEffectTypes.UnarmedDamageAmount,
            FantasyGenreEffectTypes.FireDamageAmount, FantasyGenreEffectTypes.IceDamageAmount, FantasyGenreEffectTypes.WindDamageAmount, FantasyGenreEffectTypes.EarthDamageAmount,
            FantasyGenreEffectTypes.LightDamageAmount, FantasyGenreEffectTypes.DarkDamageAmount, FantasyGenreEffectTypes.AllMeleeDefenseBonusAmount, FantasyGenreEffectTypes.AllElementDamageBonusAmount
        };
        
        public static int[] DefenseEffectTypes =
        {
            FantasyGenreEffectTypes.SlashingDefenseAmount, FantasyGenreEffectTypes.PiercingDefenseAmount, FantasyGenreEffectTypes.BluntDefenseAmount, FantasyGenreEffectTypes.UnarmedDefenseAmount,
            FantasyGenreEffectTypes.FireDefenseAmount, FantasyGenreEffectTypes.IceDefenseAmount, FantasyGenreEffectTypes.WindDefenseAmount, FantasyGenreEffectTypes.EarthDefenseAmount,
            FantasyGenreEffectTypes.LightDefenseAmount, FantasyGenreEffectTypes.DarkDefenseAmount, FantasyGenreEffectTypes.AllMeleeDefenseBonusAmount, FantasyGenreEffectTypes.AllElementDefenseBonusAmount
        };
        
        public static int[] AttributeEffectTypes =
        {
            FantasyGenreEffectTypes.StrengthBonusAmount, FantasyGenreEffectTypes.DexterityBonusAmount, FantasyGenreEffectTypes.ConstitutionBonusAmount, 
            FantasyGenreEffectTypes.IntelligenceBonusAmount, FantasyGenreEffectTypes.WisdomBonusAmount, FantasyGenreEffectTypes.CharismaBonusAmount,
            FantasyGenreEffectTypes.AllAttributeBonusAmount
        };
    }
}