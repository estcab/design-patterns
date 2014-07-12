using System.Collections.Generic;

namespace DesignPatterns.BehavioralPatterns.Strategy.Structure
{
    public class Client
    {
        public void UseContext()
        {
            var strategies = new List<IStrategy>
            {
                new ConcreteStrategy1(),
                new ConcreteStrategy2(),
                new ConcreteStrategy3()
            };


            var context = new Context(strategies[1]);
            context.DoWork();
        }
    }
}
