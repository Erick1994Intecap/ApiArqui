using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication5.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication5.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        static List<Cliente> clientes = new List<Cliente>();
        // GET: api/<ClienteController>
        [HttpGet]
        public ActionResult<List<Cliente>> Get()
        {
            if (clientes.Count == 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(clientes);
            }
            
        }

        // POST api/<ClienteController>
        [HttpPost]
        public void Post([FromBody] Cliente cliente)
        {
            clientes.Add(cliente);
        }

       
    }
}
