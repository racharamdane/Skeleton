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
<p>
         <asp:ListBox ID="lstAppointmentList" runat="server" style="z-index: 1; left: 10px; top: 42px; position: absolute; height: 462px; width: 573px"></asp:ListBox>
<asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 20px; top: 543px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 104px; top: 546px; position: absolute" Text="Edit"/>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 42px; top: 725px; position: absolute"></asp:Label>
    </p>
           <p>
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 193px; top: 543px; position: absolute" Text="Delete" />
            </p>
            <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 22px; top: 654px; position: absolute" Text="Apply Filter" />
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; top: 657px; position: absolute; left: 234px" Text="Clear Filter" />
        <asp:Label ID="lblEnterAppointmentId" runat="server" style="z-index: 1; left: 29px; top: 577px; position: absolute" Text="Enter a Full Name"></asp:Label>
 <p>
            <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; top: 577px; position: absolute; left: 244px"></asp:TextBox>
 </p>
    </form>
</body>
</html>

