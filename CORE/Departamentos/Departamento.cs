using CORE.Empleados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.Departamentos
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Empleado Supervisor { get; set; }

        public IEnumerable<Empleado>? Empleados { get; set; }

        public DateTime CreatedAt { get; set; }
        public bool SoftDeleted { get; set; }
    }
}
