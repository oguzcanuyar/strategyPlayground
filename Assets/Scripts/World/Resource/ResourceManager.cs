using System;
using System.Collections.Generic;

namespace World
{
    public static partial class ResourceManager
    {
        private static Action<ResourceType> _onResourceAmountUpdate;


        public static void OnResourceAmountUpdate(ResourceType resourceType)
        {
            _onResourceAmountUpdate.Invoke(resourceType);
        }
        
        public static IResource Get(ResourceType resourceType)
        {
            return _dictionary[resourceType];
        }
    }
}