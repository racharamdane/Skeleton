<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MedicalDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblPatientId" runat="server" Text="Patient Id"></asp:Label>
            <asp:TextBox ID="txtPatientId" runat="server" style="margin-left: 33px" Width="156px"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="lblDob" runat="server" Text="DOB"></asp:Label>
            <asp:TextBox ID="txtDob" runat="server" style="margin-left: 59px" Width="157px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblSex" runat="server" Text="Sex"></asp:Label>
            <asp:CheckBox ID="chkSex" runat="server" Text="Male" />
            <asp:CheckBox ID="chkSexF" runat="server" Text="Female" />
        </p>
        <p>
            <asp:Label ID="lblMedications" runat="server" Text="Medications"></asp:Label>
            <asp:TextBox ID="txtMedications" runat="server" style="margin-left: 18px" Width="154px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblDiagnoses" runat="server" Text="Diagnoses"></asp:Label>
            <asp:TextBox ID="txtDiagnoses" runat="server" style="margin-left: 33px" Width="152px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblClinicalNotes" runat="server" Text="Clinical Notes"></asp:Label>
            <asp:TextBox ID="txtClinicalNotes" runat="server" style="margin-left: 11px" Width="154px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="OK" Width="55px" />
        <asp:Button ID="btnCancel" runat="server" style="margin-left: 144px" Text="Cancel" />
    </form>
</body>
</html>
