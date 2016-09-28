using FooBarMoters.AbstractImplementations;
using FooBarMoters.Interface;

namespace FooBarMoters.VehicleImplementations
{
    class Saloon : AbstractCar
    {
        public Saloon(IEngine engine, VehicleColor vehicleColor) : base(engine, vehicleColor)
        {
        }

        public Saloon(IEngine engine) : this(engine, VehicleColor.Unpainted)
        {
        }
    }
}
