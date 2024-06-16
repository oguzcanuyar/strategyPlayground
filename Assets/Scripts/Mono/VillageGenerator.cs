using UnityEngine;

namespace World.Mono
{
    public class VillageGenerator : MonoBehaviour
    {
        public static VillageGenerator Instance { get; private set; }

        private void Awake()
        {
            Instance = this;
        }

        public void GenerateVillage()
        {
        }
    }
}