using System.Collections.Generic;

namespace DesignPatterns.StructuralPatterns.Flyweight.Structure
{
    class FlyweightFactory
    {
        private Dictionary<string, IFlyweight> _flyweights;

        public FlyweightFactory()
        {
            this._flyweights = new Dictionary<string, IFlyweight>();
        }

        public IFlyweight GetFlyweight(string key)
        {
            if (_flyweights.ContainsKey(key))
            {
                return _flyweights[key];
            }
            
            IFlyweight concreteFlyweight = new ConcreteFlyweight(int.Parse(key));
            _flyweights.Add(key, concreteFlyweight);
            return concreteFlyweight;
        }
    }
}
