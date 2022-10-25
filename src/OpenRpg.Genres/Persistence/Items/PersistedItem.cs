using System;
using System.Collections.Generic;
using System.Linq;
using OpenRpg.Items;

namespace OpenRpg.Genres.Persistence.Items
{
    public class PersistedItem
    {
        public Guid Id { get; }
        public int ItemTemplateId { get; }
        public int[] ModificationTypes { get; }
        public IReadOnlyDictionary<int, object> Variables { get; }

        public PersistedItem(Guid id, int itemTemplateId, int[] modificationTypes, Dictionary<int, object> variables = null)
        {
            Id = id;
            ItemTemplateId = itemTemplateId;
            ModificationTypes = modificationTypes;
            Variables = variables ?? new Dictionary<int, object>();
        }
        
        public PersistedItem(IUniqueItem item)
        {
            Id = item.UniqueId;
            ItemTemplateId = item.ItemTemplate.Id;
            ModificationTypes = item.Modifications.Select(x => x.Id).ToArray();
            Variables = item.Variables;
        }
    }
}