using CORE.Empleados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.Departamentos
{
    internal class DepartamentoCreateDTO
    {
        public string Nombre { get; set; }

        public Empleado Supervisor { get; set; }

    }
}
