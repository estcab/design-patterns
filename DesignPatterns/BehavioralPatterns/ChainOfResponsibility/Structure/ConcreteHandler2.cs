namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility.Structure
{
    public class ConcreteHandler2 : Handler
    {

        public override string HandleRequest()
        {
            if (CanHandleRequest())
            {
                return "ConcreteHandler2";
            }
            return base.HandleRequest();
        }

        private bool CanHandleRequest()
        {
            return true;
        }
    }
}