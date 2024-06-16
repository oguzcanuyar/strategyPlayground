using System.Collections.Generic;
using UnityEngine;

namespace World.Mono
{
    public class PoolManager : MonoBehaviour
    {
        public static PoolManager Instance { get; private set; }
        [SerializeField] private PoolObject[] poolObjects;
        private Dictionary<string, Stack<GameObject>> _poolDictionary = new();
        private void Awake()
        {
            Instance = this;
            GeneratePools();
        }

        private void GeneratePools()
        {
            foreach (var poolObject in poolObjects)
            {
                for (var i = 0; i < poolObject.poolAmount; i++)
                {
                    var obj = Instantiate(poolObject.prefab, transform);
                    obj.SetActive(false);
                    if (_poolDictionary.TryGetValue(poolObject.name, out var stack))
                    {
                        stack.Push(obj);
                    }
                    else
                    {
                        _poolDictionary.Add(poolObject.name, new Stack<GameObject>());
                        _poolDictionary[poolObject.name].Push(obj);

                    }
                }
            }
        }

        public GameObject GetPoolObject(string poolIndex)
        {
            if (_poolDictionary.TryGetValue(poolIndex, out var obj))
            {
                return obj.Pop();
            }

            return null;
        }
    }

    [System.Serializable]
    public class PoolObject
    {
        public int poolAmount;
        public string name;
        public GameObject prefab;
    }
}