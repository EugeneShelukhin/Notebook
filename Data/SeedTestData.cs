using Notebook.Models;

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
            if (appDbContext.Articles.Any())
            {
                return;
            }
            var dotnetNiewTopic = new Topic() { Title = "dotnet new <TEMPLATE>" };

            appDbContext.Topics.Add(new Topic()
            {
                Title = "C#",
                NestedTopics = new List<Topic>(){
                    new Topic() {Title="Dotnet CLI",
                        NestedTopics=new List<Topic>(){
                            dotnetNiewTopic
                        }}
                }
            });
            appDbContext.SaveChanges();

            appDbContext.Articles.AddRange(new Article() { Title = "console", Description = "", TopicId = dotnetNiewTopic.Id },
            new Article() { Title = "webapi", Description = "", TopicId = dotnetNiewTopic.Id },
            new Article() { Title = "web", Description = "", TopicId = dotnetNiewTopic.Id }
            );
            appDbContext.SaveChanges();
        }
    }
}