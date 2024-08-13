# Pizza Ordering System

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

## Prerequisites

To run this project, you need to have the following installed:
- [.NET SDK](https://dotnet.microsoft.com/download)
- [MySQL Server](https://dev.mysql.com/downloads/mysql/)
- [MySQL Workbench](https://dev.mysql.com/downloads/workbench/) (optional, for database management)

## Setup Instructions

1. Clone the repository to your local machine.
    ```bash
    git clone https://your-repo-link-here
    ```

2. Navigate to the project directory:
    ```bash
    cd pizza-ordering-system
    ```

3. Install the required .NET packages:
    ```bash
    dotnet restore
    ```

4. Update the connection string in the `PizzaContext` class with your MySQL credentials.

5. Run the application:
    ```bash
    dotnet run
    ```

## How to Use

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
