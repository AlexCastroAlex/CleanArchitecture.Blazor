# CleanArchitecture.Blazor

- you can launch the working project by first launching WebUi with Debug->Start new instance and check if swagger is displayed on https://localhost:44312/api
- then right click on Blazor and also make  Debug->Start new instance and you should be fine.

If you have CORS issues, just check the startup.cs of the WebUI project and only enter your local URL.
The only working endpoint is the weatherforeact one  because the todolist and todoitem are linked to a database which you will have to initialise or use in memory database with : 
If you would like to use SQL Server, you will need to update WebUI/appsettings.json as follows:

  "UseInMemoryDatabase": false,
  
### Database Configuration

The template is configured to use an in-memory database by default. This ensures that all users will be able to run the solution without needing to set up additional infrastructure (e.g. SQL Server).

If you would like to use SQL Server, you will need to update **WebUI/appsettings.json** as follows:

```json
  "UseInMemoryDatabase": false,
```

Verify that the **DefaultConnection** connection string within **appsettings.json** points to a valid SQL Server instance. 

When you run the application the database will be automatically created (if necessary) and the latest migrations will be applied.

  
### Database Migrations
To use dotnet-ef for your migrations please add the following flags to your command (values assume you are executing from repository root)

- project src/Infrastructure (optional if in this folder)
- startup-project src/WebUI
- output-dir Persistence/Migrations

For example, to add a new migration from the root folder:

dotnet ef migrations add "SampleMigration" --project src\Infrastructure --startup-project src\WebUI --output-dir Persistence\Migrations

