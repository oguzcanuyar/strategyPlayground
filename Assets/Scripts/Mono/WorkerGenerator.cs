using System.Collections.Generic;
using UnityEngine;

namespace World.Mono
{
    public class WorkerGenerator : MonoBehaviour
    {
        public static WorkerGenerator Instance { get; private set; }

        private void Awake()
        {
            Instance = this;
        }

        public void GenerateWorkers(LinkedList<Worker> workers)
        {
            foreach (var worker in workers)
            {
                var obj = PoolManager.Instance.GetPoolObject("WORKER");
                obj.transform.position = Vector3.zero;
                obj.SetActive(true);
            }
        }
    }
}