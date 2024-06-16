using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace World
{
    public abstract class WorldObject
    {
        private Dictionary<IResource, int> _collectionRatios;
        private int _remainingAmount;

        public IResource Collect()
        {
            var totalWeight = _collectionRatios.Values.Sum();
            var randomValue = Random.Range(0, totalWeight);
            var currentWeight = 0;
            
            foreach (var resourceType in _collectionRatios.Keys)
            {
                currentWeight += _collectionRatios[resourceType];
                if (randomValue <= currentWeight)
                {
                    return resourceType;
                }
            }
            
            Debug.LogError("Resource type not found!");
            return new Wood();
        }
    }
}