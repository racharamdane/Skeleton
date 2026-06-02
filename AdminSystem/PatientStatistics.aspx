<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PatientStatistics.aspx.cs" Inherits="PatientStatistics" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 684px">
    <form id="form1" runat="server">
        <div>
            Statistics Page</div>
        <p>
            &nbsp;</p>
        <p id="tblGroupedByGender" style="height: 359px">
            <asp:TextBox ID="txtGroupedByPatientender" runat="server" style="z-index: 1; left: 11px; top: 98px; position: absolute; width: 242px">Patient List - Grouped By Patient Gender</asp:TextBox>
            <asp:GridView ID="GridViewStGroupByPatientgender" runat="server"  style="z-index: 1; left: 17px; top: 142px; position: absolute; height: 133px; width: 187px">
            </asp:GridView>
            <asp:TextBox ID="txtGroupedByPatientregistrationdate" runat="server" style="z-index: 1; left: 12px; top: 305px; position: absolute; width: 316px">Patient List - Grouped By Patient Registration Date</asp:TextBox>
        </p>
        <asp:GridView ID="GridViewStGroupByPatientregistrationdate" runat="server" style="z-index: 1; left: 20px; top: 358px; position: absolute; height: 133px; width: 187px">
        </asp:GridView>
    </form>
</body>
</html>
