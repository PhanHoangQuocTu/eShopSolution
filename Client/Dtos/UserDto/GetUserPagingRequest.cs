

using Client.Dtos.Common;

namespace Client.Dtos.UserDto
{
    public class GetUserPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}