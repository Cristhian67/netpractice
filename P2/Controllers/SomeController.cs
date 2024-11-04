using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace P2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SomeController : ControllerBase
    {

        [HttpGet("sync")]
        public IActionResult async()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            stopwatch.Start();

            Thread.Sleep(1000);
            Console.WriteLine("Conexion a base de datos satisfactoria");

            Thread.Sleep(1000);
            Console.WriteLine("Envio de correo exitoso");
            Console.WriteLine("proceso terminado");

            stopwatch.Stop();


            return Ok(stopwatch.Elapsed);
        }
    }
}
