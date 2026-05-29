using System.Text.Json.Serialization;
using Application.Abstractions.Repositories;
using Application.Common.Normalization;
using Application.Common.PlantVectors;
using Application.Contracts.Ahp;
using Application.Contracts.Plant;
using Application.Contracts.PlantScoring;
using Application.Contracts.Rules;
using Application.Services;
using Domain.Models.Ahp;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using DotNetEnv;
using Npgsql;

Env.Load();


var connectionString =
    $"Host={Environment.GetEnvironmentVariable("DB_HOST")};" +
    $"Port={Environment.GetEnvironmentVariable("DB_PORT")};" +
    $"Database={Environment.GetEnvironmentVariable("DB_NAME")};" +
    $"Username={Environment.GetEnvironmentVariable("DB_USER")};" +
    $"Password={Environment.GetEnvironmentVariable("DB_PASSWORD")}";


var dataSourceBuilder = new NpgsqlDataSourceBuilder(connectionString);

dataSourceBuilder.MapEnum<FactorType>("FactorType");
dataSourceBuilder.MapEnum<GoalType>("GoalType");
dataSourceBuilder.MapEnum<ConditionType>("ConditionType");

var dataSource = dataSourceBuilder.Build();

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<AppDbContext>(opt =>
    opt.UseNpgsql(dataSource));

builder.Services.AddScoped<IPlantRepository, PlantRepository>();
builder.Services.AddScoped<IAhpWeightRepository, AhpWeightRepository>();
builder.Services.AddScoped<IRulesRepository, RulesRepository>();

builder.Services.AddScoped<INormalizer, MinMaxNormalizer>();
builder.Services.AddScoped<IPlantFactorVectorFactory, PlantFactorVectorFactory>();

builder.Services.AddScoped<IPlantScoringService, PlantScoreService>();

builder.Services.AddScoped<IPlantService, PlantService>();
builder.Services.AddScoped<IAhpService, AhpService>();
builder.Services.AddScoped<IRuleService, RuleService>();


builder.Services
    .AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    });

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.CustomSchemaIds(type => type.FullName.Replace("+", "_"));
});

var app = builder.Build();

app.Urls.Add("http://localhost:5000");

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();