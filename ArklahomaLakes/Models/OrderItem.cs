//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArklahomaLakes.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderItem
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }
        public decimal LineTotal { get; set; }
        public System.DateTime AddTstamp { get; set; }
        public System.DateTime UpdTstamp { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
