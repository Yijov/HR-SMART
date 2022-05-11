using CORE.Departamentos;
using DATA.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    internal class EmpleadosRepositorio : Repositorio<Departamento>, IDepartamentosRepositorio
    {
        public EmpleadosRepositorio(ApplicationDbContext context) : base(context)
        {
        }
    }
}
