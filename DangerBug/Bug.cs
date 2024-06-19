namespace DangerBug;

public class Bug
{
    public string Name { get; private set; }
    public bool CanBite { get; private set; }
    public bool HasLegs { get; private set; }
    public bool CanMove { get; private set; }

    public Bug(string name, bool canBite, bool hasLegs, bool canMove)
    {
        Name = name;
        CanBite = canBite;
        HasLegs = hasLegs;
        CanMove = canMove;
    }

    public override string ToString()
    {
        return
            $"Name:{Name}, Can bite:{CanBite}, Has legs:{HasLegs},Can move:{CanMove}";
    }
}