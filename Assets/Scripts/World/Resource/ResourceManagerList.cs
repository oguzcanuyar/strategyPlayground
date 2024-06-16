using System.Collections.Generic;

namespace World
{
    public partial class ResourceManager
    {
        private static Dictionary<ResourceType, IResource> _dictionary = new ()
        {
            [ResourceType.Wood] = new Wood(),
            [ResourceType.Stone] = new Stone()
        };
    }
}