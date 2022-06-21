namespace OpenRpg.Genres.Fantasy.Types
{
    public interface StatsVariableTypes : Genres.Types.StatsVariableTypes
    {
        public static int MaxMagic = 50;
        
        // Base stats
        public static int Strength = 60;
        public static int Dexterity = 61;
        public static int Constitution = 62;
        public static int Intelligence = 63;
        public static int Wisdom = 64;
        public static int Charisma = 65;

        // Attack stats
        public static int SlashingDamage = 80;
        public static int BluntDamage = 81;
        public static int PiercingDamage = 82;
        public static int UnarmedDamage = 83;
        public static int FireDamage = 84;
        public static int IceDamage = 85;
        public static int EarthDamage = 86;
        public static int WindDamage = 87;
        public static int LightDamage = 88;
        public static int DarkDamage = 89;
        
        // Defense stats
        public static int SlashingDefense = 100;
        public static int BluntDefense = 101;
        public static int PiercingDefense = 102;
        public static int UnarmedDefense = 103;
        public static int FireDefense = 104;
        public static int IceDefense = 105;
        public static int EarthDefense = 106;
        public static int WindDefense = 107;
        public static int LightDefense = 108;
        public static int DarkDefense = 109;
    }
}