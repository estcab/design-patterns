namespace DesignPatterns.CreationalPatterns.AbstractFactory.Structure
{
    public class ConcreteFactory1 : AbstractFactory
    {
        public override ProductA CreateProductA()
        {            
            return  new ProductA1();
        }

        public override ProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
}