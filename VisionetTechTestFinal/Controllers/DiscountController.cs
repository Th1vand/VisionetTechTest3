using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using VisionetTechTestFinal.Model;
using VisionetTechTestFinal.Services;
using static VisionetTechTestFinal.Model.CustomerModel;

namespace VisionetTechTestFinal.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DiscountController : ControllerBase
    {
        private readonly DiscountServicescs _dc; 
        //test
        public DiscountController(CustomerDbContext context)
        {
            _dc = new DiscountServicescs(); 
        }

        [HttpPost("calculate")]
        public IActionResult CalculateDiscount([FromBody] Customer customer)
        {
            if (customer == null)
            {
                return BadRequest("Invald Customer Data.");
            }

            var result = _dc.CalculateDiscount(customer);
            
            return Ok(result);
        }
    }
}
