namespace OpenRpg.Genres.Scifi.Types
{
    public interface IGenreStatsVariableTypes : Genres.Types.GenreStatsVariableTypes
    {
        public static readonly int MaxEnergy = 50;
        public static readonly int Energy = 51;
        public static readonly int MaxArmour = 52;
        public static readonly int Armour = 53;
        public static readonly int MaxShield = 54;
        public static readonly int Shield = 55;
        
        // Attack stats
        public static readonly int PhysicalDamage = 80;
        public static readonly int IonDamage = 81;
        public static readonly int LaserDamage = 82;
        public static readonly int BallisticDamage = 83;
        public static readonly int ExplosiveDamage = 84;
        
        // Defense stats
        public static readonly int PhysicalDefense = 100;
        public static readonly int IonDefense = 101;
        public static readonly int LaserDefense = 102;
        public static readonly int BallisticDefense = 103;
        public static readonly int ExplosiveDefense = 104;
    }
}