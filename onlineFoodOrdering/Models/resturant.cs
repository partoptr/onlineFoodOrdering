//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace onlineFoodOrdering.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class resturant
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public resturant()
        {
            this.delivery = new HashSet<delivery>();
            this.manages = new HashSet<manages>();
            this.work_time = new HashSet<work_time>();
            this.FinR = new HashSet<FinR>();
        }
    
        public int branch_code { get; set; }
        public string branch_name { get; set; }
        public string name { get; set; }
        public Nullable<System.DateTime> startdate { get; set; }
        public Nullable<byte> point { get; set; }
        public string r_city { get; set; }
        public string r_address { get; set; }
        public string r_province { get; set; }
        public long r_phone_number { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<delivery> delivery { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<manages> manages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<work_time> work_time { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FinR> FinR { get; set; }
    }
}
