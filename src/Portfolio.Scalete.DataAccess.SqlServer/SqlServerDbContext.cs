using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Portfolio.Scalete.DataAccess.SqlServer.Entities;

namespace Portfolio.Scalete.DataAccess.SqlServer;

public class SqlServerDbContext : DbContext
{
    private readonly IConfiguration _configuration;

    public DbSet<BlogEntity> Blogs { get; set; }
    public DbSet<WorkEntity> Works{ get; set; }

    public SqlServerDbContext(IConfiguration configuration) =>
        _configuration = configuration;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
}
