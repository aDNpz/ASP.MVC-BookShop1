﻿//@CodeCopy
//MdStart
namespace QTBookShop.Logic.Contracts
{
    public partial interface IVersionable : IIdentifyable
    {
#if ROWVERSION_ON
        byte[]? RowVersion { get; }
#endif
    }
}
//MdEnd
