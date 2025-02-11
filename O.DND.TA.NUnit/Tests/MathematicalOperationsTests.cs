namespace O.DND.TA.NUnit;

[TestFixture]
public class MathematicalOperationsTests
{
    [Test]
    public async Task TestAddition()
    {
        int result = await CommonMethods.Add(5, 3);
        result.ShouldBe(8); // Shouldly assertion
    }

    [Test]
    public async Task TestSubtraction()
    {
        int result = await CommonMethods.Subtract(5, 3);
        result.ShouldBe(2); // Shouldly assertion
    }

    [Test]
    public async Task TestMultiplication()
    {
        int result = await CommonMethods.Multiply(5, 3);
        result.ShouldBe(15); // Shouldly assertion
    }

    [Test]
    public async Task TestDivision()
    {
        double result = await CommonMethods.Divide(10, 2);
        result.ShouldBe(5.0); // Shouldly assertion
    }
}