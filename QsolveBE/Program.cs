using Contract;
using Entities;
using Microsoft.EntityFrameworkCore;
using Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddEntityFrameworkSqlite().AddDbContext<RepositoryContext>(opt => opt.UseSqlite(builder.Configuration.GetConnectionString("WebApiDatabase")));
//C:\Users\faeiz\OneDrive\Desktop\databasesqlite
builder.Services.AddEntityFrameworkSqlite().AddDbContext<RepositoryContext>(opt => opt.UseSqlite(builder.Configuration.GetConnectionString("Data Source=C:\\Users\\faeiz\\OneDrive\\Desktop\\databasesqlite\\qsolvedb.db")));

builder.Services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
