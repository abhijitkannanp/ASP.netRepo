<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeAdd.aspx.cs" Inherits="MyTestApp.EmployeeAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 304px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">Name:</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server" Width="465px"></asp:TextBox>
                    </td>
                    
                </tr>
                <tr>
                    <td class="auto-style1">Address:</td>
                    <td>
                        <asp:TextBox ID="txtAddress" runat="server" Height="105px" TextMode="MultiLine" Width="472px"></asp:TextBox>
                    </td>
                   
                </tr>
                <tr>
                    <td class="auto-style1">Email:</td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server" Height="18px" Width="465px"></asp:TextBox>
                    </td>
                   
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" />
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Go to Employee Listing" />
                    </td>
                   
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
