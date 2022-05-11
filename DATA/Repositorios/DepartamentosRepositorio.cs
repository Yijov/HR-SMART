using CORE.Departamentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Repositorios
{
   internal class DepartamentosRepositorio:Repositorio<Departamento>, IDepartamentosRepositorio
    {
        public DepartamentosRepositorio(ApplicationDbContext context) : base(context)
        {
        }
  
    }
}
