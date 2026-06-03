<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MedicalList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstRecordList" runat="server" Height="218px" Width="417px"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" Width="31px" />
            <asp:Button ID="btnEdit" runat="server" style="margin-left: 71px" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="margin-left: 75px" Text="Delete" />
        </p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Enter PatientId"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 99px"></asp:TextBox>
        <p>
            <asp:Button ID="btnApplyFilter" runat="server" Text="Apply Filter" Width="84px" />
            <asp:Button ID="btnClearFilter" runat="server" style="margin-left: 98px" Text="Clear Filter" />
            <asp:Button ID="btnStatisticsPage" runat="server" OnClick="btnStatisticsPage_Click" style="margin-left: 107px" Text="Statistics Page" />
        </p>
    </form>
</body>
</html>
