using QTBookShop.Logic.Models.App;

namespace QTBookShop.Logic.Entities.Base
{
    [Table("Authors")]
    [Index(nameof(LastName), nameof(FirstName), IsUnique = true)]
    public class Author : VersionEntity
    {
        [MaxLength(64)]
        public string FirstName { get; set; } = string.Empty;
        [MaxLength(64)]
        public string LastName { get; set; } = string.Empty;
        
        #region Navigation properties
//        public List<Book> Books { get; set; } = new();
        #endregion Navigation properties
    }
}
