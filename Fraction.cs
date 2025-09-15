using System;

public class Fraction
{
    // Private fields
    private int _numerator;
    private int _denominator;

    // Constructors
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        // avoid dividing by zero
        _denominator = (denominator == 0) ? 1 : denominator;
    }

    // Properties (getters and setters)
    public int Numerator
    {
        get { return _numerator; }
        set { _numerator = value; }
    }

    public int Denominator
    {
        get { return _denominator; }
        set 
        { 
            if (value == 0)
            {
                Console.WriteLine("Denominator cannot be zero. Setting to 1.");
                _denominator = 1;
            }
            else
            {
                _denominator = value;
            }
        }
    }

    // Methods
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}
