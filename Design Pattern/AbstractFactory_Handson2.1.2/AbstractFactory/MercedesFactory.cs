using System;

namespace AFactory
{
    class MercedesFactory : Factory
    {
        public override Headlight MakeHeadLight()
        {
            return new MercedesHeadlight();
        }

        public override Tire MakeTire()
        {
            return new MercedesTire();
        }
    }
}
