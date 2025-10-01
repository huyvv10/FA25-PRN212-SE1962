using System;
using System.Collections.Generic;
using LinqProductPractice;

namespace LinqProductPractice
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }

    public class Supplier
    {
        public int Id { get; set; }
        public string SupplierName { get; set; }
    }

    public class ProductSupplier
    {
        public int ProductId { get; set; }
        public int SupplierId { get; set; }
    }

    public static class ProductData
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product(){ Id=1, Name="Laptop Pro 15", CategoryId=1, Price=1500, Stock=10},
            new Product(){ Id=2, Name="Laptop Air 13", CategoryId=1, Price=1200, Stock=15},
            new Product(){ Id=3, Name="Mechanical Keyboard", CategoryId=2, Price=120, Stock=50},
            new Product(){ Id=4, Name="Wireless Mouse", CategoryId=2, Price=60, Stock=80},
            new Product(){ Id=5, Name="HD Monitor 27\"", CategoryId=2, Price=300, Stock=20},
            new Product(){ Id=6, Name="Smartphone X", CategoryId=3, Price=999, Stock=25},
            new Product(){ Id=7, Name="Smartphone Y", CategoryId=3, Price=850, Stock=30},
            new Product(){ Id=8, Name="Tablet Z", CategoryId=3, Price=600, Stock=18},
            new Product(){ Id=9, Name="Office Chair", CategoryId=4, Price=200, Stock=40},
            new Product(){ Id=10, Name="Standing Desk", CategoryId=4, Price=500, Stock=12},
        };

        public static List<Category> Categories = new List<Category>()
        {
            new Category(){ Id=1, CategoryName="Computers"},
            new Category(){ Id=2, CategoryName="Accessories"},
            new Category(){ Id=3, CategoryName="Mobiles"},
            new Category(){ Id=4, CategoryName="Furniture"},
        };

        public static List<Supplier> Suppliers = new List<Supplier>()
        {
            new Supplier(){ Id=1, SupplierName="TechWorld Ltd"},
            new Supplier(){ Id=2, SupplierName="GadgetHub"},
            new Supplier(){ Id=3, SupplierName="FurniCo"},
        };

        public static List<ProductSupplier> ProductSuppliers = new List<ProductSupplier>()
        {
            new ProductSupplier(){ ProductId=1, SupplierId=1},
            new ProductSupplier(){ ProductId=2, SupplierId=1},
            new ProductSupplier(){ ProductId=3, SupplierId=2},
            new ProductSupplier(){ ProductId=4, SupplierId=2},
            new ProductSupplier(){ ProductId=5, SupplierId=2},
            new ProductSupplier(){ ProductId=6, SupplierId=1},
            new ProductSupplier(){ ProductId=7, SupplierId=1},
            new ProductSupplier(){ ProductId=8, SupplierId=1},
            new ProductSupplier(){ ProductId=9, SupplierId=3},
            new ProductSupplier(){ ProductId=10, SupplierId=3},
        };
    }
}

public class Program
{
    private static void Main(string[] args)
    {
        //Filtering & Projection

        //Get all products with a price greater than 1000.

        //Select only the product names.

        //Select product name and stock as an anonymous object.

        //Get products whose name contains "Laptop".

        //Sorting

        //Sort all products by price ascending.

        //Sort products by category, then by stock descending.

        //Grouping & Joining

        //Group products by category.

        //Show each product with its category name (using Join).

        //Show suppliers with the list of products they supply (GroupJoin).

        //Aggregation

        //Count how many products are in the "Accessories" category.

        //Find the average price of all products.

        //Get the maximum stock among all products.

        //Find the cheapest product.

        //Quantifiers & Elements

        //Check if any product has stock less than 5.

        //Check if all products are priced above 50.

        //Get the first product in the "Mobiles" category.

        //Get the first product that costs more than 2000, or null if none exist.

        //Set Operators

        //Get distinct CategoryIds from all products.

        //Get the intersection of products supplied by Supplier 1 and Supplier 2.

        //Get the union of products supplied by Supplier 2 and Supplier 3.

        //Partitioning & Conversion

        //Take the first 5 products.

        //Skip the first 3 products and return the rest.

        //Convert the product list to a dictionary (Id → Name).

        //Advanced / Challenge

        //Find the top 3 most expensive products.

        //Show the category with the highest average product price.

    }
}