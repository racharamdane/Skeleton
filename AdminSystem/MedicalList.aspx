<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MedicalList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstRecordList" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 311px; width: 367px"></asp:ListBox>
        </div>
    </form>
</body>
</html>
