using Models;

namespace Notebook.Data
{
    public static class SeedTestData
    {
        public static void RollUp(WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                SeedData(scope.ServiceProvider.GetService<AppDbContext>());
            }
        }

        private static void SeedData(AppDbContext? appDbContext)
        {
            if (appDbContext.DotnetCLIs.Any())
            {
                return;
            }
            appDbContext?.DotnetCLIs.AddRange(new DotnetCLI() { Group = "dotnet new <TEMPLATE>", ShortName = "console", Description = "", Template = "" },
            new DotnetCLI() { Group = "dotnet new <TEMPLATE>", ShortName = "webapi", Description = "", Template = "" },
            new DotnetCLI() { Group = "dotnet new <TEMPLATE>", ShortName = "web", Description = "", Template = "" }
            );
            appDbContext.SaveChanges();
        }
    }
}