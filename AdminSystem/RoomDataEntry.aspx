<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RoomDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 235px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblRoomID" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="Room ID"></asp:Label>
        <asp:TextBox ID="txtRoomID" runat="server" style="z-index: 1; left: 78px; top: 34px; position: absolute; width: 60px"></asp:TextBox>
        <p>
            <asp:Label ID="lblRoomName" runat="server" style="z-index: 1; left: 10px; top: 53px; position: absolute" Text="Room name"></asp:Label>
            <asp:TextBox ID="txtRoomName" runat="server" style="z-index: 1; left: 91px; top: 53px; position: absolute; width: 96px"></asp:TextBox>
            <asp:Label ID="lblPatientID" runat="server" style="z-index: 1; left: 12px; top: 84px; position: absolute" Text="PatientID"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtPatientID" runat="server" style="z-index: 1; left: 81px; top: 85px; position: absolute; width: 53px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblRoomEntryDate" runat="server" style="z-index: 1; left: 8px; top: 124px; position: absolute; margin-bottom: 20px" Text="Room Entry Date"></asp:Label>
            <asp:TextBox ID="txtRoomEntryDate" runat="server" style="z-index: 1; left: 129px; top: 124px; position: absolute; width: 80px"></asp:TextBox>
        </p>
        <asp:Label ID="lblClinicalNotes" runat="server" style="z-index: 1; left: 10px; top: 167px; position: absolute" Text="Clinical notes"></asp:Label>
        <asp:TextBox ID="txtClinicalNotes" runat="server" style="z-index: 1; left: 100px; top: 167px; position: absolute; width: 122px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 10px; top: 224px; position: absolute" Text="Label"></asp:Label>
    </form>
</body>
</html>
