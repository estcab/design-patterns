namespace DesignPatterns.StructuralPatterns.Composite.Structure
{
    public abstract class Component
    {
        public abstract void Operacion();
        public abstract void Add(Component component);
        public abstract void Remove(Component component);
        public abstract Component GetChild(int position);
    }
}
