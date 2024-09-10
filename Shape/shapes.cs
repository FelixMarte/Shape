using System;

public abstract class Shapes
{
    public double Ancho { get; set; }
    public double Alto { get; set; }

    public Shapes(double ancho, double alto)
    {
        Ancho = ancho;
        Alto = alto;
    }

    public abstract double CalculateSurface();
}

public class Rectangle : Shapes
{
    public Rectangle(double ancho, double alto) : base(ancho, alto) { }

    public override double CalculateSurface()
    {
        return Ancho * Alto;
    }
}

public class Triangle : Shapes
{
    public Triangle(double ancho, double alto) : base(ancho, alto) { }

    public override double CalculateSurface()
    {
        return (Ancho * Alto) / 2;
    }
}

public class Circle : Shapes
{
    public Circle(double radio) : base(radio, radio) { }

    public override double CalculateSurface()
    {
        return Math.PI * Math.Pow(Ancho, 2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Ejemplo de figuras geométricas
        Shapes[] shapes = new Shapes[]
        {
            new Rectangle(4, 5),
            new Triangle(4, 5),
            new Circle(3)
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine($"Área de {shape.GetType().Name}: {shape.CalculateSurface()}");
        }
    }
}
