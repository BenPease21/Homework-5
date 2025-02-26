

public abstract class Shape
{   
    //Variables
    public string Color { get; set; }

    //Constructors 
    public Shape() { /* empty constructor */ }

    public Shape(string color) 
    {
        Color = color; 
    }

    public abstract double GetArea();

    public override string ToString()
    {
        return $"{Color}";
    }
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle() { }
    public Rectangle(string color, double width, double height) : base(color)
    {
        Width = width;
        Height = height; 
    }

    public override double GetArea()
    {
        return (Width * Height);
    }

    public override string ToString()
    {
        return $"{base.ToString()} Rectangle \n Width: {Width}  Height: {Height}  Area: {GetArea()}";
    }

}

public class Cirlce : Shape
{
    public double Radius { get; set; }

    public Cirlce() { }

    public Cirlce(string color, double radius) : base(color) 
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return (Math.PI * Radius * Radius);
    }

    public override string ToString()
    {
        return $"{base.ToString()} Circle \n Radius: {Radius}  Area: {GetArea()}";
    }


}

public class Program
{
    static void Main(string[] args)
    {
        Rectangle Henry = new Rectangle("Blue", 2, 3);
        Console.WriteLine($"{Henry.ToString()}");

        Console.WriteLine("\n");

        Cirlce John = new Cirlce("Green", 2);
        Console.WriteLine($"{John.ToString()}");


    }


}