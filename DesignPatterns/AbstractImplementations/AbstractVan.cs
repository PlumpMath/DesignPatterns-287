using FooBarMoters.Interface;

namespace FooBarMoters.AbstractImplementations
{
    class AbstractVan : AbstractVehicle
    {

        public AbstractVan(IEngine engine, VehicleColor vehicleColor) : base(engine, vehicleColor)
        {
        }

        public AbstractVan(IEngine engine) : this(engine, VehicleColor.Unpainted)
        {
        }
    }
}
