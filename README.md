# Entity Framework 2.1 Scaffold Customization
When doing the Scaffolding, the EF merge the TableName with SchemaName to create a ClassName. 

**Under Construction yet.**

You can test!
For do this, read steps below.

## Prerequisites for test

1. Copy this files to **.NET Core** class library **Data** project.
    - If necessary, edit the csproj file to update the **TargetFramework** to 2.1.

    
2. Add EF Core SQL Server and Tools NuGet packages.  
    - Open the Package Manager Console, select the **Data** project and enter:
        + `Install-Package Microsoft.EntityFrameworkCore.SqlServer -version 2.1.0`
		+ `Install-Package Microsoft.EntityFrameworkCore.SqlServer -version 2.1.0`
3. Execute the command to scaffold database. [You can see steps to scaffold here](https://docs.microsoft.com/en-us/ef/core/get-started/aspnetcore/existing-db)

## Under Construction
---------------------
1. **Done** - Merge SchemaName and TableName into class generated name
2. Generate navigation properties correctly 
3. Generate separated files to entities map