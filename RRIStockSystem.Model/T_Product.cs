//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace RRIStockSystem.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_Product()
        {
            this.T_Stock = new HashSet<T_Stock>();
        }
    
        public System.Guid ID { get; set; }
        public string Name { get; set; }
        public string Manufactor { get; set; }
        public string Mobile { get; set; }
        public System.Guid FK_Variety { get; set; }
        public string Region { get; set; }
        public string Remark { get; set; }
        public bool IfDelete { get; set; }
    
        public virtual T_Variety T_Variety { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Stock> T_Stock { get; set; }
    }
}
