using ASPNETSample.Services;
using ASPNETSample.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public ProductsController(JsonFileProductService productService)
        {
            this.ProductService = productService;
        }

        public JsonFileProductService ProductService { get; }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductService.GetProducts();
        }

        [HttpPatch("rate/{id}")]
        public ActionResult PatchRatings(
            string id,
            [FromBody] RatingPatchBody JsonBody)
        {
            if (id == null) return NotFound();

            ProductService.AddRating(id, JsonBody.Rating );
            // HTTP status code 200 OK
            return Ok();
            
        }
    }
}
