//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MarketPlace
{
    using System;
    using System.Collections.Generic;
    
    public partial class GoodsMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GoodsMaster()
        {
            this.CheckIns = new HashSet<CheckIn>();
        }
    
        public int GoodsID { get; set; }
        public int GoodsTypeID { get; set; }
        public string GoodsName { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public int Createdby { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
    
        public virtual GoodsTypeMaster GoodsTypeMaster { get; set; }
        public virtual UserMaster UserMaster { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CheckIn> CheckIns { get; set; }
    }
}
