namespace AreaAndCircumference;

internal class Triangle : Shape
{
    public int SideA { get; private set; }
    public int SideB { get; private set; }
    public int SideC { get; private set; }
    public int Height { get; private set; }

    public Triangle(int @base, int sideA, int sideB, int sideC, int height) :
        base(@base)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
        Height = height;
    }

    public override void Area()
    {
        double area = 0.5 * (Base * Height);
        Console.WriteLine($"Area of Triangle is {area}");
    }

    public override void Circumference()
    {
        Console.WriteLine($"Circumference of Triangle is {SideA +
            SideB + SideC}");
    }
}