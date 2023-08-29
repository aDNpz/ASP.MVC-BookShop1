#if GENERATEDCODE_ON
namespace QTBookShop.Logic.Controllers.App
{
    partial class BooksController
    {
        internal override IEnumerable<string> Includes => new[]
            { nameof(Entities.App.Book.Author), nameof(Entities.App.Book.Categories), nameof(Entities.App.Book.Orders) };
    }
}
#endif
