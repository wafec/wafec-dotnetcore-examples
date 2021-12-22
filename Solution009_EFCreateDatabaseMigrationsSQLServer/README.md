dotnet add Data package Microsoft.EntityFrameworkCore.Design --version 5.0.13
dotnet add Data package Microsoft.EntityFrameworkCore.Relational --version 5.0.13

dotnet clean
dotnet restore
dotnet build
dotnet ef migrations add -s Data -p Data InitialCreate
dotnet ef database update -s Data -p Data