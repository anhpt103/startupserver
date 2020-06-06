using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StartupApi.Services.Categories;

namespace StartupApi.Controllers.Categories
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var products = _productService.GetAll();
            return Ok(products);
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            var products = _productService.GetById(id);
            return Ok(products);
        }
    }
}
