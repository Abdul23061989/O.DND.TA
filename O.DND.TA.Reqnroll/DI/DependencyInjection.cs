namespace O.DND.TA.DI
{
    internal class DependencyInjection
    {
        [ScenarioDependencies]
        public static IWindsorContainer CreateContainer()
        {
            // Create the Windsor container
            var container = new WindsorContainer();

            // Register step definition classes
            container.Register(Component.For<MathematicalOperations_Stepdefinitions>());

            return container;
        }
    }
}