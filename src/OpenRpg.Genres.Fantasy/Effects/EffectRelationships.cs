using OpenRpg.Combat.Attacks;
using OpenRpg.Genres.Fantasy.Types;

namespace OpenRpg.Genres.Fantasy.Effects
{
    public static class EffectRelationships
    {
        public static EffectRelationship IceDamageRelationship => new EffectRelationship
        {
            AmountType = FantasyGenreEffectTypes.IceDamageAmount,
            PercentageType = FantasyGenreEffectTypes.IceDamagePercentage,
            BonusAmountType = FantasyGenreEffectTypes.IceBonusAmount,
            BonusPercentageType = FantasyGenreEffectTypes.IceBonusPercentage
        };
        
        public static EffectRelationship IceDefenseRelationship => new EffectRelationship
        {
            AmountType = FantasyGenreEffectTypes.IceDefenseAmount,
            PercentageType = FantasyGenreEffectTypes.IceDefensePercentage,
            BonusAmountType = FantasyGenreEffectTypes.IceBonusAmount,
            BonusPercentageType = FantasyGenreEffectTypes.IceBonusPercentage
        };
        
        public static EffectRelationship FireDamageRelationship => new EffectRelationship
        {
            AmountType = FantasyGenreEffectTypes.FireDamageAmount,
            PercentageType = FantasyGenreEffectTypes.FireDamagePercentage,
            BonusAmountType = FantasyGenreEffectTypes.FireBonusAmount,
            BonusPercentageType = FantasyGenreEffectTypes.FireBonusPercentage
        };
        
        public static EffectRelationship FireDefenseRelationship => new EffectRelationship
        {
            AmountType = FantasyGenreEffectTypes.FireDefenseAmount,
            PercentageType = FantasyGenreEffectTypes.FireDefensePercentage,
            BonusAmountType = FantasyGenreEffectTypes.FireBonusAmount,
            BonusPercentageType = FantasyGenreEffectTypes.FireBonusPercentage
        };
        
        public static EffectRelationship WindDamageRelationship => new EffectRelationship
        {
            AmountType = FantasyGenreEffectTypes.WindDamageAmount,
            PercentageType = FantasyGenreEffectTypes.WindDamagePercentage,
            BonusAmountType = FantasyGenreEffectTypes.WindBonusAmount,
            BonusPercentageType = FantasyGenreEffectTypes.WindBonusPercentage
        };
        
        public static EffectRelationship WindDefenseRelationship => new EffectRelationship
        {
            AmountType = FantasyGenreEffectTypes.WindDefenseAmount,
            PercentageType = FantasyGenreEffectTypes.WindDefensePercentage,
            BonusAmountType = FantasyGenreEffectTypes.WindBonusAmount,
            BonusPercentageType = FantasyGenreEffectTypes.WindBonusPercentage
        };
        
        public static EffectRelationship EarthDamageRelationship => new EffectRelationship
        {
            AmountType = FantasyGenreEffectTypes.EarthDamageAmount,
            PercentageType = FantasyGenreEffectTypes.EarthDamagePercentage,
            BonusAmountType = FantasyGenreEffectTypes.EarthBonusAmount,
            BonusPercentageType = FantasyGenreEffectTypes.EarthBonusPercentage
        };
        
        public static EffectRelationship EarthDefenseRelationship => new EffectRelationship
        {
            AmountType = FantasyGenreEffectTypes.EarthDefenseAmount,
            PercentageType = FantasyGenreEffectTypes.EarthDefensePercentage,
            BonusAmountType = FantasyGenreEffectTypes.EarthBonusAmount,
            BonusPercentageType = FantasyGenreEffectTypes.EarthBonusPercentage
        };
        
        public static EffectRelationship DarkDamageRelationship => new EffectRelationship
        {
            AmountType = FantasyGenreEffectTypes.DarkDamageAmount,
            PercentageType = FantasyGenreEffectTypes.DarkDamagePercentage,
            BonusAmountType = FantasyGenreEffectTypes.DarkBonusAmount,
            BonusPercentageType = FantasyGenreEffectTypes.DarkBonusPercentage
        };
        
        public static EffectRelationship DarkDefenseRelationship => new EffectRelationship
        {
            AmountType = FantasyGenreEffectTypes.DarkDefenseAmount,
            PercentageType = FantasyGenreEffectTypes.DarkDefensePercentage,
            BonusAmountType = FantasyGenreEffectTypes.DarkBonusAmount,
            BonusPercentageType = FantasyGenreEffectTypes.DarkBonusPercentage
        };
        
        public static EffectRelationship LightDamageRelationship => new EffectRelationship
        {
            AmountType = FantasyGenreEffectTypes.LightDamageAmount,
            PercentageType = FantasyGenreEffectTypes.LightDamagePercentage,
            BonusAmountType = FantasyGenreEffectTypes.LightBonusAmount,
            BonusPercentageType = FantasyGenreEffectTypes.LightBonusPercentage
        };
        
        public static EffectRelationship LightDefenseRelationship => new EffectRelationship
        {
            AmountType = FantasyGenreEffectTypes.LightDefenseAmount,
            PercentageType = FantasyGenreEffectTypes.LightDefensePercentage,
            BonusAmountType = FantasyGenreEffectTypes.LightBonusAmount,
            BonusPercentageType = FantasyGenreEffectTypes.LightBonusPercentage
        };
        
        public static EffectRelationship SlashingDamageRelationship => new EffectRelationship
        {
            AmountType = FantasyGenreEffectTypes.SlashingDamageAmount,
            PercentageType = FantasyGenreEffectTypes.SlashingDamagePercentage,
            BonusAmountType = FantasyGenreEffectTypes.SlashingBonusAmount,
            BonusPercentageType = FantasyGenreEffectTypes.SlashingBonusPercentage
        };
        
        public static EffectRelationship SlashingDefenseRelationship => new EffectRelationship
        {
            AmountType = FantasyGenreEffectTypes.SlashingDefenseAmount,
            PercentageType = FantasyGenreEffectTypes.SlashingDefensePercentage,
            BonusAmountType = FantasyGenreEffectTypes.SlashingBonusAmount,
            BonusPercentageType = FantasyGenreEffectTypes.SlashingBonusPercentage
        };
        
        public static EffectRelationship BluntDamageRelationship => new EffectRelationship
        {
            AmountType = FantasyGenreEffectTypes.BluntDamageAmount,
            PercentageType = FantasyGenreEffectTypes.BluntDamagePercentage,
            BonusAmountType = FantasyGenreEffectTypes.BluntBonusAmount,
            BonusPercentageType = FantasyGenreEffectTypes.BluntBonusPercentage
        };
        
        public static EffectRelationship BluntDefenseRelationship => new EffectRelationship
        {
            AmountType = FantasyGenreEffectTypes.BluntDefenseAmount,
            PercentageType = FantasyGenreEffectTypes.BluntDefensePercentage,
            BonusAmountType = FantasyGenreEffectTypes.BluntBonusAmount,
            BonusPercentageType = FantasyGenreEffectTypes.BluntBonusPercentage
        };
        
        public static EffectRelationship PiercingDamageRelationship => new EffectRelationship
        {
            AmountType = FantasyGenreEffectTypes.PiercingDamageAmount,
            PercentageType = FantasyGenreEffectTypes.PiercingDamagePercentage,
            BonusAmountType = FantasyGenreEffectTypes.PiercingBonusAmount,
            BonusPercentageType = FantasyGenreEffectTypes.PiercingBonusPercentage
        };
        
        public static EffectRelationship PiercingDefenseRelationship => new EffectRelationship
        {
            AmountType = FantasyGenreEffectTypes.PiercingDefenseAmount,
            PercentageType = FantasyGenreEffectTypes.PiercingDefensePercentage,
            BonusAmountType = FantasyGenreEffectTypes.PiercingBonusAmount,
            BonusPercentageType = FantasyGenreEffectTypes.PiercingBonusPercentage
        };
        
        public static EffectRelationship UnarmedDamageRelationship => new EffectRelationship
        {
            AmountType = FantasyGenreEffectTypes.UnarmedDamageAmount,
            PercentageType = FantasyGenreEffectTypes.UnarmedDamagePercentage,
            BonusAmountType = FantasyGenreEffectTypes.UnarmedBonusAmount,
            BonusPercentageType = FantasyGenreEffectTypes.UnarmedBonusPercentage
        };
        
        public static EffectRelationship UnarmedDefenseRelationship => new EffectRelationship
        {
            AmountType = FantasyGenreEffectTypes.UnarmedDefenseAmount,
            PercentageType = FantasyGenreEffectTypes.UnarmedDefensePercentage,
            BonusAmountType = FantasyGenreEffectTypes.UnarmedBonusAmount,
            BonusPercentageType = FantasyGenreEffectTypes.UnarmedBonusPercentage
        };
    }
}