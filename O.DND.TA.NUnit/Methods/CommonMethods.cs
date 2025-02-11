namespace O.DND.TA.NUnit.Methods
{
    public class CommonMethods
    {
        public static async Task<int> Add(int a, int b)
        {
            await Task.Delay(100); // Simulate an asynchronous operation
            return a + b;
        }

        public static async Task<int> Subtract(int a, int b)
        {
            await Task.Delay(100); // Simulate an asynchronous operation
            return a - b;
        }

        public static async Task<int> Multiply(int a, int b)
        {
            await Task.Delay(100); // Simulate an asynchronous operation
            return a * b;
        }

        public static async Task<double> Divide(int a, int b)
        {
            await Task.Delay(100); // Simulate an asynchronous operation
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return (double)a / b;
        }
    }
}
