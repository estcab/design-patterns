namespace DesignPatterns.StructuralPatterns.Facade.SampleCode
{
    public class Parser : IParser
    {
        public void Parse(IScanner scanner, IProgramNodeBuilder nodeBuilder)
        {
            scanner.Scan();

            nodeBuilder.GetRootNode();
        }      
    }
}