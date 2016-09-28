using FooBarMoters.AbstractImplementations;
using FooBarMoters.Interface;

namespace FooBarMoters.VehicleImplementations
{
    class Sport : AbstractCar
    {
        public Sport(IEngine engine, VehicleColor vehicleColor) : base(engine, vehicleColor)
        {
        }

        public Sport(IEngine engine) : this(engine, VehicleColor.Unpainted)
        {
        }
    }
}
