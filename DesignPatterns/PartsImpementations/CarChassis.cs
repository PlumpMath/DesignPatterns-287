using FooBarMoters.Interface;

namespace FooBarMoters.PartsImpementations
{
    public class CarChassis : IChassis
    {
        public virtual string ChassisParts { get; } = "Chassis parts for a car";
    }
}