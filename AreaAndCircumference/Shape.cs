namespace AreaAndCircumference;

internal abstract class Shape
{
    public int Base { get; private set; }

    protected Shape(int @base)
    {
        Base = @base;
    }

    public abstract void Area();
    public abstract void Circumference();
}