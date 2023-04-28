using Microsoft.AspNetCore.Mvc;
using HospitalManagement.Services.Interfaces;

namespace HospitalManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoryController : Controller
    {
        public readonly IProductCategoryService _productCategoryService;

        public ProductCategoryController(IProductCategoryService productCategoryService)
        {
            _productCategoryService = productCategoryService;
        }        
    }
}
