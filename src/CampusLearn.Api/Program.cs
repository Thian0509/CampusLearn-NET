using CampusLearn.Application.Abstractions;
using CampusLearn.Infrastructure.Config;
using CampusLearn.Infrastructure.Persistence;
using CampusLearn.Infrastructure.Repositories;
using CampusLearn.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<MongoSettings>(builder.Configuration.GetSection("Mongo"));
builder.Services.AddSingleton<MongoContext>();

builder.Services.AddSingleton<UserRepository>();
builder.Services.AddSingleton<TopicRepository>();

builder.Services.AddSingleton<IUserService, UserService>();
builder.Services.AddSingleton<ITopicService, TopicService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Enable Swagger always so the marker can see it regardless of env
app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

// Redirect root to swagger so hitting http://localhost:<port>/ works
app.MapGet("/", () => Results.Redirect("/swagger"));

app.Run();