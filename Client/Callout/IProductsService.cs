using Client.Dtos;
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

    }
}
