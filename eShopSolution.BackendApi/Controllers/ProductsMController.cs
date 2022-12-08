using eShopSolution.Application.Catalog.Products;
using eShopSolution.Data.Dtos.Product;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace eShopSolution.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsMController : ControllerBase
    {
        private readonly IProductMService _productMService;

        public ProductsMController(IProductMService productMService) => _productMService = productMService;

        [HttpGet("paging")]
        public async Task<IActionResult> GetAllPaging([FromQuery] GetManageProductPagingRequest request)
        {
            var products = await _productMService.GetAllPaging(request);
            return Ok(products);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ProductCreateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _productMService.Create(request);
            if (!result.IsSuccessed)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] ProductUpdateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _productMService.Update(request);
            if (!result.IsSuccessed)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpDelete("{productId}")]
        public async Task<IActionResult> Delete(string productId)
        {
            var result = await _productMService.Delete(productId);
            return Ok(result);
        }
    }
}
