namespace AreaAndCircumference;

internal class Calculator
{
    private List<Shape> shapes = new List<Shape>()
    {
        new Triangle(15, 15, 10, 5, 8),
        new Rectangle(10, 4),
        new Square(11)
    };

    public void DisplayAllCalculations()
    {
        Console.WriteLine(
            "Calculations of Shapes:\n-----------------------------------");
        foreach (var shape in shapes)
        {
            shape.Area();
            shape.Circumference();
            Console.WriteLine();
        }
    }
}