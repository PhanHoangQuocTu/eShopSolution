using Client.Dtos.Category;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;

namespace Client.Callout
{
    public interface ICategoriesService
    {
        Task<List<CategoryVm>> GetCategories(string languageId);
        Task<List<CategoryVm>> GetCategoryById(string languageId, int id);
    }

    public class CategoriesService : ICategoriesService
    {
        private readonly string _host = ConfigurationManager.AppSettings["host"];

        private HttpClientService _httpClientService = new HttpClientService();

        public async Task<List<CategoryVm>> GetCategories(string languageId) => await _httpClientService.GetAsync<List<CategoryVm>>(_host + (!string.IsNullOrWhiteSpace(languageId) ? $"/api/Categories?languageId={languageId}" : "/api/Categories"), string.Empty);
    
        public async Task<List<CategoryVm>> GetCategoryById(string languageId, int id) => await _httpClientService.GetAsync<List<CategoryVm>>(_host + $"/api/Categories?languageId={languageId}?id={id}", string.Empty);

    }
}
