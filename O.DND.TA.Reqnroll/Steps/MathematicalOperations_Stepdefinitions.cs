namespace O.DND.TA.Steps
{
    [Binding]
    public class MathematicalOperations_Stepdefinitions
    {
        private int _number1;
        private int _number2;
        private int _result;
        private double _divisionResult;
        private double _multiplicationResult;
        private double _additionResult;
        private double _subtractionResult;

        [Given(@"the first number is (\d+) and the second number is (\d+)")]
        public void GivenTheFirstNumberIsAndTheSecondNumberIs(int number1, int number2)
        {
            _number1 = number1;
            _number2 = number2;
        }

        [Then(@"the result should be (\d+)")]
        public void ThenTheResultShouldBe(int expectedResult)
        {
            _result.ShouldBe(expectedResult);
        }

        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _additionResult = _number1 + _number2;
        }

        [When(@"the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            _subtractionResult = _number1 - _number2;
        }

        [When(@"the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            _multiplicationResult = _number1 * _number2;
        }

        [When(@"the two numbers are divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            _divisionResult = (double)_number1 / _number2;
        }

        [Then(@"the addition result should be ([\d\.]+)")]
        public void ThenTheAdditionResultShouldBe(double expectedResult)
        {
            _additionResult.ShouldBe(expectedResult);
        }

        [Then(@"the subtraction result should be ([\d\.]+)")]
        public void ThenTheSubtractedResultShouldBe(double expectedResult)
        {
            _subtractionResult.ShouldBe(expectedResult);
        }

        [Then(@"the multiplication result should be ([\d\.]+)")]
        public void ThenTheMultiplicationResultShouldBe(double expectedResult)
        {
            _multiplicationResult.ShouldBe(expectedResult);
        }

        [Then(@"the division result should be ([\d\.]+)")]
        public void ThenTheDivisionResultShouldBe(double expectedResult)
        {
            _divisionResult.ShouldBe(expectedResult);
        }
    }
}