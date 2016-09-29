using FooBarMoters.Interface;

namespace FooBarMoters.PartsImpementations
{
    public class VanBody : IBody
    {
        public virtual string BodyParts { get; } = "Body shell parts for a van";
    }
}