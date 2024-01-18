// See https://aka.ms/new-console-template for more information

public class Shape
{
    private int x;
    private int y;
    public Shape()
    {
    }
    public Shape(int xValue, int yValue)
    {
        x = xValue;
        y = yValue;
    }
    public int X
    {  // Set X property	
        get
        {
            return x;
        }
        set
        {
            x = value;
        }
    }
    public void SetValues(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public int Y
    {
        get
        {
            return y;
        }
        set
        {
            y = value;
        }
    }
}