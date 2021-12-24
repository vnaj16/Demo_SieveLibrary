using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sieve.Models;
using Sieve.Services;
using System.Linq;

namespace Demo_SieveLibrary.Controllers
{
    //[ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private SieveDbContext context { get; set; }
        private SieveProcessor _sieveProcessor { get; set; }

        public ProductController(SieveDbContext context, SieveProcessor sieveProcessor)
        {
            this.context = context;
            _sieveProcessor = sieveProcessor;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(new { Count = context.Products.Count(), Array = context.Products.ToList() });
        }

        [HttpGet("sieve")]
        public IActionResult IndexSieve(SieveModel sieveModel)//Anteriormente aparecia el error 415 de no MediaType supported, se solucionó quitando el
            //Attribute ApiController, ya que este internamente Bindea el modelo y no podia bindearlo bien, pero quitandolo ya lo Bindeo bien
        {
            IQueryable<Product> result = context.Products.AsNoTracking(); // Makes read-only queries faster
            result = _sieveProcessor.Apply(sieveModel, result); // Returns `result` after applying the sort/filter/page query in `SieveModel` to it
            return Ok(result.ToList());
        }
    }
}
