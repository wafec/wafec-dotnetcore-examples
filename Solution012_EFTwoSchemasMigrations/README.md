
To create a new migration for Context1 
dotnet ef migrations add -s Console1 -p SqlServerMigrationsContext1 <migration_name>

Then to apply it
dotnet ef database update -s Console1 -p SqlServerMigrationsContext1