using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShopSolution.Data.Entities
{
    [Table("ProductsM")]
    public class ProductsM
    {
        [Key]
        [Column("id")]
        public string? Id { get; set; }
        [Column("code")]
        public string? Code { get; set; }
        [Column("name")]
        public string? Name { get; set; }
        [Column("import_price")]
        public decimal? ImportPrice { get; set; }
        [Column("price")]
        public decimal? Price { get; set; }
        [Column("quantity_in_stock")]
        public int? QuantityInStock { get; set; }
        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }
        public ProductsM()
        {
            Id = Guid.NewGuid().ToString();
            Code = String.Empty;
            Name = String.Empty;
        }
    }
}
