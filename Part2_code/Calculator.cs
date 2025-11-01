namespace Part2_code;

public class Calculator
{
    public double A { get; }
    public double B { get; }
    public char Operation { get; }

    public Calculator(double a, double b, char operation)
    {
        A = a;
        B = b;
        Operation = operation;
    }

    public double Calculate()
    {
        if (Operation == '+')
        {
            return A + B;
        }
        if (Operation == '-')
        {
            return A - B;
        }
        if (Operation == '*')
        {
            return A * B;
        }
        if (Operation == '/')
        {
            if (B == 0)
                throw new DivideByZeroException("Cannot divide by zero.");
            return A / B;
        }
        throw new InvalidOperationException($"Unsupported operation: {Operation}");
        
    }

}