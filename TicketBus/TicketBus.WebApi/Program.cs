using Microsoft.EntityFrameworkCore;
using TicketBus.DAL.Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<TicketBusDbContext>(options => 
{
    options.UseSqlServer(connectionString, opt =>
    { 
        opt.MigrationsAssembly(typeof(TicketBusDbContext).Assembly.GetName().Name);
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
