namespace DesignPatterns.StructuralPatterns.Composite.Structure
{
    public class Client
    {
        private readonly Component _component;

        public Client()
        {
            this._component = new Composite();
            
            var leaf = new Leaf();
            _component.Add(leaf);

            var composite = new Composite();
            for (int i = 0; i < 5; i++)
            {
                leaf = new Leaf();
                composite.Add(leaf);
            }

            _component.Add(composite);
        }

        public void Operacion()
        {
            _component.Operacion();
        }
    }
}