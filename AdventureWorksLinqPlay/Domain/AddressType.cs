//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdventureWorksLinqPlay.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class AddressType
    {
        public AddressType()
        {
            this.BusinessEntityAddresses = new HashSet<BusinessEntityAddress>();
        }
    
        public int AddressTypeID { get; set; }
        public string Name { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ICollection<BusinessEntityAddress> BusinessEntityAddresses { get; set; }
    }
}
