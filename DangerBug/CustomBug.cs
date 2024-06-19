namespace DangerBug;

public class CustomBug : Bug
{
    public CustomBug(string name, bool canBite, bool hasLegs, bool canMove, bool canFly, string problem) : base(name, canBite, hasLegs, canMove, canFly, problem)
    {
    }

    public override string ToString()
    {
        return base.ToString();
    }
}