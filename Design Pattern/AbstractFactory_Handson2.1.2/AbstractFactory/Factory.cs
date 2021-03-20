using System;

namespace AFactory
{
    abstract class Factory
    {
        public abstract Headlight MakeHeadLight();

        public abstract Tire MakeTire();
    }
}
