using Client.Dtos.Common;
using Client.Dtos.Languages;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;

namespace Client.Callout
{
    public interface ILanguagesService
    {
        Task<ApiResult<List<LanguageVm>>> GetLanguages();
    }

    public class LanguagesService : ILanguagesService
    {
        private readonly string _host = ConfigurationManager.AppSettings["host"];

        private HttpClientService _httpClientService = new HttpClientService();

        public async Task<ApiResult<List<LanguageVm>>> GetLanguages() => await _httpClientService.GetAsync<ApiResult<List<LanguageVm>>>(_host + "api/Languages", string.Empty);
    }
}
