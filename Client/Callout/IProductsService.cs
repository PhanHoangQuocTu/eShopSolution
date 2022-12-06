using Client.Dtos.Common;
using Client.Dtos.Product;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;

namespace Client.Callout
{
    public interface IProductsService
    {
        Task<PagedResult<ProductVm>> GetProducts(GetManageProductPagingRequest payload);
        Task<int> CreateProduct(ProductCreateRequest payload);
        Task<int> UpdateProduct(int productId, ProductUpdateRequest payload);
        Task<int> DeleteProduct(int productId);
        Task<ProductVm> GetProductById(int productId, string languageId);
    }

    public class ProductsService : IProductsService
    {
        private readonly string _host = ConfigurationManager.AppSettings["host"];

        private HttpClientService _httpClientService = new HttpClientService();

        public async Task<PagedResult<ProductVm>> GetProducts(GetManageProductPagingRequest payload)
        {
            var list= new List<string>();
            string api = "/api/Products/paging";

            list.Add("PageIndex=" + payload.PageIndex.ToString());
            list.Add("PageSize=" + payload.PageSize.ToString());

            if (!string.IsNullOrWhiteSpace(payload.Keyword))
                list.Add("Keyword=" + payload.Keyword.ToString());

            if (!string.IsNullOrWhiteSpace(payload.LanguageId))
                list.Add("LanguageId="+payload.LanguageId.ToString());

            if (payload.CategoryId.HasValue)
                list.Add("CategoryId=" + payload.CategoryId.ToString());

            return await _httpClientService.GetAsync<PagedResult<ProductVm>>(_host + (list.Count > 0 ? api + "?" + string.Join("&", list) : api) , string.Empty);
        }

        public async Task<int> CreateProduct(ProductCreateRequest payload) => await _httpClientService.PostAsync<int, ProductCreateRequest>(_host + "/api/Products", payload, string.Empty);
        
        public async Task<int> UpdateProduct(int productId, ProductUpdateRequest payload) => await _httpClientService.PutAsync<int, ProductUpdateRequest>(_host + $"/api/Products/{productId}", payload, string.Empty);
        
        public async Task<int> DeleteProduct(int productId) => await _httpClientService.DeleteAsync<int>(_host + $"/api/Products/{productId}", string.Empty);
        
        public async Task<ProductVm> GetProductById(int productId, string languageId) => await _httpClientService.GetAsync<ProductVm>(_host + $"/api/Products/{productId}/{languageId}", string.Empty);
    }
}
