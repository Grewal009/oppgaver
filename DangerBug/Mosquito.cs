namespace DangerBug;

public class Mosquito : Bug
{
    
    public bool SucksBlood { get; private set; }

    public Mosquito(string name, bool canBite, bool hasLegs, bool canMove, bool canFly, string problem, bool sucksBlood) : base(name, canBite, hasLegs, canMove, canFly, problem)
    {
        SucksBlood = sucksBlood;
    }

    public override string ToString()
    {
        return   base.ToString() + $" Can fly: " +
                 $"{CanFly}, Sucks blood:{SucksBlood}";
    }
}