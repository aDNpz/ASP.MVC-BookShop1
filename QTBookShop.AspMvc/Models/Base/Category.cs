namespace QTBookShop.AspMvc.Models.Base
{
    public class Category : VersionModel
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public static Category Create(Logic.Models.Base.Category entity)
        {
            return new Category
            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description,
            };
        }
    }
}
