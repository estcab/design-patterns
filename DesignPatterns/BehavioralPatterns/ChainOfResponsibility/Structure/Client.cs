namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility.Structure
{
    public class Client
    {
        private readonly Handler _handler;

        public Client(Handler handler)
        {
            _handler = handler;
        }

        public string DoWork()
        {
            return _handler.HandleRequest();
        }
    }
}