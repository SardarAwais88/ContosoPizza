using ContosoPizza.Models;
using ContosoPizza.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        // we can get all the pizza service using this get method
        [HttpGet]
        public ActionResult<List<Pizza>> GetAll() =>
    PizzaService.GetAll();


            
    }
    // now another step is to get pizza service by id
}
