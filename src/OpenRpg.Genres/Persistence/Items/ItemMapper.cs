using System.Linq;
using OpenRpg.Core.Modifications;
using OpenRpg.Items;
using OpenRpg.Items.Templates;
using OpenRpg.Items.Variables;

namespace OpenRpg.Genres.Persistence.Items
{
    public abstract class ItemMapper : IItemMapper
    {
        public IItem Map(PersistedItem persistedData)
        {
            var itemVariables = new DefaultItemVariables(persistedData.Variables
                .ToDictionary(x => x.Key, x => x.Value));

            return new DefaultItem
            {
                UniqueId = persistedData.Id,
                Variables = itemVariables,
                ItemTemplate = GetItemTemplateFor(persistedData.ItemTemplateId),
                Modifications = persistedData.ModificationTypes.Select(GetModificationsFor)
            };
        }

        public abstract IItemTemplate GetItemTemplateFor(int itemTemplateId);
        public abstract IModification GetModificationsFor(int modificationId);
    }
}