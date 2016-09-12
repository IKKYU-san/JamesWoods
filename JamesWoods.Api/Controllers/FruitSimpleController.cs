using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace JamesWoods.Api.Controllers
{
    [RoutePrefix("FruitSimple")]
    public class FruitSimpleController : ApiController
    {
        List<string> fruits = new List<string> { "banan", "äpple", "päron" };

        [HttpGet]
        [Route("")]
        public List<string> GetAllFruits()
        {
            return fruits;
        }

        [HttpGet]
        [Route("{id:int}")]
        public string GetFruitWithId(int id)
        {
            return fruits[id];
        }

        [HttpGet]
        [Route("HowManyFruits")]
        public int CountFruits()
        {
            return fruits.Count;
        }

    }
}