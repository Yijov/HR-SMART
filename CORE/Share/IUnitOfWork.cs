using CORE.Departamentos;
using CORE.Empleados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.Share
{
    public interface IUnitOfWork: IDisposable
    {
       IEmpleadosRepositorio Empleados { get;  }
       IDepartamentosRepositorio Departamentos { get;  }
       Task<bool> Complete();
    }
}
