using FooBarMoters.Interface;

namespace FooBarMoters.PartsImpementations
{
    public class CarGlassware : IGlassware
    {
        public virtual string GlasswareParts { get; } = "Window glassware for a car";
    }
}