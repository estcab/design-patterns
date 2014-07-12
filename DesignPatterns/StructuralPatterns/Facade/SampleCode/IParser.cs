namespace DesignPatterns.StructuralPatterns.Facade.SampleCode
{
    public interface IParser
    {
        void Parse(IScanner scanner, IProgramNodeBuilder nodeBuilder);
    }
}