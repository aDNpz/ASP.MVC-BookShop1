namespace QTBookShop.AspMvc.Models.Base
{
    public class Author : VersionModel
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FullName => $"{FirstName} {LastName}";

        public static Author Create(Logic.Models.Base.Author entity)
        {
            return new Author
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
            };
        }
    }
}
