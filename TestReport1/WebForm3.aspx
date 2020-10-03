<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="TestReport1.WebForm3" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=15.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="Scripts/jquery-3.4.1.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <button id="btnShowReport" onclick="viewReport();" data-toggle="modal" class="btn btn-md  purple">Show Report</button>
    </form>
    <script src="WebForm3.js"></script>

</body>
</html>
