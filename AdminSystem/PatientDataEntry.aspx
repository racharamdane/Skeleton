<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PatientDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    &nbsp;<form id="form1" runat="server">
        <div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
        <asp:Label ID="lblPatientID" runat="server" style="z-index: 1; left: 10px; top: 42px; position: absolute" Text="Patient ID" width="192px"></asp:Label>
        <p>
            <asp:TextBox ID="txtPatientID" runat="server" style="z-index: 1; left: 286px; top: 48px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="lblPatientfullname" runat="server" style="z-index: 1; left: 10px; top: 107px; position: absolute" Text="Patient full name" width="192px"></asp:Label>
        <asp:TextBox ID="txtPatientfullname" runat="server" style="z-index: 1; left: 286px; top: 104px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPatientregistrationdate" runat="server" style="z-index: 1; left: 286px; top: 160px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblPatientgender" runat="server" style="z-index: 1; left: 10px; top: 225px; position: absolute" Text="Patient gender" width="192px"></asp:Label>
        <asp:TextBox ID="txtPatientgender" runat="server" style="z-index: 1; left: 286px; top: 218px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblPatientemail" runat="server" style="z-index: 1; left: 10px; top: 274px; position: absolute" Text="Patient email" width="192px"></asp:Label>
        <asp:TextBox ID="txtPatientemail" runat="server" style="z-index: 1; left: 286px; top: 275px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblPatientpassword" runat="server" style="z-index: 1; left: 10px; top: 329px; position: absolute" Text="Patient Password" width="192px"></asp:Label>
        <asp:TextBox ID="txtPatientpassword" runat="server" style="z-index: 1; left: 286px; top: 331px; position: absolute"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkPatienttreatment" runat="server" style="z-index: 1; left: 287px; top: 405px; position: absolute" Text="Patient treatment" />
            <asp:Button ID="btnFind" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 526px; top: 54px; position: absolute" Text="Find" />
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 53px; top: 468px; position: absolute"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 46px; top: 529px; position: absolute" Text="OK" />
        </p>
        <p>
            <asp:Label ID="lblPatientregistrationdate" runat="server" style="z-index: 1; left: 10px; top: 167px; position: absolute" Text="Patient registration date"></asp:Label>
        </p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 144px; top: 533px; position: absolute" Text="Cancel" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
