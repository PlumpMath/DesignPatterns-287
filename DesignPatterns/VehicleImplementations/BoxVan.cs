using FooBarMoters.AbstractImplementations;
using FooBarMoters.Interface;

namespace FooBarMoters.VehicleImplementations
{
    class BoxVan : AbstractVan
    {
        public BoxVan(IEngine engine, VehicleColor vehicleColor) : base(engine, vehicleColor)
        {
        }

        public BoxVan(IEngine engine) : this(engine, VehicleColor.Unpainted)
        {
        }
    }
}
