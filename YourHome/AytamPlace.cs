//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YourHome
{
    using System;
    using System.Collections.Generic;
    
    public partial class AytamPlace
    {
        public int Id { get; set; }
        public string Mobile { get; set; }
        public string Website { get; set; }
        public string Description { get; set; }
        public Nullable<int> CityId { get; set; }
        public string Mail { get; set; }
        public string Photos { get; set; }
    
        public virtual City City { get; set; }
    }
}