namespace DesignPatterns.StructuralPatterns.Facade.SampleCode
{
    public class Scanner : IScanner
    {
        public Token Scan()
        {
            // Do something
            return new Token();
        }
    }
}