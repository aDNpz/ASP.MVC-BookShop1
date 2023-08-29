//@CodeCopy
//MdStart
#if ACCOUNT_ON && ACCESSRULES_ON
namespace QTBookShop.Logic.Contracts.Access
{
    using TOutModel = Models.Access.AccessRule;

    public partial interface IAccessRulesAccess : Contracts.IDataAccess<TOutModel>
    {
    }
}
#endif
//MdEnd
