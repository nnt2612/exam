﻿namespace Exam.entity
{
    public class Product
    {
        private string productId;
        private string productName;
        private int price;

        public Product(string productId, string productName, int price)
        {
            this.productId = productId;
            this.productName = productName;
            this.price = price;
        }

        public Product()
        {
        }

        public string ProductId
        {
            get => productId;
            set => productId = value;
        }

        public string ProductName
        {
            get => productName;
            set => productName = value;
        }

        public int Price
        {
            get => price;
            set => price = value;
        }
    }
}