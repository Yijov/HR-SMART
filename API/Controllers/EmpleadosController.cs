using CORE.Share;
using CORE.Empleados;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadosController : ControllerBase
    {
       private readonly IUnitOfWork _UnitOfWork;
        public EmpleadosController(IUnitOfWork UnitOfWork)
        {
            _UnitOfWork = UnitOfWork;
        }
        
        
        // GET: api/<EmpleadoController>
       
        
        [HttpGet]
        public IEnumerable<Empleado> Get()
        {
            return _UnitOfWork.Empleados.Get();
        }

        // GET api/<EmpleadoController>/5
        [HttpGet("{id}")]
        public Empleado Get(int id)
        {
            return _UnitOfWork.Empleados.Get(id);
        }

        // POST api/<EmpleadoController>
        [HttpPost]
        public void Post([FromBody] Empleado value)
        {
            _UnitOfWork.Empleados.Add(value);
            _UnitOfWork.Complete();
        }

        // PUT api/<EmpleadoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Empleado value)
        {
            _UnitOfWork.Empleados.Add(value);
            _UnitOfWork.Complete();
        }

        // DELETE api/<EmpleadoController>/5
        [HttpDelete("{id}")]
        public void Delete(Empleado value)
        {
            _UnitOfWork.Empleados.Delete(value);
            _UnitOfWork.Complete();
        }
    }
}
