using Client.Dtos.Common;
using Client.Dtos.UserDto;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;

namespace Client.Callout
{
    public interface IUsersService
    {
        Task<ApiResult<string>> Authenticate(LoginRequest payload);
    }

    public class UsersService : IUsersService
    {
        private readonly string _host = ConfigurationManager.AppSettings["host"];

        private HttpClientService _httpClientService = new HttpClientService();

        public async Task<ApiResult<string>> Authenticate(LoginRequest payload)
        {

            return await _httpClientService.PostAsync<ApiResult<string>, LoginRequest>(_host + "/api/Users/authenticate", payload, string.Empty);
        }
    }
}
