//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestReport1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hr_ShiftGroups
    {
        public string Company_Id { get; set; }
        public string Branch_Id { get; set; }
        public string ShiftGroup_Id { get; set; }
        public string ShiftGroup_Name { get; set; }
        public string ShiftGroup_NameEn { get; set; }
        public string ShiftGroup_ShortName { get; set; }
        public string ShiftGroup_NameConv { get; set; }
        public string InsUser { get; set; }
        public System.DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string DeleteUser { get; set; }
        public Nullable<System.DateTime> DeleteDate { get; set; }
        public byte Rec_Status { get; set; }
        public decimal Id { get; set; }
    
        public virtual Hr_Branches Hr_Branches { get; set; }
    }
}
