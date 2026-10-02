# MicroBlog - Repositories & Dependency Injection
## Description
This project builds on the MicroBlog application by adding the Repository Pattern and Dependency Injection.
The repository pattern separates the application's data access from the Razor Pages. Dependency Injection is used to provide the repository to the pages that need it.
## Features
- Create blog posts
- Display all blog posts
- View individual blog posts
- Uses an `IBlogRepository` interface
- Uses an `InMemoryBlogRepository` implementation
- Uses ASP.NET Core Dependency Injection
- Uses Razor Pages
## Repository Pattern

The `IBlogRepository` interface defines the operations used to work with blog posts.
The `InMemoryBlogRepository` class implements the interface and stores posts in memory.
## Dependency Injection
The repository is registered in `Program.cs` using:
```csharp
builder.Services.AddSingleton<IBlogRepository, InMemoryBlogRepository>();
<img width="475" height="509" alt="image" src="https://github.com/user-attachments/assets/ee637321-a06b-49e9-b97c-5e6208e82040" />
<img width="372" height="421" alt="image" src="https://github.com/user-attachments/assets/459aedfd-0f43-473f-a4ec-861e38448a21" />

