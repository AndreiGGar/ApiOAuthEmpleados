using ApiOAuthEmpleados.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiOAuthEmpleados.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Empleado> Empleados { get; set; }
    }
}
