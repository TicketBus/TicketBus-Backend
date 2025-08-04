using Microsoft.EntityFrameworkCore;

namespace TicketBus.DAL.Persistence;

public class TicketBusDbContext : DbContext
{
    public TicketBusDbContext(DbContextOptions<TicketBusDbContext> options) 
        : base(options)
    {}
}