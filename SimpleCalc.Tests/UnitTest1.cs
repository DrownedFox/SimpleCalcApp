using Xunit;

public class CalculatorTests
{
    [Fact]
    public void Add_ReturnsCorrectSum()
    {
        var calc = new Calculator();
        Assert.Equal(5, calc.Add(2, 3));
    }
}
