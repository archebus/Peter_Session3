using System;
using System.Security.Cryptography;
using pizza;

class Program
{
    static void Main(string[] args)
    {

       //CreateProducts();
       //QueryProductsFLUENT();
       QueryProductsLINQ();
       //UpdateEntity();
       RemoveEntity();

    }

    // [C]RUD
    static void CreateProducts() {
        using (var context = new PizzaContext())
        {
            // Does product not exist ?
            if (!context.Products.Any())
            {
                // Add new products to the database
                var veggieSpecial = new Product
                {
                    Name = "Veggie Special",
                    Price = 12.99M
                };

                var deluxeMeat = new Product
                {
                    Name = "Deluxe Meat",
                    Price = 15.99M
                };

                context.Products.AddRange(veggieSpecial, deluxeMeat);

                // Save changes to the database
                context.SaveChanges();

                Console.WriteLine("Products added to the database.");
            }
            else
            {
                Console.WriteLine("Products already exist in the database.");
            }
        }
    }

    // C[R]UD Fluent Syntax
    static void QueryProductsFLUENT() {
        using (var context = new PizzaContext())
        {

            var products = context.Products
                                    .Where(p => p.Price > 10.00M)
                                    .OrderBy(p => p.Name);

            foreach (Product p in products)
            {
                Console.WriteLine($"Id:         {p.Id}");
                Console.WriteLine($"Name:       {p.Name}");
                Console.WriteLine($"Price:      {p.Price:C}");
                Console.WriteLine(new string('-', 20));
            } 

        }
    }

    // C[R]UD LINQ Syntax
    static void QueryProductsLINQ() {
        using (var context = new PizzaContext())
        {

            var products =  from product in context.Products
                            where product.Price > 10.00M
                            orderby product.Name
                            select product;

            foreach (Product p in products)
            {
                Console.WriteLine($"Id:         {p.Id}");
                Console.WriteLine($"Name:       {p.Name}");
                Console.WriteLine($"Price:      {p.Price:C}");
                Console.WriteLine(new string('-', 20));
            } 

        }
    }

    // CR[U]D
    static void UpdateEntity() {
        using (var context = new PizzaContext())
        {

            var veggieSpecial = context.Products
                                .Where(p => p.Name == "Veggie Special")
                                .FirstOrDefault();
            
            if (veggieSpecial is Product) {
                veggieSpecial.Price = 10.99M;
            }

            context.SaveChanges();

            QueryProductsLINQ();

        }
    }

    // CRU[D]
    static void RemoveEntity() {
        using (var context = new PizzaContext())
        {

            var veggieSpecial = context.Products
                                .Where(p => p.Name == "Veggie Special")
                                .FirstOrDefault();
            
            if (veggieSpecial is Product) {
                context.Remove(veggieSpecial);
            }

            context.SaveChanges();

            QueryProductsLINQ();

        }
    } 
}
