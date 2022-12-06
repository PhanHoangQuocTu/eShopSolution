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
        Task<ApiResult<PagedResult<UserVm>>> GetPagingUsers(GetUserPagingRequest payload);
        Task<ApiResult<bool>> RegisterUser(RegisterRequest payload);
        Task<ApiResult<bool>> UpdateUser(Guid id, UserUpdateRequest payload);
        Task<ApiResult<UserVm>> GetUser(Guid id);
        Task<ApiResult<bool>> DeleteUser(Guid id);
        Task<ApiResult<bool>> ChangeRoleUser(Guid id, RoleAssignRequest payload);
    }

    public class UsersService : IUsersService
    {
        private readonly string _host = ConfigurationManager.AppSettings["host"];

        private HttpClientService _httpClientService = new HttpClientService();

        public async Task<ApiResult<string>> Authenticate(LoginRequest payload) => await _httpClientService.PostAsync<ApiResult<string>, LoginRequest>(_host + "/api/Users/authenticate", payload, string.Empty);
        
        public async Task<ApiResult<PagedResult<UserVm>>> GetPagingUsers(GetUserPagingRequest payload)
        {
            var list = new List<string>();
            string api = "/api/Users/paging";

            list.Add("PageIndex=" + payload.PageIndex.ToString());
            list.Add("PageSize=" + payload.PageSize.ToString());

            if (!string.IsNullOrWhiteSpace(payload.Keyword))
                list.Add("Keyword=" + payload.Keyword.ToString());

            return await _httpClientService.GetAsync<ApiResult<PagedResult<UserVm>>>(_host + (list.Count > 0 ? api + "?" + string.Join("&", list) : api), string.Empty);
        }

        public async Task<ApiResult<bool>> RegisterUser(RegisterRequest payload) => await _httpClientService.PostAsync<ApiResult<bool>, RegisterRequest>(_host + "/api/Users", payload, string.Empty);
    
        public async Task<ApiResult<bool>> UpdateUser(Guid id, UserUpdateRequest payload) => await _httpClientService.PutAsync<ApiResult<bool>, UserUpdateRequest>(_host + $"/api/Users/{id}", payload, string.Empty);
        
        public async Task<ApiResult<UserVm>> GetUser(Guid id) => await _httpClientService.GetAsync<ApiResult<UserVm>>(_host + $"/api/Users/{id}", string.Empty);
        
        public async Task<ApiResult<bool>> DeleteUser(Guid id) => await _httpClientService.DeleteAsync<ApiResult<bool>>(_host + $"/api/Users/{id}", string.Empty);
        
        public async Task<ApiResult<bool>> ChangeRoleUser(Guid id, RoleAssignRequest payload) => await _httpClientService.PutAsync<ApiResult<bool>, RoleAssignRequest>(_host + $"/api/Users/{id}/roles", payload, string.Empty);
    }
}
