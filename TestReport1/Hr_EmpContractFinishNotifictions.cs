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
    
    public partial class Hr_EmpContractFinishNotifictions
    {
        public decimal RecNotify_No { get; set; }
        public System.Guid NotifyHdrId { get; set; }
        public string Company_Id { get; set; }
        public string Branch_Id { get; set; }
        public Nullable<decimal> Emp_Serial_No { get; set; }
        public Nullable<System.Guid> EmpHdrId { get; set; }
        public string FinishMonth_No { get; set; }
        public Nullable<System.Guid> RecContractHdr_Id { get; set; }
        public System.DateTime InsDate { get; set; }
        public Nullable<decimal> ResponsibleEmpIdToNotify { get; set; }
        public string NotifyMessage { get; set; }
        public string NotifyMessageEn { get; set; }
        public string EndContract { get; set; }
    }
}