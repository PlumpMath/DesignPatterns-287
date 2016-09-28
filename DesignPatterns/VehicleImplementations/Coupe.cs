using FooBarMoters.AbstractImplementations;
using FooBarMoters.Interface;

namespace FooBarMoters.VehicleImplementations
{
    class Coupe : AbstractCar
    {
        public Coupe(IEngine engine, VehicleColor vehicleColor) : base(engine, vehicleColor)
        {
        }

        public Coupe(IEngine engine) : this(engine, VehicleColor.Unpainted)
        {
        }
    }
}
