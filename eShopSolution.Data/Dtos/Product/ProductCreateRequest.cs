

namespace eShopSolution.Data.Dtos.Product
{
    public class ProductCreateRequest
    {
        public string? Code { set; get; }
        public string? Name { set; get; }
        public decimal? ImportPrice { set; get; }
        public decimal? Price { set; get; }
        public int? QuantityInStock { set; get; }
        public ProductCreateRequest()
        {
            Code = string.Empty;
            Name = string.Empty;
            ImportPrice = null;
            Price = null;
            QuantityInStock = null;
        }
    }
}