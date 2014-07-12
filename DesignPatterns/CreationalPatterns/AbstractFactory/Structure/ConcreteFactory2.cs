namespace DesignPatterns.CreationalPatterns.AbstractFactory.Structure
{
    public class ConcreteFactory2 : AbstractFactory
    {
        public override ProductA CreateProductA()
        {
            return new ProductA2();
        }

        public override ProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
}