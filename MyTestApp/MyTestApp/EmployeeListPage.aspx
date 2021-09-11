<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeListPage.aspx.cs" Inherits="MyTestApp.MyEmployeePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <div>    
   <table>  
    <tr>  
    <td>   
       Search  
        </td>  
        <td>  
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>  
        </td>  
        <td>   
        <asp:Button ID="Button1" runat="server" Text="Go" onclick="Button1_Click" />  
        </td>  
        </tr>  
</table>  
<table><tr><td><p><asp:Label ID="Label2" runat="server" Text="label"></asp:Label>  </p></td></tr></table>  
<asp:GridView ID="GridView1" runat="server" >  
    </asp:GridView>   
           <br />
           <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Add New Employee" />
           <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Update Employee" />
    </div>  
    </form>
</body>
</html>
