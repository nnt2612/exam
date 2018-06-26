using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Exam.entity;
using Exam.utility;

namespace Exam.controller
{
    public class ProductController
    {
        
        private static List<Product> listProduct = new List<Product>();
        public void Add()
        {          
            Console.WriteLine("Product ID: ");
            var id = Console.ReadLine();
            Console.WriteLine("Product Name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Price: ");
            var price = Utility.GetInt32Number();
            listProduct.Add(new Product(id, name, price));
        }

        public void Display()
        {
            Console.WriteLine(String.Format("{0,15}|{1,15}|{2,15}",
                    "Product ID", "Product Name", "Product Delete"));
            foreach (var product in listProduct)
            {
                Console.WriteLine(String.Format("{0,15}|{1,15}|{2,15}",
                  product.ProductId , product.ProductName, product.Price));
            }
            
        }

        public void Delete()
        {
            Console.WriteLine("Please enter product's id you want to delete: ");
            var id = Console.ReadLine();
            var itemToRemove = listProduct.Single(r => r.ProductId == id);
            listProduct.Remove(itemToRemove);
        }
    }
}