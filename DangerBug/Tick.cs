namespace DangerBug;

public class Tick : Bug
{
    public string Problem { get; private set; }

    public Tick(string name, bool canBite, bool hasLegs, bool canMove, string problem) : base(name, canBite, hasLegs, canMove)
    {
        Problem = problem;
    }

    public override string ToString()
    {
        return base.ToString()+$" Problem:{Problem}";
    }
}