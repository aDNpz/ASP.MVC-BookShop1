using System.Text;

namespace QTBookShop.ConApp
{
    partial class Program
    {
        static partial void AfterRun()
        {
            Task.Run(async () => await ImportGenresAsync("genres.csv")).Wait();
            Task.Run(async () => await ImportAuthorenAsync("authors.csv")).Wait();
            Task.Run(async () => await CreateBooksAsync()).Wait();
        }

        static async Task ImportGenresAsync(string filePath)
        {
            using var ctrl = new Logic.Controllers.Base.CategoriesController();

            foreach (var line in await File.ReadAllLinesAsync(filePath, Encoding.Default))
            {
                var data = line.Split(";");
                var entity = ctrl.Create();

                entity.Name = data[0];
                entity.Description = data[1];

                await ctrl.InsertAsync(entity);
            }
            await ctrl.SaveChangesAsync();
        }
        static async Task ImportAuthorenAsync(string filePath)
        {
            using var ctrl = new Logic.Controllers.Base.AuthorsController();

            foreach (var line in await File.ReadAllLinesAsync(filePath, Encoding.Default))
            {
                var data = line.Split(";");
                var entity = ctrl.Create();

                entity.FirstName = data[0];
                entity.LastName = data[1];

                await ctrl.InsertAsync(entity);
            }
            await ctrl.SaveChangesAsync();
        }

        static async Task CreateBooksAsync()
        {
            using var booksCtrl = new Logic.Controllers.App.BooksController();
            using var ordersCtrl = new Logic.Controllers.App.OrdersController(booksCtrl);
            using var authorsCtrl = new Logic.Controllers.Base.AuthorsController(booksCtrl);
            using var categoriesCtrl = new Logic.Controllers.Base.CategoriesController(booksCtrl);
            var authors = await authorsCtrl.GetAllAsync();
            var categories = await categoriesCtrl.GetAllAsync();

            for (int i = 0; i < 10; i++)
            {
                var book = booksCtrl.Create();

                book.Title = $"Mein {i + 1}. Buch";
                book.Description = $"Beschreibung {i + 1}";
                book.Price = 10.0m + i;
                book.AuthorId = authors[i].Id;

                for (int j = 0; j < 5; j++)
                {
                    var q = j + 1;

                    book.Orders.Add(new Logic.Models.App.Order
                    {
                        Date = DateTime.Now.AddDays(j),
                        Quantity = q,
                        Price = book.Price * q,
                    });
                }
                book = await booksCtrl.InsertAsync(book);
                await booksCtrl.SaveChangesAsync();

                for (int j = 0; j < 5 * 0; j++)
                {
                    var category = await categoriesCtrl.GetByIdAsync(categories[j * 2].Id);

                    if (category != null)
                    {
                        book.Categories.Add(category);
                    }
                }
                await booksCtrl.SaveChangesAsync();
            }
        }
    }
}
