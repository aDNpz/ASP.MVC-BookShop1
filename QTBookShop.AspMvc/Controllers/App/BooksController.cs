using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QTBookShop.Logic.Contracts.App;
using QTBookShop.Logic.Contracts.Base;
using System.Diagnostics;

namespace QTBookShop.AspMvc.Controllers.App
{
	public class BooksController : Controller
	{
		private readonly IBooksAccess _booksAccess;
		private readonly ICategoriesAccess _categoriesAccess;
		private readonly IAuthorsAccess _authorsAccess;

		public BooksController(IBooksAccess booksAccess, ICategoriesAccess categoriesAccess, IAuthorsAccess authorsAccess)
		{
			_booksAccess = booksAccess;
			_categoriesAccess = categoriesAccess;
			_authorsAccess = authorsAccess;
		}

		// GET: BooksController
		public async Task<ActionResult> Index()
		{
			var entity = await _booksAccess.GetAllAsync();
			var models = entity.Select(e => Models.App.Book.Create(e)).ToArray();
			return View(models);
		}

		// GET: BooksController/Details/5
		public async Task<ActionResult> Details(int id)
		{
			var entity = await _booksAccess.GetByIdAsync(id);
			var model = default(Models.App.Book);
			if (entity != null)
			{
				model = Models.App.Book.Create(entity);
			}
			return model != null ? View(model) : NotFound();
		}

		// GET: BooksController/Create
		public ActionResult Create()
		{
			var entity = _booksAccess.Create();
			return View(Models.App.Book.Create(entity));
		}

		// POST: BooksController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Create(Models.App.Book model)
		{
			try
			{
				var entity = _booksAccess.Create();
				model.CopyFrom(entity);
				await _booksAccess.InsertAsync(entity);
				await _booksAccess.SaveChangesAsync();
				return RedirectToAction(nameof(Edit), new { id = entity.Id });
			}
			catch (Exception ex)
			{
				ViewBag.Error = ex.Message;
				return View(model);
			}
		}

		// GET: BooksController/Edit/5
		public async Task<ActionResult> Edit(int id)
		{
			var entity = await _booksAccess.GetByIdAsync(id);
			var model = default(Models.App.Book);
			if (entity != null)
			{
				var existingCategories = entity.Categories.Select(c => c.Id).ToArray();
				var categories = await _categoriesAccess.GetAllAsync();
				var AddCategories = categories.Where(c => existingCategories.Contains(c.Id) == false);
				model = Models.App.Book.Create(entity);
				model.AddCategories = AddCategories.Select(c => Models.Base.Category.Create(c)).ToList();
			}
			return View(model);
		}

		// POST: BooksController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Edit(int id, Models.App.Book model)
		{
			try
			{
				var entity = await _booksAccess.GetByIdAsync(id);
				if (entity != null)
				{
					entity.CopyFrom(model);
					await _booksAccess.UpdateAsync(entity);
					await _booksAccess.SaveChangesAsync();
				}
				return RedirectToAction(nameof(Index));
			}
			catch (Exception ex)
			{
				ViewBag.Error = ex.Message;
				return View(model);
			}
		}

		public async Task<ActionResult> AddCategory(int bookId, int categoryId)
		{
			var bookEntity = await _booksAccess.GetByIdAsync(bookId);
			var catEntity = await _categoriesAccess.GetByIdAsync(categoryId);

			if (bookEntity != null && catEntity != null)
			{
				bookEntity.Categories.Add(catEntity);
				await _booksAccess.UpdateAsync(bookEntity);
				await _booksAccess.SaveChangesAsync();
			}
			return RedirectToAction(nameof(Edit), new { id = bookId });
		}

		public async Task<ActionResult> RemoveCategory(int bookId, int categoryId)
		{
			var bookEntity = await _booksAccess.GetByIdAsync(bookId);
			var catEntity = await _categoriesAccess.GetByIdAsync(categoryId);

			if (bookEntity != null && catEntity != null)
			{
				bookEntity.Categories.Remove(catEntity);
				await _booksAccess.UpdateAsync(bookEntity);
				await _booksAccess.SaveChangesAsync();
			}
			return RedirectToAction(nameof(Edit), new { id = bookId });
		}

		// GET: BooksController/Delete/5
		public async Task<ActionResult> Delete(int id)
		{
			var entity = await _booksAccess.GetByIdAsync(id);
			var model = default(Models.App.Book);
			if (entity != null)
			{
				model = Models.App.Book.Create(entity);
			}
			return model != null ? View(model) : NotFound();
		}

		// POST: BooksController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult>Delete(int id, Models.App.Book model)
		{
			try
			{
				var entity = await _booksAccess.GetByIdAsync(id);
				if (entity != null)
				{
					entity.Categories.Clear();
					await _booksAccess.SaveChangesAsync();
				}
				await _booksAccess.DeleteAsync(id);
				await _booksAccess.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			catch (Exception ex) 
			{
				ViewBag.Exception = ex.Message;
				return View(model);
			}
		}
	}
}
