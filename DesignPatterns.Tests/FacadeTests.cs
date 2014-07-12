using DesignPatterns.StructuralPatterns.Facade.SampleCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class FacadeTests
    {
        private Compiler _compiler;

        [TestMethod]
        public void FacadeSimplifiesInterfaceToSubsystem()
        {
            // Arrange
            var scanner = new Mock<IScanner>();
            var parser = new Mock<IParser>();
            var nodeBuilder = new Mock<IProgramNodeBuilder>();

            scanner.Setup(s => s.Scan());
            nodeBuilder.Setup(nb => nb.GetRootNode());
            parser.Setup(p => p.Parse(scanner.Object, nodeBuilder.Object));
            
            _compiler = new Compiler(scanner.Object, parser.Object, nodeBuilder.Object);

            // Act
            _compiler.Compile();

            // Assert
            scanner.Verify();
            parser.Verify();
            nodeBuilder.Verify();
        }
    }
}
