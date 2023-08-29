//@CodeCopy
//MdStart
#if ACCOUNT_ON
namespace QTBookShop.Logic.Contracts.Account
{
    using QTBookShop.Logic.Entities.Account;

    public partial interface IIdentityXRole
    {
        IdType IdentityId { get; set; }
        IdType RoleId { get; set; }
        Role? Role { get; set; }
    }
}
#endif
//MdEnd
