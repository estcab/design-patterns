using DesignPatterns.StructuralPatterns.Flyweight.SampleCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class FlyweightTests
    {
        private CharacterFactory _characterFactory;

        [TestInitialize]
        public void Initialize()
        {
          _characterFactory = new CharacterFactory();
        }
       

        [TestMethod]
        public void FlyweightShareLargeNumberObjects()
        {
            var line = new Line();

            for (var i = 0; i < 100; i++)
            {
                var c = _characterFactory.GetCharacter("a");
                line.AddCharacter(c);
            }

            Assert.AreEqual<int>(100, line.GetSize());
            Assert.AreEqual<int>(1, _characterFactory.GetSize());

            for (var i = 0; i < 100; i++)
            {
                Assert.AreEqual(line.GetCharacter(i), _characterFactory.GetCharacter("a"));
            }

            
        }
    }
}
