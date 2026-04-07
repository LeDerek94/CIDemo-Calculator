using CIDemoCalculator;
using Xunit;

public class CalculatorTests
{
    private readonly ICalculator _calculator = new Calculator();

    // --- Add ---
    [Fact]
    public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
        => Assert.Equal(5, _calculator.Add(2, 3));

    [Fact]
    public void Add_NegativeNumbers_ReturnsCorrectSum()
        => Assert.Equal(-1, _calculator.Add(-3, 2));

    // --- Subtract ---
    [Fact]
    public void Subtract_TwoNumbers_ReturnsCorrectDifference()
        => Assert.Equal(1, _calculator.Subtract(3, 2));

    [Fact]
    public void Subtract_ResultIsNegative_ReturnsNegative()
        => Assert.Equal(-1, _calculator.Subtract(2, 3));

    // --- Multiply ---
    [Fact]
    public void Multiply_TwoPositiveNumbers_ReturnsCorrectProduct()
        => Assert.Equal(6, _calculator.Multiply(2, 3));

    [Fact]
    public void Multiply_ByZero_ReturnsZero()
        => Assert.Equal(0, _calculator.Multiply(5, 0));

    // --- Divide ---
    [Fact]
    public void Divide_TwoNumbers_ReturnsCorrectResult()
        => Assert.Equal(2.5, _calculator.Divide(5, 2));

    [Fact]
    public void Divide_ByZero_ThrowsDivideByZeroException()
        => Assert.Throws<DivideByZeroException>(() => _calculator.Divide(5, 0));
}