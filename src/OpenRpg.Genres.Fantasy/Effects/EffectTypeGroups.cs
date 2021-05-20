using OpenRpg.Genres.Fantasy.Types;

namespace OpenRpg.Genres.Fantasy.Effects
{
    public static class EffectTypeGroups
    {
        public static int[] DamageEffectTypes =
        {
            EffectTypes.SlashingDamageAmount, EffectTypes.PiercingDamageAmount, EffectTypes.BluntDamageAmount, EffectTypes.UnarmedDamageAmount,
            EffectTypes.FireDamageAmount, EffectTypes.IceDamageAmount, EffectTypes.WindDamageAmount, EffectTypes.EarthDamageAmount,
            EffectTypes.LightDamageAmount, EffectTypes.DarkDamageAmount, EffectTypes.AllMeleeDefenseBonusAmount, EffectTypes.AllElementDamageBonusAmount
        };
        
        public static int[] DefenseEffectTypes =
        {
            EffectTypes.SlashingDefenseAmount, EffectTypes.PiercingDefenseAmount, EffectTypes.BluntDefenseAmount, EffectTypes.UnarmedDefenseAmount,
            EffectTypes.FireDefenseAmount, EffectTypes.IceDefenseAmount, EffectTypes.WindDefenseAmount, EffectTypes.EarthDefenseAmount,
            EffectTypes.LightDefenseAmount, EffectTypes.DarkDefenseAmount, EffectTypes.AllMeleeDefenseBonusAmount, EffectTypes.AllElementDefenseBonusAmount
        };
        
        public static int[] AttributeEffectTypes =
        {
            EffectTypes.StrengthBonusAmount, EffectTypes.DexterityBonusAmount, EffectTypes.ConstitutionBonusAmount, 
            EffectTypes.IntelligenceBonusAmount, EffectTypes.WisdomBonusAmount, EffectTypes.CharismaBonusAmount,
            EffectTypes.AllAttributeBonusAmount
        };
    }
}