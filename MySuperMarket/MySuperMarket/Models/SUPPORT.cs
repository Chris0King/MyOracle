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
    
    public partial class SUPPORT
    {
        public string SPONSOR_ID { get; set; }
        public string INCOME_ID { get; set; }
        public Nullable<System.DateTime> SUPPORT_DATE { get; set; }
        public Nullable<long> MONEY { get; set; }
    
        public virtual INCOME INCOME { get; set; }
        public virtual SPONSOR SPONSOR { get; set; }
    }
}
