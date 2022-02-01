﻿using ContosoPizza.Models;
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

    //get single pizza using get by id
    /*
        [HttpGet("{id}")]
        public ActionResult<Pizza> Getbyid(int id)
        {
            var pizza = PizzaService.Getbyid(id);

            if (pizza == null)
                return NotFoundResult();

            return pizza;
        }*/

    [HttpPost]
    public IActionResult Create(Pizza pizza)
    {
        // This code will save the pizza and return a result
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Pizza pizza)
    {
        // This code will update the pizza and return a result
    }
}
