using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Controllers
{
    [Route("/categories")]
    public class CategoryController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post()
        {
            return View();

        }
    }
}

