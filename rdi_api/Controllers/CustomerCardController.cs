using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using rdi_api.Model;

namespace rdi_api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerCardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public string Get()
        {
            return "Entrou Aqui";
        }

        [HttpGet("get-card-number/{year}")]
        public ActionResult<IEnumerable<string>> GetCardNumber(int year)
        {
            bool validate = false;
            DateTime data = DateTime.Now;
            int currentyear = data.Year;
            if (year < currentyear)
                validate = true;

            if (validate)
                return Ok("Cartão Fora do Prazo");
            else
                return BadRequest("Cartão No Prazo de Validade");

           // return Ok(validate);
        }

        [HttpPost("v1/card/")]
        public IActionResult Post([FromBody] Card card)
        {
            return Ok();
        }
    }
}
