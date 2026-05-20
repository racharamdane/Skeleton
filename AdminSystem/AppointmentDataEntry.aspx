<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AppointmentDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <style type="text/css">
     #form1 {
         height: 521px;
     }
 </style>
</head>
<body  style="height: 394px">
    <form id="form1" runat="server">
        <div>
    <asp:TextBox ID="txtAppointmentId" runat="server" style="z-index: 1; left: 222px; top: 25px; position: absolute" height="29px" width="240px"></asp:TextBox>
        <asp:Label ID="lblAppointmentId" runat="server" style="z-index: 1; left: 17px; top: 32px; position: absolute" Text="AppointmentID" width="136px"></asp:Label>
</div>
<p>
        <asp:Label ID="DoctorID" runat="server" style="z-index: 1; left: 17px; top: 73px; position: absolute" Text="DoctorID" width="136px"></asp:Label>
<asp:TextBox ID="Patient" runat="server" style="z-index: 1; left: 223px; top: 101px; position: absolute" height="29px" width="240px"></asp:TextBox>
        <asp:TextBox ID="DocID" runat="server" style="z-index: 1; left: 222px; top: 61px; position: absolute" height="29px" width="240px"></asp:TextBox>
    </p>
<p>
      <asp:Label ID="PatientId" runat="server" style="z-index: 1; left: 17px; top: 115px; position: absolute" Text="PatientID" width="136px"></asp:Label>
    <asp:TextBox ID="txtAppointmentNotes1" runat="server" style="z-index: 1; left: 222px; top: 143px; position: absolute; width: 256px;" height="29px"></asp:TextBox>
</p>
       <p>
    <asp:Label ID="lblAppointmentNotes" runat="server" style="z-index: 1; left: 16px; top: 228px; position: absolute; width: 212px; right: 1075px;" Text="Appointment Notes"></asp:Label>
</p>
        <p>
<asp:Label ID="lblAppointmentDate" runat="server" style="z-index: 1; left: 17px; top: 151px; position: absolute" Text="Appointment Date"></asp:Label>
<asp:TextBox ID="txtAppointmentDate" runat="server" style="z-index: 1; left: 222px; top: 183px; position: absolute; margin-top: 0px;" height="29px" width="240px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="AppointmentTime" runat="server" style="z-index: 1; left: 18px; top: 189px; position: absolute" Text="Appointment Time"></asp:Label>
            <asp:TextBox ID="Appointment" runat="server" style="z-index: 1; left: 221px; top: 222px; position: absolute" height="29px" width="240px"></asp:TextBox>
        </p>
        
<p>
    &nbsp;</p>
<asp:CheckBox ID="chkAvailability" runat="server" style="z-index: 1; left: 25px; top: 270px; position: absolute" Text="Availability" />
<asp:Label ID="lblError" runat="server" style="z-index: 1; left: 16px; top: 307px; position: absolute" height="35px" width="90px"></asp:Label>
<p>
    &nbsp;</p>
<asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 325px; top: 307px; position: absolute; height: 26px;" Text="Cancel" width="75px" />
<%--<asp:Button ID="btnOK" runat="server" height="25px" OnClick="btnOK_Click1" style="z-index: 1; left: 225px; top: 306px; position: absolute" Text="OK" width="75px" /> --%>
<%-- <asp:Button ID="btnFind" runat="server" height="25px" OnClick="btnFind_Click" style="z-index: 1; left: 513px; top: 32px; position: absolute" Text="Find" width="75px" /> --%>
</form>
</body>
</html>
