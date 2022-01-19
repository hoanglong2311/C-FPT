namespace Excersise_4;

public class Fraction
{
    protected int Mau, Tu;
    
    public Fraction()
    {
        Mau = 1;
        Tu = 0;
    }

    public Fraction(int mau, int tu)
    {
        Mau = mau;
        Tu = tu;
    }

    public void Input()
    {
        int a = 0; int b = 0;
        Console.WriteLine("Enter fraction [a/b]: ");
        InputFraction(ref a, ref b);
        this.Tu = a;
        this.Mau = b;
    }

    public void InputFraction(ref int a, ref int b)
    {
        string input = Console.ReadLine();
        string[] arr = input.Split('/');
        a = int.Parse(arr[0]);
        b = int.Parse(arr[1]);
    }
    
    public void Display()
    {
        Console.WriteLine("{0}/{1}", this.Tu, this.Mau);
    }
    
    public void Add(Fraction f)
    {
        int a = 0; int b = 0;
        a = this.Tu * f.Mau + f.Tu * this.Mau;
        b = this.Mau * f.Mau;
        this.Tu = a;
        this.Mau = b;
    }
    
    public void Add(int a, int b)
    {
        this.Tu = this.Tu * b + a * this.Mau;
        this.Mau = this.Mau * b;
    }
    
    public Fraction Subtract(Fraction f)
    {
        if (this.Tu != 0)
        {
            Fraction f1 = new Fraction();
            f1.Tu = this.Tu * f.Mau - f.Tu * this.Mau;
            f1.Mau = this.Mau * f.Mau;
            return f1;
        }
        else
        {
            Fraction f1 = new Fraction();
            f1.Tu = -f.Tu * this.Mau;
            f1.Mau = f.Mau * this.Mau;
            return f1;
        }
    }
    
    public Fraction Multiple(Fraction f)
    {
        if (this.Tu != 0)
        {
            Fraction f1 = new Fraction();
            f1.Tu = this.Tu * f.Tu;
            f1.Mau = this.Mau * f.Mau;
            return f1;
        }
        else
        {
            Fraction f1 = new Fraction();
            f1.Tu = 0;
            f1.Mau = 1;
            return f1;
        }
    }
    
    public Fraction Divide(Fraction f)
    {
        if (f.Tu != 0)
        {
            Fraction f1 = new Fraction();
            f1.Tu = this.Tu * f.Mau;
            f1.Mau = this.Mau * f.Tu;
            return f1;
        }
        else
        {
            Fraction f1 = new Fraction();
            f1.Tu = 0;
            f1.Mau = 1;
            return f1;
        }
    }
    
    
    private int GCD(int a, int b)
    {
        if (b == 0)
            return a;
        else
            return GCD(b, a % b);
    }
    
    public void Reduce()
    {
        int gcd = GCD(this.Mau, this.Tu);
        this.Mau = this.Mau / gcd;
        this.Tu = this.Tu / gcd;
    }

}