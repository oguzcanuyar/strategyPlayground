using System.Collections.Generic;

namespace World
{
    public static class Village
    {
        private const int StartWorkerAmount = 5;
        
        public static string Name = "Village1";

        private static readonly LinkedList<Worker> Workers = new();
        
        public static LinkedList<Worker> GenerateVillage()
        {
            for (int i = 0; i < StartWorkerAmount; i++)
            {
                Worker worker = new Worker();
                Workers.AddLast(worker);
            }
            
            return Workers;
        }

        public static bool TryGetUnemployedWorker(out Worker worker)
        {
            foreach (var w in Workers)
            {
                if (w.IsEngineer())
                {
                    worker = w;
                    return true;
                }
            }

            worker = null;
            return false;
        }
    }
}