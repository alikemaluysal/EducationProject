using API.LoggerConfigurationHandler;
using Persistence.ServiceRegistration;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddPersistenceServices(builder.Configuration);
builder.Services.AddHttpLogging();
builder.Host.UseSerilog(LoggerConfigurationHandler.GetLogger(builder.Configuration));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//TODO --> ConfigureExceptionHandlerExtension


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
