# Session 3 Homework

This is a basic C# console application that demonstrates CRUD (Create, Read, Update, Delete) operations using Entity Framework Core with a MySQL database. The project is part of a homework assignment focused on learning .NET Entity Framework and MySQL integration.

I followed this guide: https://www.youtube.com/watch?v=SryQxUeChMc

## Project Overview

The application simulates a simple pizza ordering system. It allows you to:
- **Create** new pizza products.
- **Read** existing products from the database.
- **Update** product details.
- **Delete** products from the database.

## Technologies Used

- **C#**
- **.NET Core**
- **Entity Framework Core**
- **MySQL**
- **LINQ**

## Important Methods

The main entry point is the `Program.cs` file. You can test the following operations:

- **Create Products**: Uncomment the `CreateProducts()` method in the `Main` function to add new products to the database.
- **Read Products**: Uncomment `QueryProductsFLUENT()` or `QueryProductsLINQ()` to retrieve and display products from the database.
- **Update Product**: Uncomment `UpdateEntity()` to update an existing product's price.
- **Delete Product**: Uncomment `RemoveEntity()` to delete a product from the database.

## Homework Task

This project was developed as part of a homework assignment to learn .NET Entity Framework with MySQL. The tasks completed include:

- **CREATE**: Adding new pizza products to the database.
- **READ**: Retrieving and displaying pizza products.
- **UPDATE**: Modifying the price of an existing product.
- **DELETE**: Removing a product from the database.

## License

This project is licensed under MIT.

---

Feel free to reach out if you have any questions or need further assistance with the setup.
