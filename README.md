# The Josh Project

This repository contains an ASP.NET Core web API with accompanying database migrations and unit tests.

## Requirements
- [.NET 8 SDK](https://dotnet.microsoft.com/) installed
- PostgreSQL database

## Running Migrations and Seeds

Database migrations and seed scripts are executed through the **TheJoshProject.Migrations** console project. Set the connection string in the `TheJoshProjectDefaultConnectionString` environment variable and run:

```bash
dotnet run --project TheJoshProject.Migrations
```

The scripts in `TheJoshProject.Migrations/Scripts` will be applied to the database.

## Running Tests

Execute the test suite using xUnit with:

```bash
dotnet test
```

## Running the Application

Start the API by running:

```bash
dotnet run --project TheJoshProject.Api
```

The API will be available locally with Swagger UI enabled in development.
