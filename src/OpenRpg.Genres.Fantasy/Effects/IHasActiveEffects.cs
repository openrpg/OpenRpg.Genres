using System.Collections.Generic;

namespace OpenRpg.Genres.Fantasy.Effects
{
    public interface IHasActiveEffects
    {
        IEnumerable<ActiveEffect> ActiveEffects { get; }

        void AddActiveEffect(TemporaryEffect effect);
        void RemoveActiveEffect(TemporaryEffect effect);
    }
}