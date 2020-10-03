<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="TestReport1.WebForm2" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=15.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
  <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
         
         <rsweb:ReportViewer ID="ReportViewer1" runat="server" BackColor="" ClientIDMode="AutoID" Height="595px" HighlightBackgroundColor="" InternalBorderColor="204, 204, 204" InternalBorderStyle="Solid" InternalBorderWidth="1px" LinkActiveColor="" LinkActiveHoverColor="" LinkDisabledColor="" PrimaryButtonBackgroundColor="" PrimaryButtonForegroundColor="" PrimaryButtonHoverBackgroundColor="" PrimaryButtonHoverForegroundColor="" SecondaryButtonBackgroundColor="" SecondaryButtonForegroundColor="" SecondaryButtonHoverBackgroundColor="" SecondaryButtonHoverForegroundColor="" SplitterBackColor="" ToolbarDividerColor="" ToolbarForegroundColor="" ToolbarForegroundDisabledColor="" ToolbarHoverBackgroundColor="" ToolbarHoverForegroundColor="" ToolBarItemBorderColor="" ToolBarItemBorderStyle="Solid" ToolBarItemBorderWidth="1px" ToolBarItemHoverBackColor="" ToolBarItemPressedBorderColor="51, 102, 153" ToolBarItemPressedBorderStyle="Solid" ToolBarItemPressedBorderWidth="1px" ToolBarItemPressedHoverBackColor="153, 187, 226" Width="969px">
                <ServerReport ReportPath="" ReportServerUrl="" />
                  <localreport reportpath="EmployeeCertificatesRpt.rdlc">
                        <datasources>
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSet1" />
                    </datasources>
                </localreport>
        </rsweb:ReportViewer>
         
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetData" TypeName="TestReport1.DataSet1TableAdapters.Hr_EmployeesTableAdapter" DeleteMethod="Delete" InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" UpdateMethod="Update">
                <DeleteParameters>
                    <asp:Parameter Name="Original_Company_Id" Type="String" />
                    <asp:Parameter Name="Original_Branch_Id" Type="String" />
                    <asp:Parameter Name="Original_Emp_Serial_No" Type="Decimal" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="Company_Id" Type="String" />
                    <asp:Parameter Name="Branch_Id" Type="String" />
                    <asp:Parameter Name="Emp_Id" Type="String" />
                    <asp:Parameter Name="Emp_Code" Type="String" />
                    <asp:Parameter Name="Emp_First_Name" Type="String" />
                    <asp:Parameter Name="Emp_Meduim_Name" Type="String" />
                    <asp:Parameter Name="Emp_GrandFatherName" Type="String" />
                    <asp:Parameter Name="Emp_Last_Name" Type="String" />
                    <asp:Parameter Name="Emp_First_NameEn" Type="String" />
                    <asp:Parameter Name="Emp_Meduim_NameEn" Type="String" />
                    <asp:Parameter Name="Emp_GrandFatherNameEn" Type="String" />
                    <asp:Parameter Name="Emp_Last_NameEn" Type="String" />
                    <asp:Parameter Name="Emp_Last_NameConv" Type="String" />
                    <asp:Parameter Name="Birth_Date" Type="String" />
                    <asp:Parameter Name="Birth_Place" Type="String" />
                    <asp:Parameter Name="Hire_Date" Type="String" />
                    <asp:Parameter Name="Social_Status_Id" Type="String" />
                    <asp:Parameter Name="Military_Status_Id" Type="String" />
                    <asp:Parameter Name="Geneder_Id" Type="String" />
                    <asp:Parameter Name="Religion_Id" Type="String" />
                    <asp:Parameter Name="Countery_Id" Type="String" />
                    <asp:Parameter Name="City_Id" Type="String" />
                    <asp:Parameter Name="Nationality_Id" Type="String" />
                    <asp:Parameter Name="Project_Id" Type="String" />
                    <asp:Parameter Name="Contract_Id" Type="String" />
                    <asp:Parameter Name="Admin_Id" Type="String" />
                    <asp:Parameter Name="Dept_Id" Type="String" />
                    <asp:Parameter Name="Job_Id" Type="String" />
                    <asp:Parameter Name="JobTitle" Type="String" />
                    <asp:Parameter Name="Grade_Id" Type="String" />
                    <asp:Parameter Name="Qualify_Type_Id" Type="String" />
                    <asp:Parameter Name="Qualify_Id" Type="String" />
                    <asp:Parameter Name="Shift_Id" Type="String" />
                    <asp:Parameter Name="Identity_Type_Id" Type="String" />
                    <asp:Parameter Name="Identity_No" Type="String" />
                    <asp:Parameter Name="Identity_StartDate" Type="String" />
                    <asp:Parameter Name="Identity_StartDateHijri" Type="String" />
                    <asp:Parameter Name="Identity_EndDate" Type="String" />
                    <asp:Parameter Name="Identity_EndDateHijri" Type="String" />
                    <asp:Parameter Name="Inside_Phone" Type="String" />
                    <asp:Parameter Name="Inside_Mobile1" Type="String" />
                    <asp:Parameter Name="Inside_Mobile2" Type="String" />
                    <asp:Parameter Name="Outside_Phone1" Type="String" />
                    <asp:Parameter Name="Outside_Mobile1" Type="String" />
                    <asp:Parameter Name="Outside_Mobile2" Type="String" />
                    <asp:Parameter Name="Fax" Type="String" />
                    <asp:Parameter Name="InsideAddress1" Type="String" />
                    <asp:Parameter Name="InsideAddress2" Type="String" />
                    <asp:Parameter Name="OutsideAddress1" Type="String" />
                    <asp:Parameter Name="OutsideAddress2" Type="String" />
                    <asp:Parameter Name="BusinessEmail" Type="String" />
                    <asp:Parameter Name="PrivateEmail" Type="String" />
                    <asp:Parameter Name="Manager_Id" Type="String" />
                    <asp:Parameter Name="Bank_No1" Type="String" />
                    <asp:Parameter Name="AccountBankNo1" Type="String" />
                    <asp:Parameter Name="IBAN_No1" Type="String" />
                    <asp:Parameter Name="Bank_No2" Type="String" />
                    <asp:Parameter Name="AccountBankNo2" Type="String" />
                    <asp:Parameter Name="IBAN_No2" Type="String" />
                    <asp:Parameter Name="HasFingerPrint" Type="Byte" />
                    <asp:Parameter Name="HasAbsence" Type="Byte" />
                    <asp:Parameter Name="HasOverTime" Type="Byte" />
                    <asp:Parameter Name="HasDelay" Type="Byte" />
                    <asp:Parameter Name="HasPermission" Type="Byte" />
                    <asp:Parameter Name="HasMedicalInsurance" Type="Byte" />
                    <asp:Parameter Name="Medical_Insurance_No" Type="String" />
                    <asp:Parameter Name="Medical_Insurance_StartDate" Type="String" />
                    <asp:Parameter Name="Medical_Insurance_StartDateHijri" Type="String" />
                    <asp:Parameter Name="Medical_Insurance_EndDate" Type="String" />
                    <asp:Parameter Name="Medical_Insurance_EndDateHijri" Type="String" />
                    <asp:Parameter Name="Social_Insurance_No" Type="String" />
                    <asp:Parameter Name="Notes" Type="String" />
                    <asp:Parameter Name="InsUser" Type="String" />
                    <asp:Parameter Name="InsDate" Type="DateTime" />
                    <asp:Parameter Name="UpdateUser" Type="String" />
                    <asp:Parameter Name="UpdateDate" Type="DateTime" />
                    <asp:Parameter Name="DeleteUser" Type="String" />
                    <asp:Parameter Name="DeleteDate" Type="DateTime" />
                    <asp:Parameter Name="Rec_Status" Type="Byte" />
                    <asp:Parameter Name="Prefix" Type="String" />
                    <asp:Parameter Name="FullNameArabic" Type="String" />
                    <asp:Parameter Name="FullNameEn" Type="String" />
                    <asp:Parameter Name="ImagePath" Type="String" />
                    <asp:Parameter Name="PassportNo" Type="String" />
                    <asp:Parameter Name="PassportIssueDate" Type="String" />
                    <asp:Parameter Name="PassportExpiryDate" Type="String" />
                    <asp:Parameter Name="IsCommissioner" Type="Byte" />
                    <asp:Parameter Name="Commissioner_Serial_no" Type="Decimal" />
                    <asp:Parameter Name="NeedMandate" Type="Byte" />
                    <asp:Parameter DbType="Guid" Name="EmpHdrId" />
                    <asp:Parameter Name="GradeJob_Id" Type="String" />
                    <asp:Parameter Name="EmpStatusId" Type="String" />
                    <asp:Parameter Name="HasManager" Type="Byte" />
                    <asp:Parameter Name="ContractClassify" Type="String" />
                    <asp:Parameter Name="StartContract" Type="String" />
                    <asp:Parameter Name="EndContract" Type="String" />
                    <asp:Parameter Name="ContractPeriodByMonth" Type="Decimal" />
                    <asp:Parameter Name="IsEmpManager" Type="Byte" />
                    <asp:Parameter Name="WorkStartingDate" Type="String" />
                    <asp:Parameter Name="WorkStartingDateAfterRenwal" Type="String" />
                    <asp:Parameter Name="DeductInsurance" Type="Byte" />
                    <asp:Parameter Name="EnrollFPNumber" Type="String" />
                    <asp:Parameter Name="Attendance_Type" Type="String" />
                    <asp:Parameter Name="DeliverSalType" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="Emp_Id" Type="String" />
                    <asp:Parameter Name="Emp_Code" Type="String" />
                    <asp:Parameter Name="Emp_First_Name" Type="String" />
                    <asp:Parameter Name="Emp_Meduim_Name" Type="String" />
                    <asp:Parameter Name="Emp_GrandFatherName" Type="String" />
                    <asp:Parameter Name="Emp_Last_Name" Type="String" />
                    <asp:Parameter Name="Emp_First_NameEn" Type="String" />
                    <asp:Parameter Name="Emp_Meduim_NameEn" Type="String" />
                    <asp:Parameter Name="Emp_GrandFatherNameEn" Type="String" />
                    <asp:Parameter Name="Emp_Last_NameEn" Type="String" />
                    <asp:Parameter Name="Emp_Last_NameConv" Type="String" />
                    <asp:Parameter Name="Birth_Date" Type="String" />
                    <asp:Parameter Name="Birth_Place" Type="String" />
                    <asp:Parameter Name="Hire_Date" Type="String" />
                    <asp:Parameter Name="Social_Status_Id" Type="String" />
                    <asp:Parameter Name="Military_Status_Id" Type="String" />
                    <asp:Parameter Name="Geneder_Id" Type="String" />
                    <asp:Parameter Name="Religion_Id" Type="String" />
                    <asp:Parameter Name="Countery_Id" Type="String" />
                    <asp:Parameter Name="City_Id" Type="String" />
                    <asp:Parameter Name="Nationality_Id" Type="String" />
                    <asp:Parameter Name="Project_Id" Type="String" />
                    <asp:Parameter Name="Contract_Id" Type="String" />
                    <asp:Parameter Name="Admin_Id" Type="String" />
                    <asp:Parameter Name="Dept_Id" Type="String" />
                    <asp:Parameter Name="Job_Id" Type="String" />
                    <asp:Parameter Name="JobTitle" Type="String" />
                    <asp:Parameter Name="Grade_Id" Type="String" />
                    <asp:Parameter Name="Qualify_Type_Id" Type="String" />
                    <asp:Parameter Name="Qualify_Id" Type="String" />
                    <asp:Parameter Name="Shift_Id" Type="String" />
                    <asp:Parameter Name="Identity_Type_Id" Type="String" />
                    <asp:Parameter Name="Identity_No" Type="String" />
                    <asp:Parameter Name="Identity_StartDate" Type="String" />
                    <asp:Parameter Name="Identity_StartDateHijri" Type="String" />
                    <asp:Parameter Name="Identity_EndDate" Type="String" />
                    <asp:Parameter Name="Identity_EndDateHijri" Type="String" />
                    <asp:Parameter Name="Inside_Phone" Type="String" />
                    <asp:Parameter Name="Inside_Mobile1" Type="String" />
                    <asp:Parameter Name="Inside_Mobile2" Type="String" />
                    <asp:Parameter Name="Outside_Phone1" Type="String" />
                    <asp:Parameter Name="Outside_Mobile1" Type="String" />
                    <asp:Parameter Name="Outside_Mobile2" Type="String" />
                    <asp:Parameter Name="Fax" Type="String" />
                    <asp:Parameter Name="InsideAddress1" Type="String" />
                    <asp:Parameter Name="InsideAddress2" Type="String" />
                    <asp:Parameter Name="OutsideAddress1" Type="String" />
                    <asp:Parameter Name="OutsideAddress2" Type="String" />
                    <asp:Parameter Name="BusinessEmail" Type="String" />
                    <asp:Parameter Name="PrivateEmail" Type="String" />
                    <asp:Parameter Name="Manager_Id" Type="String" />
                    <asp:Parameter Name="Bank_No1" Type="String" />
                    <asp:Parameter Name="AccountBankNo1" Type="String" />
                    <asp:Parameter Name="IBAN_No1" Type="String" />
                    <asp:Parameter Name="Bank_No2" Type="String" />
                    <asp:Parameter Name="AccountBankNo2" Type="String" />
                    <asp:Parameter Name="IBAN_No2" Type="String" />
                    <asp:Parameter Name="HasFingerPrint" Type="Byte" />
                    <asp:Parameter Name="HasAbsence" Type="Byte" />
                    <asp:Parameter Name="HasOverTime" Type="Byte" />
                    <asp:Parameter Name="HasDelay" Type="Byte" />
                    <asp:Parameter Name="HasPermission" Type="Byte" />
                    <asp:Parameter Name="HasMedicalInsurance" Type="Byte" />
                    <asp:Parameter Name="Medical_Insurance_No" Type="String" />
                    <asp:Parameter Name="Medical_Insurance_StartDate" Type="String" />
                    <asp:Parameter Name="Medical_Insurance_StartDateHijri" Type="String" />
                    <asp:Parameter Name="Medical_Insurance_EndDate" Type="String" />
                    <asp:Parameter Name="Medical_Insurance_EndDateHijri" Type="String" />
                    <asp:Parameter Name="Social_Insurance_No" Type="String" />
                    <asp:Parameter Name="Notes" Type="String" />
                    <asp:Parameter Name="InsUser" Type="String" />
                    <asp:Parameter Name="InsDate" Type="DateTime" />
                    <asp:Parameter Name="UpdateUser" Type="String" />
                    <asp:Parameter Name="UpdateDate" Type="DateTime" />
                    <asp:Parameter Name="DeleteUser" Type="String" />
                    <asp:Parameter Name="DeleteDate" Type="DateTime" />
                    <asp:Parameter Name="Rec_Status" Type="Byte" />
                    <asp:Parameter Name="Prefix" Type="String" />
                    <asp:Parameter Name="FullNameArabic" Type="String" />
                    <asp:Parameter Name="FullNameEn" Type="String" />
                    <asp:Parameter Name="ImagePath" Type="String" />
                    <asp:Parameter Name="PassportNo" Type="String" />
                    <asp:Parameter Name="PassportIssueDate" Type="String" />
                    <asp:Parameter Name="PassportExpiryDate" Type="String" />
                    <asp:Parameter Name="IsCommissioner" Type="Byte" />
                    <asp:Parameter Name="Commissioner_Serial_no" Type="Decimal" />
                    <asp:Parameter Name="NeedMandate" Type="Byte" />
                    <asp:Parameter DbType="Guid" Name="EmpHdrId" />
                    <asp:Parameter Name="GradeJob_Id" Type="String" />
                    <asp:Parameter Name="EmpStatusId" Type="String" />
                    <asp:Parameter Name="HasManager" Type="Byte" />
                    <asp:Parameter Name="ContractClassify" Type="String" />
                    <asp:Parameter Name="StartContract" Type="String" />
                    <asp:Parameter Name="EndContract" Type="String" />
                    <asp:Parameter Name="ContractPeriodByMonth" Type="Decimal" />
                    <asp:Parameter Name="IsEmpManager" Type="Byte" />
                    <asp:Parameter Name="WorkStartingDate" Type="String" />
                    <asp:Parameter Name="WorkStartingDateAfterRenwal" Type="String" />
                    <asp:Parameter Name="DeductInsurance" Type="Byte" />
                    <asp:Parameter Name="EnrollFPNumber" Type="String" />
                    <asp:Parameter Name="Attendance_Type" Type="String" />
                    <asp:Parameter Name="DeliverSalType" Type="String" />
                    <asp:Parameter Name="Original_Company_Id" Type="String" />
                    <asp:Parameter Name="Original_Branch_Id" Type="String" />
                    <asp:Parameter Name="Original_Emp_Serial_No" Type="Decimal" />
                </UpdateParameters>
            </asp:ObjectDataSource>

    </form>

</body>
</html>
