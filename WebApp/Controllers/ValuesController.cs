using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using standardlib;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IProductsService _productsService;
        public ValuesController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        public IProductsService ProductsService { get; }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
  
            return _productsService.GetProducts();
        }
    }
}
