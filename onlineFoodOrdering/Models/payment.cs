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
    
    public partial class payment
    {
        public int code { get; set; }
        public System.DateTime payment_time { get; set; }
        public string payment_system_name { get; set; }
        public int order_code { get; set; }
    
        public virtual orders orders { get; set; }
    }
}
