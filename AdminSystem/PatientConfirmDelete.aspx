<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PatientConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 76px; top: 363px; position: absolute" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 269px; top: 364px; position: absolute" Text="No" />
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 25px; top: 212px; position: absolute" Text="Are you sure you want to delete this record"></asp:Label>
        </p>
    </form>
</body>
</html>
