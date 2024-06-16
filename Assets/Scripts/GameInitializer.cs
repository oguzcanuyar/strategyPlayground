using UnityEngine;
using World;
using World.Mono;

public static class GameInitializer
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
    public static void Initialize()
    {
        var workers = Village.GenerateVillage();
        
        // mono
        VillageGenerator.Instance.GenerateVillage();
        WorkerGenerator.Instance.GenerateWorkers(workers);
    }
}