# crud

Manjaro Dotnet fixes.

To run this project you will need to install the dotnet pack.  
[Dotnet Pack](https://i.imgur.com/1fS6ZDc.png)

This will enable development with dotnet BUT it will not be able to RUN.  
To do that we need the aspnet pack.  
[Aspnet Pack](https://i.imgur.com/7d2qJUk.png)

Only with these 2 packs installed that the `dotnet run` command will in fact run the project.  
Found the resolution to that on a git issue thread.  
[Arch Linux: It was not possible to find any compatible framework version. The specified framework 'Microsoft.AspNetCore.App', version '2.1.0' was not found. #3198](https://github.com/dotnet/runtime/issues/3198#issuecomment-599917787)
