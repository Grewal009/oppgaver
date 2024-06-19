namespace DangerBug;

public class Tick : Bug
{
    public Tick(string name, bool canBite, bool hasLegs, bool canMove, bool canFly, string problem) : base(name, canBite, hasLegs, canMove, canFly, problem)
    {
    }

    public override string ToString()
    {
        return base.ToString();
    }
}