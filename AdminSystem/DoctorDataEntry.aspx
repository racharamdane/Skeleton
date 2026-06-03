<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DoctorDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
<script scr="Scripts/bootstrap.bundle.min.js"></script>  
<script scr="Scripts/bootstrap.min.js"></script>
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icon@1.11.3/font/bootstrap-icons.min.css" />
    <style type="text/css">
        #form1 {
            height: 521px;
        }
    </style>
</head>
<body style="height: 394px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblDoctorId" runat="server" style="z-index: 1; left: 11px; top: 31px; position: absolute" Text="Doctor ID" width="136px"></asp:Label>
            <asp:TextBox ID="txtDoctorId" runat="server" style="z-index: 1; left: 174px; top: 28px; position: absolute" height="29px" width="240px"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="lblFullName" runat="server" style="z-index: 1; left: 11px; top: 83px; position: absolute; width: 136px; bottom: 565px" Text="Full Name"></asp:Label>
            <asp:TextBox ID="txtFullName" runat="server" height="29px" style="z-index: 1; left: 174px; top: 84px; position: absolute; width: 240px; bottom: 562px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 11px; top: 133px; position: absolute" Text="Password" width="136px"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" height="29px" style="z-index: 1; left: 174px; top: 132px; position: absolute" width="240px"></asp:TextBox>
        </p>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 11px; top: 184px; position: absolute; width: 136px" Text="Email"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 174px; top: 180px; position: absolute" height="29px" width="240px"></asp:TextBox>
        <p>
            <asp:Label ID="lblDepartment" runat="server" style="z-index: 1; left: 11px; top: 228px; position: absolute" Text="Department" width="136px"></asp:Label>
            <asp:TextBox ID="txtDepartment" runat="server" style="z-index: 1; left: 174px; top: 226px; position: absolute" height="29px" width="240px"></asp:TextBox>
        </p>
        <asp:Label ID="lblContractDate" runat="server" style="z-index: 1; left: 11px; top: 279px; position: absolute" Text="Contract Date"></asp:Label>
        <asp:TextBox ID="txtContractDate" runat="server" style="z-index: 1; left: 174px; top: 279px; position: absolute" height="29px" width="240px"></asp:TextBox>
        <p>
            <asp:Button ID="btnReturn" runat="server" OnClick="btnReturn_Click" style="z-index: 1; left: 415px; top: 405px; position: absolute" Text="Return to Main Menu" />
        </p>
        <asp:CheckBox ID="chkAvailability" runat="server" style="z-index: 1; left: 88px; top: 346px; position: absolute" Text="Availability" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 13px; top: 405px; position: absolute" height="35px" width="90px"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnCancel" runat="server" height="25px" style="z-index: 1; left: 291px; top: 405px; position: absolute" Text="Cancel" width="75px" OnClick="btnCancel_Click" />
        <asp:Button ID="btnOK" runat="server" height="25px" OnClick="btnOK_Click1" style="z-index: 1; left: 171px; top: 405px; position: absolute" Text="OK" width="75px" />
        <asp:Button ID="btnFind" runat="server" height="25px" OnClick="btnFind_Click" style="z-index: 1; left: 468px; top: 34px; position: absolute" Text="Find" width="75px" />
    </form>
</body>
</html>
