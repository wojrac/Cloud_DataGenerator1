using System.Collections.Generic;
using CloudBackend1.Models;
using Microsoft.AspNetCore.Mvc;

namespace CloudBackend1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContagionController : Controller
    {

        //HTTP GET : api/contagion
        [HttpGet]
        public ActionResult GetStatistics()
        {
            AreaManager areaManager = new AreaManager();
            areaManager.GenerateContagions();
            var list = areaManager.Areas;
            return Json(list);
        }
    }
}
