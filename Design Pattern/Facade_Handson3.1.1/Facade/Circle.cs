using System;

namespace Facade
{
    class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw a Circle");
        }
    }
}
