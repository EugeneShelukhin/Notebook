using Microsoft.EntityFrameworkCore;
using Notebook.Data;
using Notebook.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlite("Data Source=Database.db"));

builder.Services.AddScoped<IArticlesRepository, ArticlesRepository>();
builder.Services.AddScoped<ITopicsRepository, TopicsRepository>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetService<AppDbContext>();
    context.Database.Migrate();//миграции в рантайме не безопасны так как могут приходить от сразу от нескольких инстансов
}
SeedTestData.RollUp(app);//в development?

app.UseAuthorization();

app.MapControllers();

app.Run();
