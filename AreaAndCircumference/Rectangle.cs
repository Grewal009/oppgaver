namespace AreaAndCircumference;

internal class Rectangle : Shape
{
    public int Length { get; private set; }

    public Rectangle(int @base, int length) : base(@base)
    {
        Length = length;
    }

    public override void Area()
    {
        Console.WriteLine($"Area of Rectangle is {Length * Base}");
    }

    public override void Circumference()
    {
        Console.WriteLine(
            $"Circumference of Rectangle is {2 * (Length * Base)}");
    }
}