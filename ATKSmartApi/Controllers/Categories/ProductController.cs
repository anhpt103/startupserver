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

        [HttpPost("post_product")]
        public IActionResult PostProduct()
        {
            var products = _productService.PostProduct();
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
