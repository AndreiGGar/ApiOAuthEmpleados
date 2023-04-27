using ApiOAuthEmpleados.Context;
using ApiOAuthEmpleados.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiOAuthEmpleados.Repositories
{
    public class RepositoryEmpleados
    {
        private DataContext context;

        public RepositoryEmpleados(DataContext context)
        {
            this.context = context;
        }

        public async Task<List<Empleado>> GetEmpleadosAsync()
        {
            return await this.context.Empleados.ToListAsync();
        }

        public async Task<Empleado> FindEmpleadoAsync(int idempleado)
        {
            return await this.context.Empleados.FirstOrDefaultAsync(x => x.IdEmpleado == idempleado);
        }

        public async Task<Empleado> ExisteEmpleadoAsync(string apellido, int idempleado)
        {
            return await this.context.Empleados.FirstOrDefaultAsync(x => x.Apellido == apellido && x.IdEmpleado == idempleado);
        }
    }
}
