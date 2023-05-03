using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductDetailService.ProductDetailDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductDetailService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductDetailController : Controller
    {
        private readonly ILogger<ProductDetailController> logger;
        private readonly IRepository repository;
        public ProductDetailController(ILogger<ProductDetailController> logger, IRepository repository)
        {
            this.logger = logger;
            this.repository = repository;
        }
        public IActionResult Index()
        {
            var res = repository.GetProductDetail(1);
            return Json(res);
        }
    }
}
