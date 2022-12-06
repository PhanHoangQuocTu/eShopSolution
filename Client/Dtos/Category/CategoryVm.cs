
using System.ComponentModel.DataAnnotations;

namespace Client.Dtos.Category
{
    public class CategoryVm
    {
        public int Id { get; set; }

        [Display(Name = "Tên")]
        public string Name { get; set; }

        public int? ParentId { get; set; }
    }
}