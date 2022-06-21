namespace OpenRpg.Genres.Fantasy.Types
{
    public interface DamageTypes : Genres.Types.DamageTypes
    {
        // Melee types
        public static int SlashingDamage = 50;
        public static int BluntDamage = 51;
        public static int PiercingDamage = 52;
        public static int UnarmedDamage = 53;

        // Magic types
        public static int FireDamage = 80;
        public static int IceDamage = 81;
        public static int EarthDamage = 82;
        public static int WindDamage = 83;
        public static int LightDamage = 84;
        public static int DarkDamage = 85;
    }
}