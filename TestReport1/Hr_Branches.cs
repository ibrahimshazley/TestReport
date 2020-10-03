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
    
    public partial class Hr_Branches
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hr_Branches()
        {
            this.Hr_Administrations = new HashSet<Hr_Administrations>();
            this.Hr_Branch_Docs_Hdr = new HashSet<Hr_Branch_Docs_Hdr>();
            this.Hr_Employees = new HashSet<Hr_Employees>();
            this.Hr_GradeJobGroups = new HashSet<Hr_GradeJobGroups>();
            this.Hr_ShiftGroups = new HashSet<Hr_ShiftGroups>();
            this.Hr_Shifts = new HashSet<Hr_Shifts>();
        }
    
        public string Company_Id { get; set; }
        public string Branch_Id { get; set; }
        public string Branch_Code { get; set; }
        public string Branch_Name { get; set; }
        public string Branch_NameEn { get; set; }
        public string Branch_NameConv { get; set; }
        public string Branch_AccountNo { get; set; }
        public string InsUser { get; set; }
        public System.DateTime InsDate { get; set; }
        public string UpdateUser { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string DeleteUser { get; set; }
        public Nullable<System.DateTime> DeleteDate { get; set; }
        public byte Rec_Status { get; set; }
        public string Prefix { get; set; }
        public string Country_Id { get; set; }
        public string City_Id { get; set; }
        public string Currency_Id { get; set; }
        public string StreetName { get; set; }
        public string Buiding_Number { get; set; }
        public string P_O_Box { get; set; }
        public string Postal_Code { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Phone3 { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string ExtenstionTel1 { get; set; }
        public string ExtenstionTel2 { get; set; }
        public string ExtenstionTel3 { get; set; }
        public Nullable<decimal> ResponsibleEmpId { get; set; }
        public decimal Id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hr_Administrations> Hr_Administrations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hr_Branch_Docs_Hdr> Hr_Branch_Docs_Hdr { get; set; }
        public virtual Hr_Branches Hr_Branches1 { get; set; }
        public virtual Hr_Branches Hr_Branches2 { get; set; }
        public virtual Hr_Companies Hr_Companies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hr_Employees> Hr_Employees { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hr_GradeJobGroups> Hr_GradeJobGroups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hr_ShiftGroups> Hr_ShiftGroups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hr_Shifts> Hr_Shifts { get; set; }
    }
}
