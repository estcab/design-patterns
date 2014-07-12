namespace DesignPatterns.StructuralPatterns.Flyweight.Structure
{
    class UnsharedConcreteFlyweight : IFlyweight
    {
        private int _allState;

        internal UnsharedConcreteFlyweight(int allState)
        {
            _allState = allState;
        }

        public void Operation(int extrinsicState)
        {
            throw new System.NotImplementedException();
        }
    }
}