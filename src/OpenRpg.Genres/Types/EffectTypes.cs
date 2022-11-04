namespace OpenRpg.Genres.Types
{
    public interface EffectTypes
    {
        public static readonly int UnknownBonus = 0;
        
        // Pure Damage Types
        public static readonly int DamageBonusAmount = 1;
        public static readonly int DamageBonusPercentage = 2;
        
        public static readonly int DefenseBonusAmount = 10;
        public static readonly int DefenseBonusPercentage = 11;
    }
}