using System;
using UnityEngine;
using World;

namespace UI
{
    public class ResourcePanel : MonoBehaviour
    {
        private void Update()
        {
            Debug.Log(ResourceManager.Get(ResourceType.Wood).GetAmount());
        }
    }
}