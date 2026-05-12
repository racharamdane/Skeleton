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
        <asp:Label ID="lblRoomID" runat="server" style="z-index: 1; left: 10px; top: 30px; position: absolute; width: 106px;" Text="Room ID"></asp:Label>
        <asp:TextBox ID="txtRoomID" runat="server" style="z-index: 1; left: 150px; top: 30px; position: absolute; width: 150px"></asp:TextBox>
        <p>
            <asp:Label ID="lblRoomName" runat="server" style="z-index: 1; left: 10px; top: 70px; position: absolute" Text="Room name" width="106px"></asp:Label>
            <asp:TextBox ID="txtRoomName" runat="server" style="z-index: 1; left: 150px; top: 70px; position: absolute; width: 150px"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" style="z-index: 1; left: 350px; top: 30px; position: absolute; width: 50px" Text="Find" OnClick="btnFind_Click" />
        </p>
        <p>
            <asp:Label ID="lblPatientID" runat="server" style="z-index: 1; left: 10px; top: 110px; position: absolute" Text="PatientID" width="106px"></asp:Label>
            <asp:TextBox ID="txtPatientID" runat="server" style="z-index: 1; left: 150px; top: 110px; position: absolute; width: 150px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblRoomEntryDate" runat="server" style="z-index: 1; left: 10px; top: 150px; position: absolute; margin-bottom: 20px" Text="Room Entry Date"></asp:Label>
            <asp:TextBox ID="txtRoomEntryDate" runat="server" style="z-index: 1; left: 150px; top: 150px; position: absolute; width: 150px"></asp:TextBox>
        </p>
        <asp:Label ID="lblClinicalNotes" runat="server" style="z-index: 1; left: 10px; top: 190px; position: absolute" Text="Clinical notes" width="106px"></asp:Label>
        <asp:TextBox ID="txtClinicalNotes" runat="server" style="z-index: 1; left: 150px; top: 190px; position: absolute; width: 150px"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkTreatmentOver" runat="server" style="z-index: 1; left: 10px; top: 230px; position: absolute; width: 300px" Text="Treatment over" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 270px; position: absolute; width: 60px" Text="[lblError]"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 10px; top: 310px; position: absolute; width: 40px" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 75px; top: 310px; position: absolute; width: 70px"  Text="Cancel" />
    </form>
</body>
</html>
