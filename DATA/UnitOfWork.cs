using CORE.Departamentos;
using CORE.Empleados;
using CORE.Share;
using DATA.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    internal class UnitOfWork:IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IDepartamentosRepositorio Departamentos { get; private set; }
        public IEmpleadosRepositorio Empleados { get; private set; }
        public UnitOfWork(ApplicationDbContext context)
        {
            _context=context;
            Departamentos = new DepartamentosRepositorio(_context);
            Empleados = new EmpleadosRepositorio(_context);
        }
        public async Task<bool> CommitChanges()
        {
            if (await _context.SaveChangesAsync() >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
