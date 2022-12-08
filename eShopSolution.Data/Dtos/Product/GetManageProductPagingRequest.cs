using eShopSolution.Data.Dtos.Common;


namespace eShopSolution.Data.Dtos.Product
{
    public class GetManageProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}