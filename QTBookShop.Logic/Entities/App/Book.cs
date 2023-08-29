using QTBookShop.Logic.Entities.Base;

namespace QTBookShop.Logic.Entities.App
{
    [Table("Books")]
    [Index(nameof(Title), IsUnique = true)]
    public class Book : VersionEntity
    {
        public IdType AuthorId { get; set; }
        [MaxLength(264)]
        public string Title { get; set; } = string.Empty;
        [MaxLength(2048)]
        public string? Description { get; set; }
        public decimal Price { get; set; }

        #region Navigation properties
        public Author? Author { get; set; }
        public List<Order> Orders { get; set; } = new();
        public List<Category> Categories { get; set; } = new();
        #endregion Navigation properties
    }
}
