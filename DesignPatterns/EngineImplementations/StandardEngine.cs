using FooBarMoters.AbstractImplementations;

namespace FooBarMoters.EngineImplementations
{
    class StandardEngine : AbstractEngine
    {
        public StandardEngine(int size) : base(size, false)
        {
            // not turbocharged
        }
    }
}
