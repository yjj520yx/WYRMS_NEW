//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WYRMS.Domain.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserGroups
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public string Description { get; set; }
        public int OrderSort { get; set; }
        public bool Enabled { get; set; }
        public System.DateTime UpdateDate { get; set; }
    }
}
