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

    override public void Draw()
    {
        Console.WriteLine(String.Format("I am a square with length {0} and area {1}", Length, ComputeArea()));
    }
}