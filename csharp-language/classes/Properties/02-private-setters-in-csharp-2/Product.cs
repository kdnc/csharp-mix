﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    // You have properties with private setters in C# 2.
    // (which you use in the constructor in C# 1)
    public class Product
    {
        string name;
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        decimal price;
        public decimal Price
        {
            get { return price; }
            private set { price = value; }
        }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public static List<Product> GetSampleProducts()
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("West Side Story", 9.99m));
            list.Add(new Product("Assassins", 14.99m));
            list.Add(new Product("Frogs", 13.99m));
            list.Add(new Product("Sweeney Todd", 10.99m));
            return list;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", name, price);
        }
    }
}
