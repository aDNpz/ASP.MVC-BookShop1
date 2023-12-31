﻿//@GeneratedCode
namespace QTBookShop.Logic.Models.App
{
    ///
    /// Generated by the generator
    ///
    public partial class Book
    {
        ///
        /// Generated by the generator
        ///
        static Book()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        
        ///
        /// Generated by the generator
        ///
        public Book()
        {
            Constructing();
            _source = new Entities.App.Book();
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        ///
        /// Generated by the generator
        ///
        internal Book(Entities.App.Book source)
        {
            Constructing();
            _source = source;
            Constructed();
        }
        
        new internal Entities.App.Book Source
        {
            get => (Entities.App.Book)(_source!);
            set => _source = value;
        }
        
        public IdType AuthorId
        {
            get => Source.AuthorId;
            set => Source.AuthorId = value;
        }
        
        public System.String Title
        {
            get => Source.Title;
            set => Source.Title = value;
        }
        
        public System.String? Description
        {
            get => Source.Description;
            set => Source.Description = value;
        }
        
        public System.Decimal Price
        {
            get => Source.Price;
            set => Source.Price = value;
        }
        
        public QTBookShop.Logic.Models.Base.Author? Author
        {
            get => Source.Author != null ? QTBookShop.Logic.Models.Base.Author.Create(Source.Author) : null;
            set => Source.Author = value?.Source;
        }
        
        private CommonBase.Modules.Collection.DelegateList<QTBookShop.Logic.Entities.App.Order, QTBookShop.Logic.Models.App.Order>? _orders;
        public System.Collections.Generic.IList<QTBookShop.Logic.Models.App.Order> Orders
        {
            get => _orders ??= new CommonBase.Modules.Collection.DelegateList<QTBookShop.Logic.Entities.App.Order, QTBookShop.Logic.Models.App.Order>(Source.Orders, e => QTBookShop.Logic.Models.App.Order.Create(e));
        }
        
        private CommonBase.Modules.Collection.DelegateList<QTBookShop.Logic.Entities.Base.Category, QTBookShop.Logic.Models.Base.Category>? _categories;
        public System.Collections.Generic.IList<QTBookShop.Logic.Models.Base.Category> Categories
        {
            get => _categories ??= new CommonBase.Modules.Collection.DelegateList<QTBookShop.Logic.Entities.Base.Category, QTBookShop.Logic.Models.Base.Category>(Source.Categories, e => QTBookShop.Logic.Models.Base.Category.Create(e));
        }
        ///
        /// Generated by the generator
        ///
        internal void CopyProperties(Entities.App.Book other)
        {
            bool handled = false;
            BeforeCopyProperties(other, ref handled);
            if (handled == false)
            {
                AuthorId = other.AuthorId;
                Title = other.Title;
                Description = other.Description;
                Price = other.Price;
                Author = other.Author != null ? QTBookShop.Logic.Models.Base.Author.Create((object)other.Author) : null;
                Id = other.Id;
            }
            AfterCopyProperties(other);
        }
        partial void BeforeCopyProperties(Entities.App.Book other, ref bool handled);
        partial void AfterCopyProperties(Entities.App.Book other);
        ///
        /// Generated by the generator
        ///
        public void CopyProperties(QTBookShop.Logic.Models.App.Book other)
        {
            bool handled = false;
            BeforeCopyProperties(other, ref handled);
            if (handled == false)
            {
                AuthorId = other.AuthorId;
                Title = other.Title;
                Description = other.Description;
                Price = other.Price;
                Author = other.Author != null ? QTBookShop.Logic.Models.Base.Author.Create((object)other.Author) : null;
                Id = other.Id;
            }
            AfterCopyProperties(other);
        }
        partial void BeforeCopyProperties(QTBookShop.Logic.Models.App.Book other, ref bool handled);
        partial void AfterCopyProperties(QTBookShop.Logic.Models.App.Book other);
        ///
        /// Generated by the generator
        ///
        public override bool Equals(object? obj)
        {
            bool result = false;
            if (obj is Models.App.Book other)
            {
                result = Id == other.Id;
            }
            return result;
        }
        ///
        /// Generated by the generator
        ///
        public override int GetHashCode()
        {
            return this.CalculateHashCode(AuthorId, Title, Description, Price, Author, Orders, Categories, Id);
        }
        ///
        /// Generated by the generator
        ///
        public static QTBookShop.Logic.Models.App.Book Create()
        {
            BeforeCreate();
            var result = new QTBookShop.Logic.Models.App.Book();
            AfterCreate(result);
            return result;
        }
        ///
        /// Generated by the generator
        ///
        public static QTBookShop.Logic.Models.App.Book Create(object other)
        {
            BeforeCreate(other);
            var result = new QTBookShop.Logic.Models.App.Book();
            CommonBase.Extensions.ObjectExtensions.CopyFrom(result, other);
            AfterCreate(result, other);
            return result;
        }
        ///
        /// Generated by the generator
        ///
        public static QTBookShop.Logic.Models.App.Book Create(QTBookShop.Logic.Models.App.Book other)
        {
            BeforeCreate(other);
            var result = new QTBookShop.Logic.Models.App.Book();
            result.CopyProperties(other);
            AfterCreate(result, other);
            return result;
        }
        ///
        /// Generated by the generator
        ///
        public static QTBookShop.Logic.Models.App.Book Create(Entities.App.Book other)
        {
            BeforeCreate(other);
            var result = new QTBookShop.Logic.Models.App.Book();
            result.Source = other;
            AfterCreate(result, other);
            return result;
        }
        static partial void BeforeCreate();
        static partial void AfterCreate(QTBookShop.Logic.Models.App.Book instance);
        static partial void BeforeCreate(object other);
        static partial void AfterCreate(QTBookShop.Logic.Models.App.Book instance, object other);
        static partial void BeforeCreate(QTBookShop.Logic.Models.App.Book other);
        static partial void AfterCreate(QTBookShop.Logic.Models.App.Book instance, QTBookShop.Logic.Models.App.Book other);
        static partial void BeforeCreate(Entities.App.Book other);
        static partial void AfterCreate(QTBookShop.Logic.Models.App.Book instance, Entities.App.Book other);
    }
}
