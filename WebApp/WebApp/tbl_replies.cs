//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_replies
    {
        public int id { get; set; }
        public Nullable<int> q_id { get; set; }
        public string name { get; set; }
        public string replies { get; set; }
        public string user_image { get; set; }
    
        public virtual tbl_queries tbl_queries { get; set; }
    }
}
