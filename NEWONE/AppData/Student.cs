//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NEWONE.AppData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public int studentID { get; set; }
        public Nullable<int> IDNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Course { get; set; }
        public Nullable<int> psitsId { get; set; }
        public Nullable<int> eventId { get; set; }
    
        public virtual PSITS PSITS { get; set; }
        public virtual Student Student1 { get; set; }
        public virtual Student Student2 { get; set; }
    }
}
