using System;
public class Fraction
{
    private int _top;
    private int _bottom;

    // Default constructor → 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // One-parameter constructor → top/1
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Two-parameter constructor → top/bottom (with safety)
    public Fraction(int top, int bottom)
    {
        _top = top;
        SetBottom(bottom); // uses your validation
    }

    // Setters
    public void SetTop(int top)
    {
        _top = top;
    }

    public void SetBottom(int bottom)
    {
        // Your safety check preserved
        if (bottom != 0)
        {
            _bottom = bottom;
        }
        else
        {
            _bottom = 1;
        }
    }

    // Getters
    public int GetTop()
    {
        return _top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    // Returns "a/b"
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Returns decimal value
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}