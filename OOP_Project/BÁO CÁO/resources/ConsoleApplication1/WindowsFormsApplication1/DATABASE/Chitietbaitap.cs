//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1.DATABASE
{
    using System;
    using System.Collections.Generic;
    
    public partial class Chitietbaitap
    {
        public int ID { get; set; }
        public int ID_BAITAP { get; set; }
        public Nullable<int> ID_CAUHOI { get; set; }
    
        public virtual Baitap Baitap { get; set; }
        public virtual Cauhoi Cauhoi { get; set; }
    }
}
