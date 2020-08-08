How run migration in this project using entityframeworkcore.  
your path: c:/project/socialnetworkapplcation.  
dotnet ef migrations add InitialMigration -p Persistence/ -s API/  
  
dotnet ef migrations remove -p Persistence/ -s API/  
dotnet ef migrations add Test -p Persistence/ -s API/  
  
