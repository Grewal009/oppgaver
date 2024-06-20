namespace AreaAndCircumference;

internal class Square : Shape
{
    public Square(int @base) : base(@base)
    {
    }

    public override void Area()
    {
        Console.WriteLine($"Area of Square is {Base * Base}");
    }

    public override void Circumference()
    {
        Console.WriteLine($"Circumference of Square is {4 * Base}");
    }
}