using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Dtos.Product
{
    public class ProductUpdateRequest
    {
        public string? Id { set; get; }
        public string? Name { set; get; }
        public decimal? ImportPrice { set; get; }
        public decimal? Price { set; get; }
        public int? QuantityInStock { set; get; }
        public ProductUpdateRequest()
        {
            Name = string.Empty;
            ImportPrice = null;
            Price = null;
            QuantityInStock = null;
        }
    }
}