using FooBarMoters.AbstractImplementations;
using FooBarMoters.Interface;

namespace FooBarMoters.VehicleImplementations
{
    class Pickup : AbstractVan
    {
        public Pickup(IEngine engine, VehicleColor vehicleColor) : base(engine, vehicleColor)
        {
        }

        public Pickup(IEngine engine) : this(engine, VehicleColor.Unpainted)
        {
        }
    }
}
