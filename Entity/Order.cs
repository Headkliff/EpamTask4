//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public System.Guid Id { get; set; }
        public System.DateTime Data { get; set; }
    
        public virtual Manager Manager { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Item Item { get; set; }
    }
}
