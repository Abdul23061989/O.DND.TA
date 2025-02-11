namespace O.DND.TA.NUnit.Base
{
    public class Hooks
    {
        public Hooks() { }

        [OneTimeSetUp]
        public void Setup() { }

        [SetUp]
        public void Init() { }

        [TearDown]
        public void Cleanup() { }

        [OneTimeTearDown]
        public void Teardown() { }
    }
}