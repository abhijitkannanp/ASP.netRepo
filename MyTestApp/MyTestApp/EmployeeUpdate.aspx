<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeUpdate.aspx.cs" Inherits="MyTestApp.EmployeeUpdate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">Name:</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server" Width="465px"></asp:TextBox>
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="height: 29px" Text="Find" />
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
                        <asp:Button ID="Button1" runat="server"  Text="Save" OnClick="Button1_Click" />
                        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="GO to Employee List " />
                    </td>
                   
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
