using FooBarMoters.Interface;

namespace FooBarMoters.PartsImpementations
{
    public class VanGlassware : IGlassware
    {
        public virtual string GlasswareParts { get; } = "Window glassware for a van";
    }
}