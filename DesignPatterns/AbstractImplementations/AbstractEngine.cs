using FooBarMoters.Interface;

namespace FooBarMoters.AbstractImplementations
{
    class AbstractEngine : IEngine
    {
        public AbstractEngine(int size, bool turbo)
        {
            Size = size;
            Turbo = turbo;
        }

        public virtual int Size { get; }
        public virtual bool Turbo { get; }

        public override string ToString()
        {
            return $"{nameof(AbstractEngine)} ({Size})";
        }
    }
}
