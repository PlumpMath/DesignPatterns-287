using FooBarMoters.Interface;

namespace FooBarMoters.PartsImpementations
{
    public class VanChassis : IChassis
    {
        public virtual string ChassisParts { get; } = "Chassis parts for a van";
    }
}