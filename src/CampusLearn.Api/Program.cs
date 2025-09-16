using CampusLearn.Infrastructure.Services;
using CampusLearn.Application.Account;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddInfrastructureServices(builder.Configuration); // Dependencie Injection

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

// Example usage in an API endpoint (in a controller)
app.MapGet("/create-student", (AccountService service) =>
{
    return service.CreateStudentAccount("Alice Johnson", 12345);
});

app.MapGet("/create-tutor", (AccountService service) =>
{
    return service.CreateTutorAccount("Bob Smith", "Mathematics");
});

app.Run();