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
    
    public partial class Hr_EmpSecondmentRecord
    {
        public System.Guid Rec_Hdr_Id { get; set; }
        public string Company_Id { get; set; }
        public string Branch_Id { get; set; }
        public decimal Rec_No { get; set; }
        public string Request_Id { get; set; }
        public string Rec_Order_No { get; set; }
        public Nullable<System.Guid> Rec_Order_HdrId { get; set; }
        public decimal Emp_Serial_No { get; set; }
        public string TransDate { get; set; }
        public string FromSecondmentDate { get; set; }
        public string Reason { get; set; }
        public string InsUser { get; set; }
        public System.DateTime InsDate { get; set; }
        public string DocumentPath { get; set; }
        public decimal Commissioner_Serial_no { get; set; }
        public string ToSecondmentDate { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public Nullable<decimal> ExpectedValue { get; set; }
        public string Notes { get; set; }
        public string SecondmentType { get; set; }
        public Nullable<decimal> DailySecondmentValue { get; set; }
    
        public virtual Hr_Employees Hr_Employees { get; set; }
    }
}
