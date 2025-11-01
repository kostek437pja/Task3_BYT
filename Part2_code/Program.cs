using Part2_code;

    try
    {
        Console.Write("Choose A: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Choose B: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Choose operation +, -, * or /:");
        char op = Console.ReadKey().KeyChar;
        Console.WriteLine();

        var calculator = new Calculator(a, b, op);
        double result = calculator.Calculate();

        Console.WriteLine($"Result: {result}");
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid number format.");
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine(ex.Message);
    }
