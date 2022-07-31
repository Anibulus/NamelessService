Using Entoty Framework 
usign those commands https://docs.microsoft.com/en-us/ef/core/cli/dotnet



Se agrego esta referencia, no dejar en el producto final
dotnet add package Microsoft.EntityFrameworkCore.Sqlite



dotnet ef migrations add asdfg
dotnet ef database update

optionsBuilder.UseSqlite("Data Source=My.db");