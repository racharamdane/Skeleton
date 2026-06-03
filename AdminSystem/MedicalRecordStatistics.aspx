<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MedicalRecordStatistics.aspx.cs" Inherits="MedicalRecordStatistics" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 342px">

            <h1>Statistics Page</h1>

            <h3> Grouped by Sex</h3>
        <asp:GridView ID="GridViewStGroupBySex" runat="server" ></asp:GridView>
         <h3 style="margin-bottom: 22px"> Grouped by Date of Birth</h3>
        <asp:GridView ID="GridViewStGroupByDob" runat="server" ></asp:GridView>

    </div>
            </form>
</body>
</html>
