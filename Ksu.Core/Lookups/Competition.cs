//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Arabia.Core.Lookups
{
    using System;
    using System.Collections.Generic;
    
    public partial class Competition :BaseEntity
    {
        public int Competition_Id { get; set; }
        public string Competition_Name { get; set; }
        public string Competition_Type { get; set; }
        public string Competition_Format { get; set; }
        public Nullable<int> area_id { get; set; }
        public string Competition_Team_Type { get; set; }
        public string Competition_soccer_Type { get; set; }
        public Nullable<System.DateTime> Last_updated { get; set; }
        public Nullable<int> DisplayOrder { get; set; }
        public Nullable<bool> Competition_Authorized { get; set; }
        public Nullable<bool> Competition_Active { get; set; }
        public Nullable<System.DateTime> Competition_InsDate { get; set; }
        public Nullable<System.DateTime> Competition_LastUpdate { get; set; }
        public Nullable<int> Competition_Order { get; set; }
    }
}