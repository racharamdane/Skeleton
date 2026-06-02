<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DoctorStatistics.aspx.cs" Inherits="DoctorManagementStatistics" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div> <h1> STATISTICS PAGE </h1></div>
            
            <div>
                <h3> Grouped by Department </h3>
                <asp:GridView ID="GridViewGroupByDepartment" runat="server"></asp:GridView>
           </div>

            <div>
                <h3>  Grouped by Contract Date </h3>
                <asp:GridView ID="GridViewGroupByContractDate" runat="server"></asp:GridView>
            </div>

        </div>
        <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" style="z-index: 1; left: 4px; top: 445px; position: absolute" Text="Back to Previous Page" />
    </form>
</body>
</html>
