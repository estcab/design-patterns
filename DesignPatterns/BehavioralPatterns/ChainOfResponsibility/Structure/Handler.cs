
namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility.Structure
{
    public abstract class Handler
    {
        public Handler Successor { get; set; }

        public virtual string HandleRequest()
        {
            if (Successor != null)
            {
                return Successor.HandleRequest();
            }

            return string.Empty;
        }
    }
}
