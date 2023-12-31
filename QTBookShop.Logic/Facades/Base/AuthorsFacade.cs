﻿//@GeneratedCode
namespace QTBookShop.Logic.Facades.Base
{
    using TOutModel = Models.Base.Author;
    ///
    /// Generated by the generator
    ///
    public sealed partial class AuthorsFacade : ControllerFacade<TOutModel>, Contracts.Base.IAuthorsAccess
    {
        ///
        /// Generated by the generator
        ///
        static AuthorsFacade()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        
        ///
        /// Generated by the generator
        ///
        public AuthorsFacade()
        : base(new QTBookShop.Logic.Controllers.Base.AuthorsController())
        {
            Constructing();
            
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        ///
        /// Generated by the generator
        ///
        public AuthorsFacade(FacadeObject facadeObject)
        : base(new QTBookShop.Logic.Controllers.Base.AuthorsController(facadeObject.ControllerObject))
        {
            Constructing();
            
            Constructed();
        }
    }
}
