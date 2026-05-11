<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RoomDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 420px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblRoomID" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; width: 106px;" Text="Room ID"></asp:Label>
        <asp:TextBox ID="txtRoomID" runat="server" style="z-index: 1; left: 148px; top: 30px; position: absolute; width: 60px"></asp:TextBox>
        <p>
            <asp:Label ID="lblRoomName" runat="server" style="z-index: 1; left: 8px; top: 68px; position: absolute" Text="Room name" width="106px"></asp:Label>
            <asp:TextBox ID="txtRoomName" runat="server" style="z-index: 1; left: 148px; top: 61px; position: absolute; width: 60px"></asp:TextBox>
            <asp:Label ID="lblPatientID" runat="server" style="z-index: 1; left: 12px; top: 94px; position: absolute" Text="PatientID" width="106px"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtPatientID" runat="server" style="z-index: 1; left: 148px; top: 85px; position: absolute; width: 60px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblRoomEntryDate" runat="server" style="z-index: 1; left: 8px; top: 124px; position: absolute; margin-bottom: 20px" Text="Room Entry Date"></asp:Label>
            <asp:TextBox ID="txtRoomEntryDate" runat="server" style="z-index: 1; left: 148px; top: 124px; position: absolute; width: 60px"></asp:TextBox>
        </p>
        <asp:Label ID="lblClinicalNotes" runat="server" style="z-index: 1; left: 10px; top: 167px; position: absolute" Text="Clinical notes" width="106px"></asp:Label>
        <asp:TextBox ID="txtClinicalNotes" runat="server" style="z-index: 1; left: 148px; top: 164px; position: absolute; width: 60px"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkTreatmentOver" runat="server" Text="Treatment over" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
