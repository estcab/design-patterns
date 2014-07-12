using System;

namespace DesignPatterns.StructuralPatterns.Flyweight.Structure
{
    class ConcreteFlyweight : IFlyweight
    {
        private int _intrinsicState;

        internal ConcreteFlyweight(int intrinsicState)
        {
            this._intrinsicState = intrinsicState;
        }

        public void Operation(int extrinsicState)
        {
            throw new NotImplementedException();
        }
    }
}