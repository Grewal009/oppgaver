namespace DangerBug;

public class Spider: Bug
{
    public String GoodStuffs { get; private set; }
    public string Problem { get; private set; }

    public Spider(string name, bool canBite, bool hasLegs, bool canMove, string goodStuffs, string problem) : base(name, canBite, hasLegs, canMove)
    {
        GoodStuffs = goodStuffs;
        Problem = problem;
    }

    public override string ToString()
    {
        return base.ToString()+$" Goos stuff:{GoodStuffs}, Problem:{Problem}";
    }
}