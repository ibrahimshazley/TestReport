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
    
    public partial class Hr_HiringMonth_DelayDues_Dtls
    {
        public System.Guid Dtls_Id { get; set; }
        public System.Guid Rec_Hdr_Id { get; set; }
        public string HireItem_Id { get; set; }
        public byte HireItem_Type { get; set; }
        public decimal HireItem_DuesValue { get; set; }
        public byte HireItem_Status { get; set; }
    
        public virtual Hr_HiringMonth_DelayDues_Hdr Hr_HiringMonth_DelayDues_Hdr { get; set; }
    }
}
