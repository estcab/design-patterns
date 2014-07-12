namespace DesignPatterns.StructuralPatterns.Facade.SampleCode
{
    public class Compiler
    {
        private readonly IScanner _scanner;
        private readonly IParser _parser;
        private readonly IProgramNodeBuilder _nodeBuilder;

        public Compiler()
        {
            this._scanner = new Scanner();
            this._parser = new Parser();
            this._nodeBuilder = new ProgramNodeBuilder();
        }

        public Compiler(IScanner scanner, IParser parser, IProgramNodeBuilder nodeBuilder)
        {
            this._scanner = scanner;
            this._parser = parser;
            this._nodeBuilder = nodeBuilder;
        }

        public void Compile()
        {
            _parser.Parse(_scanner, _nodeBuilder);

            // ...
        }
    }
}
