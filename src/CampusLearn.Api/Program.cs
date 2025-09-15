using CampusLearn.Application.Abstractions;
using CampusLearn.Infrastructure.Config;
using CampusLearn.Infrastructure.Persistence;
using CampusLearn.Infrastructure.Repositories;
using CampusLearn.Infrastructure.Services;
//This is for the account creation logic
using CampusLearn.Application.Account;
using CampusLearn.Domain.Account;
using CampusLearn.Infrastructure.Account;

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

builder.Services.AddTransient<IAccountFactory, AccountFactory>();
builder.Services.AddTransient<AccountService>(); // Register the service that uses the factory

var app = builder.Build();

// Enable Swagger always so the marker can see it regardless of env
app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

// Redirect root to swagger so hitting http://localhost:<port>/ works
app.MapGet("/", () => Results.Redirect("/swagger"));

// Example usage in an API endpoint (in a controller)
app.MapGet("/create-student", (AccountService service) =>
{
    //http://localhost:5187/create-student
    return service.CreateStudentAccount("Alice Johnson", 12345);
});

app.MapGet("/create-tutor", (AccountService service) =>
{
    return service.CreateTutorAccount("Bob Smith", "Mathematics");
});

app.Run();