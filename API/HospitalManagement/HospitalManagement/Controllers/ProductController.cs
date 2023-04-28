using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HospitalManagement.Services.Interfaces;
using HospitalManagement.Infrastructure;
using HospitalManagement.Domain;

namespace HospitalManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
    }    
}
