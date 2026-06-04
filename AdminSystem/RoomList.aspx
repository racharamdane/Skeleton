
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RoomList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" id="lstRoomList">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox runat="server" id="lstRoomList" Width="500px" Height="250px"></asp:ListBox>
            <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 10px; top: 275px; position: absolute; width: 50px" Text="Add"/>
            <asp:Button ID="btn" runat="server" Style="z-index: 1; left: 75px; top: 275px; position: absolute; width: 50px" Text="Edit" OnClick="btn_Click" />
        </div>
    </form>
</body>
</html>
