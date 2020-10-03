﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PharmaERPTestEntities : DbContext
    {
        public PharmaERPTestEntities()
            : base("name=PharmaERPTestEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<App_ErrorLog> App_ErrorLog { get; set; }
        public virtual DbSet<APP_Menus> APP_Menus { get; set; }
        public virtual DbSet<App_Settings> App_Settings { get; set; }
        public virtual DbSet<AppDuesAndDeduct_Setting> AppDuesAndDeduct_Setting { get; set; }
        public virtual DbSet<AppRolesMenuPriviledge> AppRolesMenuPriviledge { get; set; }
        public virtual DbSet<AppUsersMenuPriviledge> AppUsersMenuPriviledge { get; set; }
        public virtual DbSet<AR_Dict> AR_Dict { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Group_Pages> Group_Pages { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<Hr_Absence_Types> Hr_Absence_Types { get; set; }
        public virtual DbSet<Hr_Administrations> Hr_Administrations { get; set; }
        public virtual DbSet<Hr_AlternativeEmployeesTrans> Hr_AlternativeEmployeesTrans { get; set; }
        public virtual DbSet<Hr_AppSettingTypes> Hr_AppSettingTypes { get; set; }
        public virtual DbSet<Hr_Assets_Group> Hr_Assets_Group { get; set; }
        public virtual DbSet<Hr_AssignWorkFlowToRequest> Hr_AssignWorkFlowToRequest { get; set; }
        public virtual DbSet<Hr_Banks> Hr_Banks { get; set; }
        public virtual DbSet<Hr_BeginEmpReceivableDues_Dtls> Hr_BeginEmpReceivableDues_Dtls { get; set; }
        public virtual DbSet<Hr_Branch_Doc_Notification_Dtls> Hr_Branch_Doc_Notification_Dtls { get; set; }
        public virtual DbSet<Hr_Branch_Docs_Dtls_History> Hr_Branch_Docs_Dtls_History { get; set; }
        public virtual DbSet<Hr_Branch_Docs_Hdr> Hr_Branch_Docs_Hdr { get; set; }
        public virtual DbSet<Hr_BranchAccount_Types> Hr_BranchAccount_Types { get; set; }
        public virtual DbSet<Hr_BranchAccounts> Hr_BranchAccounts { get; set; }
        public virtual DbSet<Hr_BranchDocuments> Hr_BranchDocuments { get; set; }
        public virtual DbSet<Hr_Branches> Hr_Branches { get; set; }
        public virtual DbSet<Hr_Cities> Hr_Cities { get; set; }
        public virtual DbSet<Hr_Companies> Hr_Companies { get; set; }
        public virtual DbSet<Hr_CompaniesTree> Hr_CompaniesTree { get; set; }
        public virtual DbSet<Hr_Countries> Hr_Countries { get; set; }
        public virtual DbSet<Hr_Currencies> Hr_Currencies { get; set; }
        public virtual DbSet<Hr_DailyTimeSheet> Hr_DailyTimeSheet { get; set; }
        public virtual DbSet<Hr_DayTypes> Hr_DayTypes { get; set; }
        public virtual DbSet<Hr_DeductionReasons> Hr_DeductionReasons { get; set; }
        public virtual DbSet<Hr_Departments> Hr_Departments { get; set; }
        public virtual DbSet<Hr_DisciplinaryProcedures> Hr_DisciplinaryProcedures { get; set; }
        public virtual DbSet<Hr_DismissalReasons> Hr_DismissalReasons { get; set; }
        public virtual DbSet<Hr_DocumentTypes> Hr_DocumentTypes { get; set; }
        public virtual DbSet<Hr_Emp_Assets> Hr_Emp_Assets { get; set; }
        public virtual DbSet<Hr_Emp_Doc_Notification_Dtls> Hr_Emp_Doc_Notification_Dtls { get; set; }
        public virtual DbSet<Hr_Emp_Docs_Dtls_History> Hr_Emp_Docs_Dtls_History { get; set; }
        public virtual DbSet<Hr_Emp_Docs_Hdr> Hr_Emp_Docs_Hdr { get; set; }
        public virtual DbSet<Hr_Emp_HiringMonthStatus> Hr_Emp_HiringMonthStatus { get; set; }
        public virtual DbSet<Hr_EmpAbsenceRecord> Hr_EmpAbsenceRecord { get; set; }
        public virtual DbSet<Hr_EmpAccomdationFees_Dtls> Hr_EmpAccomdationFees_Dtls { get; set; }
        public virtual DbSet<Hr_EmpAccomdationFees_Hdr> Hr_EmpAccomdationFees_Hdr { get; set; }
        public virtual DbSet<Hr_EmpAccomdationFees_OrgDtls> Hr_EmpAccomdationFees_OrgDtls { get; set; }
        public virtual DbSet<Hr_EmpAccomdationFees_OrgHdr> Hr_EmpAccomdationFees_OrgHdr { get; set; }
        public virtual DbSet<Hr_EmpAccomdationFees_Setting> Hr_EmpAccomdationFees_Setting { get; set; }
        public virtual DbSet<Hr_EmpAnnualLeavePlanRecord> Hr_EmpAnnualLeavePlanRecord { get; set; }
        public virtual DbSet<Hr_EmpAnnualLeavePlanRequest> Hr_EmpAnnualLeavePlanRequest { get; set; }
        public virtual DbSet<Hr_EmpAnnualLeavePlanRequestWorkFlow> Hr_EmpAnnualLeavePlanRequestWorkFlow { get; set; }
        public virtual DbSet<Hr_EmpAttendance_Dtls> Hr_EmpAttendance_Dtls { get; set; }
        public virtual DbSet<Hr_EmpAttendance_Hdr> Hr_EmpAttendance_Hdr { get; set; }
        public virtual DbSet<Hr_EmpBeginAnnualVacTransferdBal> Hr_EmpBeginAnnualVacTransferdBal { get; set; }
        public virtual DbSet<Hr_EmpBorrow_Dtls> Hr_EmpBorrow_Dtls { get; set; }
        public virtual DbSet<Hr_EmpBorrow_Hdr> Hr_EmpBorrow_Hdr { get; set; }
        public virtual DbSet<Hr_EmpBorrow_Settings> Hr_EmpBorrow_Settings { get; set; }
        public virtual DbSet<Hr_EmpBorrowDelayRecord> Hr_EmpBorrowDelayRecord { get; set; }
        public virtual DbSet<Hr_EmpBorrowDelayRequest> Hr_EmpBorrowDelayRequest { get; set; }
        public virtual DbSet<Hr_EmpBorrowDelayRequestWorkFlow> Hr_EmpBorrowDelayRequestWorkFlow { get; set; }
        public virtual DbSet<Hr_EmpBorrowRequest> Hr_EmpBorrowRequest { get; set; }
        public virtual DbSet<Hr_EmpBorrowRequestWorkFlow> Hr_EmpBorrowRequestWorkFlow { get; set; }
        public virtual DbSet<Hr_EmpCertifications> Hr_EmpCertifications { get; set; }
        public virtual DbSet<Hr_EmpContractFinishNotifictions> Hr_EmpContractFinishNotifictions { get; set; }
        public virtual DbSet<Hr_EmpContracts> Hr_EmpContracts { get; set; }
        public virtual DbSet<Hr_EmpDelayRecord> Hr_EmpDelayRecord { get; set; }
        public virtual DbSet<Hr_EmpDisciplinaryProcedureRecord> Hr_EmpDisciplinaryProcedureRecord { get; set; }
        public virtual DbSet<Hr_EmpDisciplinaryProcedureRequest> Hr_EmpDisciplinaryProcedureRequest { get; set; }
        public virtual DbSet<Hr_EmpDisciplinaryProcedureRequestWorkFlow> Hr_EmpDisciplinaryProcedureRequestWorkFlow { get; set; }
        public virtual DbSet<Hr_EmpDismissalRecord> Hr_EmpDismissalRecord { get; set; }
        public virtual DbSet<Hr_EmpDismissalRequest> Hr_EmpDismissalRequest { get; set; }
        public virtual DbSet<Hr_EmpDismissalRequestWorkFlow> Hr_EmpDismissalRequestWorkFlow { get; set; }
        public virtual DbSet<Hr_EmpDues> Hr_EmpDues { get; set; }
        public virtual DbSet<Hr_EmpDues_History> Hr_EmpDues_History { get; set; }
        public virtual DbSet<Hr_EmpDuesVactionTicket> Hr_EmpDuesVactionTicket { get; set; }
        public virtual DbSet<Hr_EmpDuesVactionTicketHistory> Hr_EmpDuesVactionTicketHistory { get; set; }
        public virtual DbSet<Hr_EmpEmploymentRecord> Hr_EmpEmploymentRecord { get; set; }
        public virtual DbSet<Hr_EmpEmploymentRequest> Hr_EmpEmploymentRequest { get; set; }
        public virtual DbSet<Hr_EmpEmploymentRequestWorkFlow> Hr_EmpEmploymentRequestWorkFlow { get; set; }
        public virtual DbSet<Hr_EmpExperiences> Hr_EmpExperiences { get; set; }
        public virtual DbSet<Hr_EmpExtraRecord> Hr_EmpExtraRecord { get; set; }
        public virtual DbSet<Hr_EmpJobMissionRecord> Hr_EmpJobMissionRecord { get; set; }
        public virtual DbSet<Hr_EmpJobMissionRequest> Hr_EmpJobMissionRequest { get; set; }
        public virtual DbSet<Hr_EmpJobMissionRequestWorkFlow> Hr_EmpJobMissionRequestWorkFlow { get; set; }
        public virtual DbSet<Hr_EmployeeContractPeriods> Hr_EmployeeContractPeriods { get; set; }
        public virtual DbSet<Hr_EmployeeContractPeriods_History> Hr_EmployeeContractPeriods_History { get; set; }
        public virtual DbSet<Hr_EmployeeContractsDetails> Hr_EmployeeContractsDetails { get; set; }
        public virtual DbSet<Hr_Employees> Hr_Employees { get; set; }
        public virtual DbSet<Hr_EmployeesHistory> Hr_EmployeesHistory { get; set; }
        public virtual DbSet<Hr_EmployeeStatus> Hr_EmployeeStatus { get; set; }
        public virtual DbSet<Hr_EmploymentExperinceRecord> Hr_EmploymentExperinceRecord { get; set; }
        public virtual DbSet<Hr_EmploymentExperinceRequest> Hr_EmploymentExperinceRequest { get; set; }
        public virtual DbSet<Hr_EmploymentQualifyRecord> Hr_EmploymentQualifyRecord { get; set; }
        public virtual DbSet<Hr_EmploymentQualifyRequest> Hr_EmploymentQualifyRequest { get; set; }
        public virtual DbSet<Hr_EmpOtherMonthlyValueRecord> Hr_EmpOtherMonthlyValueRecord { get; set; }
        public virtual DbSet<Hr_EmpOverTime_Settings> Hr_EmpOverTime_Settings { get; set; }
        public virtual DbSet<Hr_EmpOverTimeOrder> Hr_EmpOverTimeOrder { get; set; }
        public virtual DbSet<Hr_EmpOverTimeOrder_History> Hr_EmpOverTimeOrder_History { get; set; }
        public virtual DbSet<Hr_EmpOverTimeRecord> Hr_EmpOverTimeRecord { get; set; }
        public virtual DbSet<Hr_EmpOverTimeRequest> Hr_EmpOverTimeRequest { get; set; }
        public virtual DbSet<Hr_EmpOverTimeRequestWorkFlow> Hr_EmpOverTimeRequestWorkFlow { get; set; }
        public virtual DbSet<Hr_EmpPermission_Settings> Hr_EmpPermission_Settings { get; set; }
        public virtual DbSet<Hr_EmpPermissionOrder> Hr_EmpPermissionOrder { get; set; }
        public virtual DbSet<Hr_EmpPermissionOrder_History> Hr_EmpPermissionOrder_History { get; set; }
        public virtual DbSet<Hr_EmpPermissionRecord> Hr_EmpPermissionRecord { get; set; }
        public virtual DbSet<Hr_EmpPermissionRequest> Hr_EmpPermissionRequest { get; set; }
        public virtual DbSet<Hr_EmpPermissionRequestWorkFlow> Hr_EmpPermissionRequestWorkFlow { get; set; }
        public virtual DbSet<Hr_EmpQualifications> Hr_EmpQualifications { get; set; }
        public virtual DbSet<Hr_EmpRequestNotify> Hr_EmpRequestNotify { get; set; }
        public virtual DbSet<Hr_EmpResignationRecord> Hr_EmpResignationRecord { get; set; }
        public virtual DbSet<Hr_EmpResignationRequest> Hr_EmpResignationRequest { get; set; }
        public virtual DbSet<Hr_EmpResignationRequestWorkFlow> Hr_EmpResignationRequestWorkFlow { get; set; }
        public virtual DbSet<Hr_EmpRewardRecord> Hr_EmpRewardRecord { get; set; }
        public virtual DbSet<Hr_EmpRewardRequest> Hr_EmpRewardRequest { get; set; }
        public virtual DbSet<Hr_EmpRewardRequestWorkFlow> Hr_EmpRewardRequestWorkFlow { get; set; }
        public virtual DbSet<Hr_EmpSecondment_Setting> Hr_EmpSecondment_Setting { get; set; }
        public virtual DbSet<Hr_EmpSecondmentRecord> Hr_EmpSecondmentRecord { get; set; }
        public virtual DbSet<Hr_EmpSecondmentRequest> Hr_EmpSecondmentRequest { get; set; }
        public virtual DbSet<Hr_EmpSecondmentRequestWorkFlow> Hr_EmpSecondmentRequestWorkFlow { get; set; }
        public virtual DbSet<Hr_EmpSkills> Hr_EmpSkills { get; set; }
        public virtual DbSet<Hr_EmpSons> Hr_EmpSons { get; set; }
        public virtual DbSet<Hr_EmpSpouses> Hr_EmpSpouses { get; set; }
        public virtual DbSet<Hr_EmpTransferEmployeeRecord> Hr_EmpTransferEmployeeRecord { get; set; }
        public virtual DbSet<Hr_EmpTransferEmployeeRequest> Hr_EmpTransferEmployeeRequest { get; set; }
        public virtual DbSet<Hr_EmpTransferEmployeeRequestWorkFlow> Hr_EmpTransferEmployeeRequestWorkFlow { get; set; }
        public virtual DbSet<Hr_EmpTravelTickectRecord> Hr_EmpTravelTickectRecord { get; set; }
        public virtual DbSet<Hr_EmpTravelTickectRequest> Hr_EmpTravelTickectRequest { get; set; }
        public virtual DbSet<Hr_EmpTravelTickectRequestWorkFlow> Hr_EmpTravelTickectRequestWorkFlow { get; set; }
        public virtual DbSet<Hr_EmpVactionOrder> Hr_EmpVactionOrder { get; set; }
        public virtual DbSet<Hr_EmpVactionOrder_History> Hr_EmpVactionOrder_History { get; set; }
        public virtual DbSet<Hr_EmpVactionRecord> Hr_EmpVactionRecord { get; set; }
        public virtual DbSet<Hr_EmpVactionRequest> Hr_EmpVactionRequest { get; set; }
        public virtual DbSet<Hr_EmpVactionRequestWorkFlow> Hr_EmpVactionRequestWorkFlow { get; set; }
        public virtual DbSet<Hr_EmpWeekDaysDtls> Hr_EmpWeekDaysDtls { get; set; }
        public virtual DbSet<Hr_ExperienceCategories> Hr_ExperienceCategories { get; set; }
        public virtual DbSet<Hr_Experiences> Hr_Experiences { get; set; }
        public virtual DbSet<Hr_FinalFingerPrint> Hr_FinalFingerPrint { get; set; }
        public virtual DbSet<Hr_FingerPrint> Hr_FingerPrint { get; set; }
        public virtual DbSet<Hr_FPModeStatus> Hr_FPModeStatus { get; set; }
        public virtual DbSet<Hr_GradeHiringItem> Hr_GradeHiringItem { get; set; }
        public virtual DbSet<Hr_GradeHiringItem_Dtls> Hr_GradeHiringItem_Dtls { get; set; }
        public virtual DbSet<Hr_GradeHiringItem_Hdr> Hr_GradeHiringItem_Hdr { get; set; }
        public virtual DbSet<Hr_GradeHiringItemFixed> Hr_GradeHiringItemFixed { get; set; }
        public virtual DbSet<Hr_GradeJobGroups> Hr_GradeJobGroups { get; set; }
        public virtual DbSet<Hr_Grades> Hr_Grades { get; set; }
        public virtual DbSet<Hr_GradeVactionTicket> Hr_GradeVactionTicket { get; set; }
        public virtual DbSet<Hr_Hiring_Items> Hr_Hiring_Items { get; set; }
        public virtual DbSet<Hr_HiringEmpDuesRequestEffect> Hr_HiringEmpDuesRequestEffect { get; set; }
        public virtual DbSet<Hr_HiringEmpReceivableDues_Dtls> Hr_HiringEmpReceivableDues_Dtls { get; set; }
        public virtual DbSet<Hr_HiringEmpReceivableDues_Hdr> Hr_HiringEmpReceivableDues_Hdr { get; set; }
        public virtual DbSet<Hr_HiringEmpSocialInsuranceEffect> Hr_HiringEmpSocialInsuranceEffect { get; set; }
        public virtual DbSet<Hr_HiringMonth_ActuallDues_Dtls> Hr_HiringMonth_ActuallDues_Dtls { get; set; }
        public virtual DbSet<Hr_HiringMonth_ActuallDues_Hdr> Hr_HiringMonth_ActuallDues_Hdr { get; set; }
        public virtual DbSet<Hr_HiringMonth_DelayDues_Dtls> Hr_HiringMonth_DelayDues_Dtls { get; set; }
        public virtual DbSet<Hr_HiringMonth_DelayDues_Hdr> Hr_HiringMonth_DelayDues_Hdr { get; set; }
        public virtual DbSet<Hr_HiringMonth_FollowUp_Dtls> Hr_HiringMonth_FollowUp_Dtls { get; set; }
        public virtual DbSet<Hr_HiringMonth_FollowUp_Hdr> Hr_HiringMonth_FollowUp_Hdr { get; set; }
        public virtual DbSet<Hr_InporgressAndApprovedRequests> Hr_InporgressAndApprovedRequests { get; set; }
        public virtual DbSet<Hr_Jobs> Hr_Jobs { get; set; }
        public virtual DbSet<Hr_MilitaryStatuses> Hr_MilitaryStatuses { get; set; }
        public virtual DbSet<Hr_Nationalities> Hr_Nationalities { get; set; }
        public virtual DbSet<Hr_Notification_Types> Hr_Notification_Types { get; set; }
        public virtual DbSet<Hr_Official_Vacations> Hr_Official_Vacations { get; set; }
        public virtual DbSet<Hr_OverTime_Types> Hr_OverTime_Types { get; set; }
        public virtual DbSet<Hr_Permission_Types> Hr_Permission_Types { get; set; }
        public virtual DbSet<Hr_PermissionReasons> Hr_PermissionReasons { get; set; }
        public virtual DbSet<Hr_PermissionSubReasons> Hr_PermissionSubReasons { get; set; }
        public virtual DbSet<Hr_Projects> Hr_Projects { get; set; }
        public virtual DbSet<Hr_Qualifications> Hr_Qualifications { get; set; }
        public virtual DbSet<Hr_QualificationTypes> Hr_QualificationTypes { get; set; }
        public virtual DbSet<Hr_Religions> Hr_Religions { get; set; }
        public virtual DbSet<Hr_RequestGroup_Types> Hr_RequestGroup_Types { get; set; }
        public virtual DbSet<Hr_RequestStatus> Hr_RequestStatus { get; set; }
        public virtual DbSet<Hr_RequestTypes> Hr_RequestTypes { get; set; }
        public virtual DbSet<Hr_RequestTypesDtls> Hr_RequestTypesDtls { get; set; }
        public virtual DbSet<Hr_RewardReasons> Hr_RewardReasons { get; set; }
        public virtual DbSet<Hr_ShiftGroups> Hr_ShiftGroups { get; set; }
        public virtual DbSet<Hr_Shifts> Hr_Shifts { get; set; }
        public virtual DbSet<Hr_Shifts_Details> Hr_Shifts_Details { get; set; }
        public virtual DbSet<Hr_ShiftWeekDaysDtls> Hr_ShiftWeekDaysDtls { get; set; }
        public virtual DbSet<Hr_Social_InsuranceDeductionPercntg_SA> Hr_Social_InsuranceDeductionPercntg_SA { get; set; }
        public virtual DbSet<Hr_Social_InsuranceTypes> Hr_Social_InsuranceTypes { get; set; }
        public virtual DbSet<Hr_SocialStatuses> Hr_SocialStatuses { get; set; }
        public virtual DbSet<Hr_TicketTypes> Hr_TicketTypes { get; set; }
        public virtual DbSet<Hr_TimeAttendanceSetting> Hr_TimeAttendanceSetting { get; set; }
        public virtual DbSet<Hr_Users> Hr_Users { get; set; }
        public virtual DbSet<Hr_Vaction_Types> Hr_Vaction_Types { get; set; }
        public virtual DbSet<Hr_WeekPolicySystem> Hr_WeekPolicySystem { get; set; }
        public virtual DbSet<Hr_WeekPolicySystemDaysDtls> Hr_WeekPolicySystemDaysDtls { get; set; }
        public virtual DbSet<Hr_WeekSysDays> Hr_WeekSysDays { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TransLog> TransLog { get; set; }
        public virtual DbSet<User_Pages> User_Pages { get; set; }
        public virtual DbSet<WorkFlow_Dtls> WorkFlow_Dtls { get; set; }
        public virtual DbSet<WorkFlow_Hdr> WorkFlow_Hdr { get; set; }
        public virtual DbSet<Menus> Menus { get; set; }
        public virtual DbSet<TxtEmployeeData> TxtEmployeeData { get; set; }
    }
}