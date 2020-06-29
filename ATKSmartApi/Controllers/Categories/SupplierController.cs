using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ATKSmartApi.Services.Categories;

namespace ATKSmartApi.Controllers.Categories
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class SupplierController : ControllerBase
    {
        private ISupplierService _supplierService;

        public SupplierController(ISupplierService SupplierService)
        {
            _supplierService = SupplierService;
        }

        [HttpPost("post_sup_by_store")]
        public IActionResult PostSupplierByStore()
        {
            var suppliers = _supplierService.PostSupplierByStore();
            return Ok(suppliers);
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            var suppliers = _supplierService.GetById(id);
            return Ok(suppliers);
        }
    }
}
