using Microsoft.OpenApi.Models;
using TestAPIWebApplication;

var builder = WebApplication.CreateBuilder(args);

//Начальное заполнение БД данными
/*using (DatabaseContext databaseContext = new DatabaseContext())
{
    databaseContext.Database.EnsureDeleted();
    databaseContext.Database.EnsureCreated();
    GetSourceData.SetData();
    var persons = GetSourceData.GetData();
    databaseContext.AddRange(persons);
    databaseContext.SaveChanges();
}*/

// Add services to the container.

builder.Services.AddTransient<DatabaseContext>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddAuthorization();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(option =>
{
    option.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Description = "v1 API",
        Title = "TestApi",

    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
