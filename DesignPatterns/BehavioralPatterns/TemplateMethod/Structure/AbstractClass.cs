namespace DesignPatterns.BehavioralPatterns.TemplateMethod.Structure
{
    public abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            PrimitiveOperation1();

            PrimitiveOperation2();

            HookOperation();
        }

        protected abstract void PrimitiveOperation1();

        protected abstract void PrimitiveOperation2();

        protected virtual void HookOperation() {}
    }
}
