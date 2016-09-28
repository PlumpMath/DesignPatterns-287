using FooBarMoters.Interface;

namespace FooBarMoters.AbstractImplementations
{
    class AbstractCar : AbstractVehicle
    {
        public AbstractCar(IEngine engine, VehicleColor vehicleColor) : base(engine, vehicleColor)
        {
        }

        public AbstractCar(IEngine engine) : this(engine, VehicleColor.Unpainted)
        {
        }
    }
}
