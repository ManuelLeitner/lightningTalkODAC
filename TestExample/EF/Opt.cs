//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Opt
    {
        public Opt()
        {
            this.Order = new HashSet<Order>();
        }
    
        public long ID { get; set; }
        public string Blockname { get; set; }
        public string SwitchCondition { get; set; }
        public long Number { get; set; }
    
        public virtual ICollection<Order> Order { get; set; }
    }
}
