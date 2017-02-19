using System;

public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double Radius
    {
        get { return this.radius;}
        set { this.radius = value;}
    }

    override public double ComputeArea() 
    { 
        return Math.PI * Math.Pow(radius, 2);
    }
}