using System;
using Random = UnityEngine.Random;

public class Worker
{
    private Workspace _workspace;
    private HumanData _humanData;

    public Worker()
    {
        _humanData = new HumanData();
        _humanData.GenerateRandomHumanData();
    }

    public bool IsEngineer()
    {
        return _workspace == null;
    }
}

public class HumanData
{
    private int Age;
    private string Name;

    public void GenerateRandomHumanData()
    {
        Age = Random.Range(0, 45);
        Name = "Human" + Age;
    }
}