using System;

namespace DesignPatterns.StructuralPatterns.Composite.Structure
{
    public class Leaf : Component
    {
        public override void Operacion()
        {
            // Do something here
        }

        public override void Add(Component component)
        {
            throw new InvalidOperationException();
        }

        public override void Remove(Component component)
        {
            throw new InvalidOperationException();
        }

        public override Component GetChild(int position)
        {
            throw new InvalidOperationException();
        }
    }
}