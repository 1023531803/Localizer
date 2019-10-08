using System.Collections.Generic;
using System.Linq;
using Localizer.Attributes;

namespace Localizer.DataModel.Default
{
    public class ProjectileEntry : IEntry
    {
        [ModTranslationProp("DisplayName")] public BaseEntry Name { get; set; }

        public IEntry Clone()
        {
            return new ProjectileEntry {Name = Name.Clone() as BaseEntry};
        }
    }

    public class BasicProjectileFile : IFile
    {
        [ModTranslationOwnerField("projectiles")]
        public Dictionary<string, ProjectileEntry> Projectiles { get; set; } = new Dictionary<string, ProjectileEntry>();

        public List<string> GetKeys()
        {
            return Projectiles.Keys.ToList();
        }

        public IEntry GetValue(string key)
        {
            return Projectiles[key];
        }
    }
}
