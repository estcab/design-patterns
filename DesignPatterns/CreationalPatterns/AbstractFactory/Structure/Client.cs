namespace DesignPatterns.CreationalPatterns.AbstractFactory.Structure
{
    public class Client
    {
        private readonly AbstractFactory _factory;

        private ProductA _productA;
        private ProductB _productB;

        public Client(AbstractFactory factory)
        {
            _factory = factory;
        }

        public string UseProductA()
        {
            _productA = _factory.CreateProductA();
            return _productA.DoA();
        }

        public string UseProductB()
        {
            _productB = _factory.CreateProductB();
            return _productB.DoB();            
        }
    }
}