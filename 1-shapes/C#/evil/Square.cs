using System;

public class Square : Shape
{
    private double length;

    public Square(double length)
    {
        this.length = length;
    }

    public double Length
    {
        get { return this.length;}
        set { this.length = value;}
    }

    override public double ComputeArea() 
    {
        return length * length;
    }
}