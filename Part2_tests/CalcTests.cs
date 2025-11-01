using Part2_code;

public class Tests
{
    [Test]
    public void TestAddition()
    {
        var calc = new Calculator(8, 12, '+');
        Assert.That(calc.Calculate(), Is.EqualTo(20));
    }

    [Test]
    public void TestSubtraction()
    {
        var calc = new Calculator(25, 7, '-');
        Assert.That(calc.Calculate(), Is.EqualTo(18));
    }

    [Test]
    public void TestMultiplication()
    {
        var calc = new Calculator(6, 9, '*');
        Assert.That(calc.Calculate(), Is.EqualTo(54));
    }

    [Test]
    public void TestDivision()
    {
        var calc = new Calculator(20, 4, '/');
        Assert.That(calc.Calculate(), Is.EqualTo(5));
    }

    [Test]
    public void TestDivisionByZero()
    {
        var calc = new Calculator(15, 0, '/');
        Assert.Throws<DivideByZeroException>(() => calc.Calculate());
    }

    [Test]
    public void TestInvalidOperation()
    {
        var calc = new Calculator(10, 5, '^');
        Assert.Throws<InvalidOperationException>(() => calc.Calculate());
    }

    [Test]
    public void TestNegativeNumbers()
    {
        var calc = new Calculator(-8, -3, '+');
        Assert.That(calc.Calculate(), Is.EqualTo(-11));
    }

    [Test]
    public void TestFloatingPoint()
    {
        var calc = new Calculator(7.5, 2.5, '/');
        Assert.That(calc.Calculate(), Is.EqualTo(3.0).Within(0.001));
    }
}