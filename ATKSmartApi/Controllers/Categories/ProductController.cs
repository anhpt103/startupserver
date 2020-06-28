using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ATKSmartApi.Services.Categories;

namespace ATKSmartApi.Controllers.Categories
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("get_product")]
        public IActionResult Get(string pi, string ps, string sorter, string status)
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
