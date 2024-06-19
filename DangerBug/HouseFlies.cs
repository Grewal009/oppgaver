namespace DangerBug;

public class HouseFlies : Bug
{
    public bool CanFly { get; private set; }
    public string Problem { get; private set; }

    public HouseFlies(string name, bool canBite, bool hasLegs, bool canMove, bool canFly, string problem) : base(name, canBite, hasLegs, canMove)
    {
        CanFly = canFly;
        Problem = problem;
    }

    public override string ToString()
    {
        return base.ToString() + $" Can fly:{CanFly}, Problem:{Problem}";
    }
}