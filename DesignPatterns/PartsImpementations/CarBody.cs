using FooBarMoters.Interface;

namespace FooBarMoters.PartsImpementations
{
    public class CarBody : IBody
    {
        public virtual string BodyParts { get; } = "Body shell parts for a car";
    }
}