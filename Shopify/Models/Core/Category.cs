using System.ComponentModel.DataAnnotations;

namespace Shopify.Models.Core
{
    public class Category
    {
        [MaxLength(50)]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
