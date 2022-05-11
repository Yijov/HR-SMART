
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.Empleados
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Apellido { get; set; }
        public string FotoURL { get; set; }
        public  string Cargo { get; set; }
        public TipoEmpleado TipoEmpleado { get; set; }
        public StatusEmpleado Status { get; set; }

        public bool SoftDeleted { get; set; }

        public DateTime FechaCreacion { get; set; }

        public int DepartamentoId { get; set; }

    }
}
