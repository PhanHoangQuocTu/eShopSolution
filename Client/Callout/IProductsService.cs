using Client.Dtos.Common;
using Client.Dtos.Product;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;

namespace Client.Callout
{
    public interface IProductsService
    {
        Task<ApiResult<PagedResult<ProductVm>>> GetProducts(GetManageProductPagingRequest payload);
        Task<ApiResult<bool>> CreateProduct(ProductCreateRequest payload);
        Task<ApiResult<bool>> UpdateProduct(ProductUpdateRequest payload);
        Task<ApiResult<bool>> DeleteProduct(string productId);
    }

    public class ProductsService : IProductsService
    {
        private readonly string _host = ConfigurationManager.AppSettings["host"];

        private HttpClientService _httpClientService = new HttpClientService();

        public async Task<ApiResult<PagedResult<ProductVm>>> GetProducts(GetManageProductPagingRequest payload)
        {
            var list= new List<string>();
            string api = "/api/ProductsM/paging";

            list.Add("pageIndex=" + payload.PageIndex.ToString());
            list.Add("pageSize=" + payload.PageSize.ToString());

            if (!string.IsNullOrWhiteSpace(payload.Keyword))
                list.Add("keyword=" + payload.Keyword.ToString());

            return await _httpClientService.GetAsync< ApiResult<PagedResult<ProductVm>>>(_host + (list.Count > 0 ? api + "?" + string.Join("&", list) : api) , string.Empty);
        }

        public async Task<ApiResult<bool>> CreateProduct(ProductCreateRequest payload) => await _httpClientService.PostAsync<ApiResult<bool>, ProductCreateRequest>(_host + "/api/ProductsM", payload, string.Empty);
        
        public async Task<ApiResult<bool>> UpdateProduct(ProductUpdateRequest payload) => await _httpClientService.PutAsync<ApiResult<bool>, ProductUpdateRequest>(_host + $"/api/ProductsM", payload, string.Empty);
        
        public async Task<ApiResult<bool>> DeleteProduct(string productId) => await _httpClientService.DeleteAsync<ApiResult<bool>>(_host + $"/api/ProductsM/{productId}", string.Empty);
    }
}
