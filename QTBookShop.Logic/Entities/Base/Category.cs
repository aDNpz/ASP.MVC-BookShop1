namespace QTBookShop.Logic.Entities.Base
{
    [Table("Categories")]
    [Index(nameof(Name), IsUnique = true)]
    public class Category : VersionEntity
    {
        [MaxLength(128)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(2048)]
        public string Description { get; set; } = string.Empty;
        
        #region Navigation properties
        public List<App.Book> Books { get; set; } = new();
        #endregion Navigation properties
    }
}
