using FooBarMoters.Factories;
using FooBarMoters.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FooBarMotersTest
{
    [TestClass]
    public class AbstractFactoryTests
    {
        [TestMethod]
        public void CarFactoryTests()
        {

            AbstractVehicleFactory factory = new CarFactory();

            IBody vehicleBody = factory.CreateBody();
            IChassis vehicleChassis = factory.CreateChassis();
            IGlassware vehicleGlassware = factory.CreateGlassware();

            Assert.AreEqual(expected: "Body shell parts for a car", actual: vehicleBody.BodyParts);
            Assert.AreEqual(expected: "Chassis parts for a car", actual: vehicleChassis.ChassisParts);
            Assert.AreEqual(expected: "Window glassware for a car", actual: vehicleGlassware.GlasswareParts);
        }

        [TestMethod]
        public void VanFactoryTests()
        {

            AbstractVehicleFactory factory = new VanFactory();

            IBody vehicleBody = factory.CreateBody();
            IChassis vehicleChassis = factory.CreateChassis();
            IGlassware vehicleGlassware = factory.CreateGlassware();

            Assert.AreEqual(expected: "Body shell parts for a van", actual: vehicleBody.BodyParts);
            Assert.AreEqual(expected: "Chassis parts for a van", actual: vehicleChassis.ChassisParts);
            Assert.AreEqual(expected: "Window glassware for a van", actual: vehicleGlassware.GlasswareParts);
        }


    }
}
