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
    
    public partial class Topic
    {
        public int Id { get; set; }
        public string TopicAddress { get; set; }
        public string TopicContent { get; set; }
        public Nullable<bool> IsClosed { get; set; }
        public string Notes { get; set; }
        public string Mobile { get; set; }
        public string Mail { get; set; }
        public string HouseAddress { get; set; }
        public string MobileUserName { get; set; }
        public string AnotherMobilePhone { get; set; }
        public string ResonOfAbsense { get; set; }
        public string Photos { get; set; }
        public string MainPhoto { get; set; }
        public Nullable<System.DateTime> AbsenceDate { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public Nullable<int> CityId { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual City City { get; set; }
    }
}