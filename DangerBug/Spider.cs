namespace DangerBug;

public class Spider: Bug
{
    public String GoodStuffs { get; private set; }

    public Spider(string name, bool canBite, bool hasLegs, bool canMove, bool canFly, string problem, string goodStuffs) : base(name, canBite, hasLegs, canMove, canFly, problem)
    {
        GoodStuffs = goodStuffs;
    }

    public override string ToString()
    {
        return base.ToString()+$" Goos stuff:{GoodStuffs}";
    }
}