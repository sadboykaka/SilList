//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SO.SilList.CodeGeneration.DbContexts.SilList
{
    using System;
    using System.Collections.Generic;
    
    public partial class BusinessCategoryType
    {
        public BusinessCategoryType()
        {
            this.BusinessCategories = new HashSet<BusinessCategories>();
        }
    
        public int businessCategoryTypeId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public Nullable<int> createdBy { get; set; }
        public Nullable<int> modifiedBy { get; set; }
        public System.DateTime modified { get; set; }
        public System.DateTime created { get; set; }
        public bool isActive { get; set; }
        public Nullable<int> siteId { get; set; }
    
        public virtual ICollection<BusinessCategories> BusinessCategories { get; set; }
        public virtual Site Site { get; set; }
    }
}
