namespace DangerBug;

public class Mosquito : Bug
{
    public bool CanFly { get; private set; }
    public bool SucksBlood { get; private set; }
    public String Problem { get; private set; }

    public Mosquito(string name, bool canBite, bool hasLegs, bool canMove, bool canFly, bool sucksBlood, string problem) : base(name, canBite, hasLegs, canMove)
    {
        CanFly = canFly;
        SucksBlood = sucksBlood;
        Problem = problem;
    }

    public override string ToString()
    {
        return   base.ToString() + $" Can fly: " +
                 $"{CanFly}, Sucks blood:{SucksBlood}, Problem:{Problem}";
    }
}