namespace FooBarMoters.Interface
{
    interface IVehicle
    {
        IEngine Engine { get; }
        VehicleColor Color { get; }

        void Paint(VehicleColor vehicleColor);
    }
}
