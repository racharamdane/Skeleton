<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PatientList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstPatientList" runat="server" style="z-index: 1; left: 10px; top: 42px; position: absolute; height: 343px; width: 573px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 20px; top: 443px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 104px; top: 446px; position: absolute" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 42px; top: 725px; position: absolute"></asp:Label>
        <p>
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 193px; top: 443px; position: absolute" Text="Delete" />
        </p>
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 22px; top: 654px; position: absolute" Text="Apply Filter" />
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; top: 657px; position: absolute; left: 234px" Text="Clear Filter" />
        <asp:Label ID="lblEnterPatientfullname" runat="server" style="z-index: 1; left: 29px; top: 577px; position: absolute" Text="Enter a Full Name"></asp:Label>
        <p>
            <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; top: 577px; position: absolute; left: 244px"></asp:TextBox>
        </p>
        <asp:Button ID="btnStatisticsPage" runat="server" style="z-index: 1; left: 423px; top: 658px; position: absolute" Text="Statistics Page" OnClick="btnStatisticsPage_Click" />
        <asp:Button ID="btnReturn" runat="server" OnClick="btnReturn_Click" style="z-index: 1; left: 631px; top: 657px; position: absolute" Text="Return to Main Menu" />
    </form>
</body>
</html>
