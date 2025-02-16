namespace O.DND.TA.NUnit;

[TestFixture]
public class MathematicalOperationsTests
{
    [Test]
    public async Task TestAddition()
    {
        int result = await MathematicalOperationsMethods.Add(5, 3);
        result.ShouldBe(8); // Shouldly assertion
    }

    [Test]
    public async Task TestSubtraction()
    {
        int result = await MathematicalOperationsMethods.Subtract(5, 3);
        result.ShouldBe(2); // Shouldly assertion
    }

    [Test]
    public async Task TestMultiplication()
    {
        int result = await MathematicalOperationsMethods.Multiply(5, 3);
        result.ShouldBe(15); // Shouldly assertion
    }

    [Test]
    public async Task TestDivision()
    {
        double result = await MathematicalOperationsMethods.Divide(10, 2);
        result.ShouldBe(5.0); // Shouldly assertion
    }
}