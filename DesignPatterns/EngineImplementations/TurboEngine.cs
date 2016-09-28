using FooBarMoters.AbstractImplementations;

namespace FooBarMoters.EngineImplementations
{
    class TurboEngine : AbstractEngine
    {
        public TurboEngine(int size, bool turbo) : base(size, true)
        {
            // turbocharged
        }
    }
}
