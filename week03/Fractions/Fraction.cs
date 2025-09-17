public class Fraction
{
    private int _numerator = 1;
    private int _denominator = 1;

    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public int Getnumerator()
    {
        return _numerator;
    }

    public void Setnumerator(int numerator)
    {
        _numerator = numerator;
    }

    public int Getdenominator()
    {
        return _denominator;
    }

    public void Setdenominator(int denominator)
    {
        _denominator = denominator;
    }

    public string Returnfraction()
    {
        string fraction = Convert.ToString(_numerator) + "/" + Convert.ToString(_denominator);
        return fraction;
    }

    public double Returndecimal()
    {
        double decim = (double)_numerator / (double)_denominator;
        return decim;
    }

}