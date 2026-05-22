<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AppointmentList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
         <asp:ListBox ID="lstAppointmentList" runat="server" style="z-index: 1; left: 10px; top: 42px; position: absolute; height: 462px; width: 573px"></asp:ListBox>
 <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 20px; top: 535px; position: absolute" Text="Add" />
 <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 109px; top: 534px; position: absolute" Text="Edit" />
 <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 52px; top: 586px; position: absolute"></asp:Label>
 <p>
     <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 208px; top: 534px; position: absolute" Text="Delete" />
 </p>
    </form>
</body>
</html>
