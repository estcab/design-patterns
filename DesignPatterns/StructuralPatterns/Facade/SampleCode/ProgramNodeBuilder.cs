namespace DesignPatterns.StructuralPatterns.Facade.SampleCode
{
    public class ProgramNodeBuilder : IProgramNodeBuilder
    {
        public ProgramNode GetRootNode()
        {
            // Do something 
            return new ProgramNode();
        }

    }
}