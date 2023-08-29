//@CodeCopy
//MdStart
#if ACCOUNT_ON && ACCESSRULES_ON
namespace QTBookShop.Logic.Contracts.Access
{
    using QTBookShop.Logic.Contracts.Account;

    public partial interface IAccessRulesAccess
    {
        Task<bool> CanBeCreatedAsync(Type type, IIdentity identity);
        Task<bool> CanBeReadAsync(IIdentifyable item, IIdentity identity);
        Task<bool> CanBeChangedAsync(IIdentifyable item, IIdentity identity);
        Task<bool> CanBeDeletedAsync(IIdentifyable item, IIdentity identity);
    }
}
#endif
//MdEnd
