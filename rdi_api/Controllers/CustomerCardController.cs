using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rdi_api.Controllers
{
    public class CustomerCardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public void Get()
        {

        }

        [HttpPost]
        public void Post(int id,int cardnumber, int cvv)
        {

        }
    }
}
