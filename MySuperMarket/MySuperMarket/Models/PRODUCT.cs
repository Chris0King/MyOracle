//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MySuperMarket.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRODUCT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUCT()
        {
            this.SALES_LOT = new HashSet<SALES_LOT>();
            this.STOCK = new HashSet<STOCK>();
        }
    
        public string BATCH_ID { get; set; }
        public string PRODUCT_ID { get; set; }
        public Nullable<System.DateTime> PRODUCT_DATE { get; set; }
        public Nullable<long> DISCOUNT { get; set; }
        public Nullable<long> BATCH_NUMBER { get; set; }
        public string SHEIF_ID { get; set; }
    
        public virtual PRODUCT_ATTRIBUTE PRODUCT_ATTRIBUTE { get; set; }
        public virtual SHELF SHELF { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SALES_LOT> SALES_LOT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STOCK> STOCK { get; set; }
    }
}
