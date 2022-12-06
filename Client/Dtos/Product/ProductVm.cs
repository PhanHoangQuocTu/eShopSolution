using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Client.Dtos.Product
{
    public class ProductVm
    {
        public int Id { set; get; }

        [Display(Name = "Tên")]
        public string Name { set; get; }

        [Display(Name = "Giá nhập")]
        public decimal OriginalPrice { set; get; }

        [Display(Name = "Giá bán")]
        public decimal Price { set; get; }

        [Display(Name = "Số lượng")]
        public int Stock { set; get; }

        [Display(Name = "Mô tả")]
        public string Description { set; get; }

        [Display(Name = "Chi tiết")]
        public string Details { set; get; }
    }
}