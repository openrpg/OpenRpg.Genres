namespace OpenRpg.Genres.Fantasy.Effects
{
    public class ActiveEffect
    {
        public TemporaryEffect Effect { get; set; }
        public float ActiveTime { get; set; }
        public float TimeSinceProc { get; set; }
    }
}