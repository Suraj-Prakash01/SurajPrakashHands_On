using System;

namespace Builder
{
    class Director_Shop
    {
        public void Construct(Builder builder)
        {
            builder.BuildSweet();
            builder.BuildSavory();
        }
    }
}