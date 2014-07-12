namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility.Structure
{
    public class ConcreteHandler1 : Handler
    {
        public override string HandleRequest()
        {
            if (CanHandleRequest())
            {
                // Handle request...
            }
            return base.HandleRequest();
        }

        private bool CanHandleRequest()
        {
            return false;
        }
    }
}