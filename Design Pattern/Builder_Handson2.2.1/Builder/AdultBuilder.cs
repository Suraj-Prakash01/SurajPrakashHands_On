using System;

namespace Builder
{
    class AdultBuilder : Builder
    {
        private Product _product = new Product();

        public override void BuildSweet()
        {
            _product.AddSweet(2);
        }

        public override void BuildSavory()
        {
            _product.AddSavory(2);
        }

        public override Product GetResult()
        {
            return _product;
        }
    }
}