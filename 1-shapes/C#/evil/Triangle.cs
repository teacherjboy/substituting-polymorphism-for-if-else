using System;

public class Triangle : Shape
{
    private double triangleBase;
    private double height;


    public Triangle(double triangleBase, double height)
    {
        this.triangleBase = triangleBase;
        this.height = height;
    }

    public double Base
    {
        get { return this.triangleBase;}
        set { this.triangleBase = value;}
    }

    public double Height
    {
        get { return this.height;}
        set { this.height = value;}
    }

    override public double ComputeArea() 
    {
        return Base * Height;
    }
}