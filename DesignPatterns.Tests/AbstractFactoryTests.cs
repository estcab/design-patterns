using DesignPatterns.CreationalPatterns.AbstractFactory.Structure;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class AbstractFactoryTests
    {
        [TestMethod]
        public void AbstractFactoryCreatesFamiliesOfRelatedObjects()
        {
            // Arrange
            var client1 = new Client(new ConcreteFactory1());
            var client2 = new Client(new ConcreteFactory2());

            // Act
            var a1Result = client1.UseProductA();
            var b1Result = client1.UseProductB();

            var a2Result = client2.UseProductA();
            var b2Result = client2.UseProductB();


            // Assert
            Assert.AreEqual<string>("A1", a1Result);
            Assert.AreEqual<string>("B1", b1Result);

            Assert.AreEqual<string>("A2", a2Result);
            Assert.AreEqual<string>("B2", b2Result);
        }
    }
}
