using JamesWoods.Domain.Lab;
using JamesWoods.Service.Dummy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;

namespace JamesWoods.Api.Controllers
{
    [RoutePrefix("FruitHarder")]
    public class FruitHarderController : ApiController
    {

        List<Fruit> allFruits = MockFruit.AllFruits;

        [HttpGet]
        [Route("")]
        public List<Fruit> GetAllFruits()
        {
            return allFruits;
        }

        [HttpGet]
        [Route("Lab/{FruitId:int}")]
        public IHttpActionResult LabWithFruits(int fruitId)
        {
            if (fruitId == 100)
            {
                return BadRequest("Nooo goood, felaktig syntax");
            }
            if (fruitId == 110)
            {
                return NotFound();
            }
            if (fruitId == 120)
            {
                return Content(HttpStatusCode.Forbidden, "En förbjuden operation har gjorts");
            }
            if (fruitId == 130)
            {
                return Content(HttpStatusCode.Forbidden, allFruits.First());
            }

            if (fruitId == 140)
            {
                throw new Exception("Något oväntat gick snett");
            }

            var oneFruit = allFruits.Where(fruit => fruit.Id == fruitId).Single();

            return Ok(oneFruit);
        }


    }
}