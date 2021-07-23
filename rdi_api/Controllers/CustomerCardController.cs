using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using rdi_api.Model;
using rdi_api.Services;

namespace rdi_api.Controllers
{    
    [Route("[controller]")]
    [ApiController]
    public class CustomerCardController : Controller
    {
        CardResponse _cardResponse = new CardResponse();

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public string Get()
        {
            return "Seja Bem Vindo(a)";
        }        

        [HttpPost("v1/receivecustomercard/")]
        public IActionResult Post([FromBody] Card card)
        {           
            //CardResponse _cardResponse = new CardResponse();
           
            _cardResponse.CardId = 1234;
            _cardResponse.Token = TokenCreator.CreateToken(card.CardNumber);
            _cardResponse.CreationDate = DateTime.Now;

            return Ok(_cardResponse);        
        }

        [HttpPost("v1/validatetoken/")]
        public IActionResult Post([FromBody] CardResponse cardresponse)
        {
            bool validateToken = TokenCreator.ValidateToken(cardresponse.CreationDate);

            if (validateToken)
            {
                return Ok("Token Válido");
            }

            return Unauthorized("Token Expirado");
        }
    }
}
