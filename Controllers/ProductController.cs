using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetCoreFilter.Manager;
using NetCoreFilter.ModelParameters;
using NetCoreFilter.Paging;
namespace NetCoreFilter.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        ProductManager productManager = new ProductManager();
        public ProductController()
        {
            
        }
        [HttpGet]
        [Route("getProductFilter")]
        public IActionResult getProductFilter([FromQuery] ProductPageParameter productPageParameter)
        {
            var productList =  productManager.GetFilterProductList(productPageParameter);
            return Ok(productList);
        }
        
    }
}