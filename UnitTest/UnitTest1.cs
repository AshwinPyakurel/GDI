using GPLA;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsShapeEquals_Circle_ReturnTrue()
        {
            var shapeFactoryDef = new ShapeFactoryDefination();
            bool result = shapeFactoryDef.isCircle("circle");

            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void ToCheckWeatherTheTypeIS_Shape_ReturnTrue()
        {
            var factoryProducerDef = new FactoryProducerDefination();
            bool result = factoryProducerDef.isShape("shape");

            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void IsShapeEquals_Rectangle_ReturnTrue()
        {
            var shapeFactoryDef = new ShapeFactoryDefination();
            bool result = shapeFactoryDef.isRectangle("rectangle");

            Assert.AreEqual(true, result);
        }
    }
}
