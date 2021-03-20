using System;
using System.Collections.Generic;

namespace Builder
{
    class Product
    {
        private int noOfSweet;
        private int noOfSavory;

        public Product()
        {
            noOfSweet = 0;
            noOfSavory = 0;
        }

        public void AddSweet(int count)
        {
            noOfSweet += count;
        }

        public void AddSavory(int count)
        {
            noOfSavory += count;
        }

        public void Show()
        {
           
                Console.WriteLine($"Package  contains\n {noOfSweet} Sweets \n {noOfSavory} Savories");
           
        }
    }
}