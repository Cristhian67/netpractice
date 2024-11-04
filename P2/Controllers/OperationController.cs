using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace P2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationController : ControllerBase
    {
        [HttpGet]
        public decimal Get(Numbers numbers)
        {
            return numbers.A + numbers.B;
        }

        [HttpPost]
        public decimal Add(Numbers numbers, [FromHeader] string Host)
        {
            Console.WriteLine(Host);
            return numbers.A - numbers.B;
        }
        [HttpPut]

        public decimal Edit(Numbers numbers)
        {
            return numbers.A * numbers.B;
        }

        [HttpDelete]
        public decimal Delete(Numbers numbers)
        {
            return numbers.A / numbers.B;
        }
    }

    public class Numbers
    {
        public decimal A { get; set; }
        public decimal B { get; set; }
    }
}
