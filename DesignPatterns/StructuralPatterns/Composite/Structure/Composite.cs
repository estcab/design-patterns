using System.Collections.Generic;

namespace DesignPatterns.StructuralPatterns.Composite.Structure
{
    public class Composite : Component
    {
        private readonly List<Component> _components;

        public Composite()
        {
            _components = new List<Component>();
        }

        public override void Operacion()
        {
            foreach (var component in _components)
            {
                component.Operacion();
            }
        }

        public override void Add(Component component)
        {
            _components.Add(component);
        }

        public override void Remove(Component component)
        {
            _components.Remove(component);
        }

        public override Component GetChild(int position)
        {
            return _components[position];
        }
    }
}

