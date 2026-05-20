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
        <asp:ListBox ID="lstPatientList" runat="server" style="z-index: 1; left: 10px; top: 42px; position: absolute; height: 462px; width: 573px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 20px; top: 535px; position: absolute" Text="Add" />
    </form>
</body>
</html>
