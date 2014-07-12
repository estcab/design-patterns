namespace DesignPatterns.BehavioralPatterns.Strategy.Structure
{
    public class Context
    {
        private readonly IStrategy _strategy;

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void DoWork()
        {
            _strategy.AlgorithmInterface();
        }
    }
}
