using System;
using FooBarMoters.Interface;

namespace FooBarMoters.AbstractImplementations
{
    abstract class AbstractVehicle : IVehicle
    {

        public virtual IEngine Engine { get; private set; }
        public virtual VehicleColor Color { get; private set; }

        public AbstractVehicle(IEngine engine, VehicleColor vehicleColor)
        {
            Engine = engine;
            Color = vehicleColor;
        }

        public AbstractVehicle(IEngine engine) : this(engine, VehicleColor.Unpainted)
        {
        }

        public void Paint(VehicleColor vehicleColor)
        {
            Color = vehicleColor;
        }

        public override string ToString()
        {
            return $"{nameof(AbstractVehicle)} {Engine} ,{Color}";
        }
    }
}
