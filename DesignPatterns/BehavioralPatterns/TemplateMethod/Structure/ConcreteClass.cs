using System;

namespace DesignPatterns.BehavioralPatterns.TemplateMethod.Structure
{
    public class ConcreteClass : AbstractClass
    {
        protected override void PrimitiveOperation1()
        {
            throw new NotImplementedException();
        }

        protected override void PrimitiveOperation2()
        {
            throw new NotImplementedException();
        }

        protected override void HookOperation()
        {
            base.HookOperation();
        }
    }
}