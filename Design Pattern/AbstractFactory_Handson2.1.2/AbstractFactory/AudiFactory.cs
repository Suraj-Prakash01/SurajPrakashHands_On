using System;

namespace AFactory
{
    class AudiFactory : Factory
    {
        public override Headlight MakeHeadLight()
        {
            return new AudiHeadlight();
        }

        public override Tire MakeTire()
        {
            return new AudiTire();
        }
    }
}
