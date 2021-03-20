using System;

namespace Builder
{
    class childBuilder : Builder
    {
        private Product _product = new Product();

        public override void BuildSweet()
        {
            _product.AddSweet(2);
        }

        public override void BuildSavory()
        {
            _product.AddSavory(1);
        }

        public override Product GetResult()
        {
            return _product;
        }
    }
}