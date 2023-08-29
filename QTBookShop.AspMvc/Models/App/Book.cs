using QTBookShop.AspMvc.Models.Base;
using QTBookShop.Logic.Controllers.App;

namespace QTBookShop.AspMvc.Models.App
{
    public class Book : VersionModel
    {
        public IdType AuthorId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public decimal Sale { get; set; }
        public List<Category> AddCategories { get; set; } = new();

        #region Navigation properties
        public Author Author { get; set; }
        public List<Order> Orders { get; set; } = new();
        public List<Category> Categories { get; set; } = new();
        #endregion Navigation properties

        public static Book Create(Logic.Models.App.Book entity)
        {
            return new Book
            {
                Id = entity.Id,
                AuthorId = entity.AuthorId,
                Title = entity.Title,
                Description = entity.Description,
                Price = entity.Price,
                Author = Models.Base.Author.Create(entity.Author!),
                Categories = entity.Categories.Select(c => Models.Base.Category.Create(c)).ToList(),
                Orders = entity.Orders.Select(o => Models.App.Order.Create(o)).ToList(),
                Sale = entity.Price * entity.Orders.Count(o => o.BookId == entity.Id),
            };
            
        }
    }
}
