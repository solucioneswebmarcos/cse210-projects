using System;

public class Fraction
{
    private int _top;
    private int _bottom;
    public Fraction()
    {
        _bottom = 1;
        _top = 1;
    }
    public Fraction(int top)
    {
        _bottom = 1;
        _top = top;
    }
    public Fraction(int top, int bottom)
    {
        _bottom = bottom;
        _top = top;
    }
    public string GetFraction()
    {
        string fraction = $"{_top}/{_bottom}";
        return fraction;
    }
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom; 
    }
}
        
