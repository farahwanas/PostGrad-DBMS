<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="GUCera.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student Registration</title>
</head>
<body style="background-image:url('background.jpg')">
    <form id="form1" runat="server" style="text-align:center">
        <div>
            <asp:Label ID="Label4" runat="server" Text="Registration Form" style="font-size:large; font:bold"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="First Name"></asp:Label><br />
            <asp:TextBox ID="fname" runat="server" Width="225px"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Last Name" ></asp:Label><br />
            <asp:TextBox ID="lname" runat="server" Width="225px"></asp:TextBox>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Password" Width="225px"></asp:Label>
            <br />
            <asp:TextBox ID="password" type="password" runat="server" Width="225px"></asp:TextBox>
            <br />
             Faculty:<br />
            <asp:TextBox ID="faculty" runat="server" Width="225px"></asp:TextBox>
            <br />
             Email:<br />
            <asp:TextBox ID="email" runat="server" Width="225px"></asp:TextBox>
            <br />
             Address:<br />
            <asp:TextBox ID="address" runat="server"  Height="47px" Width="225px"></asp:TextBox>
            <br />
             User Type:<br />
           
    
           <asp:DropDownList ID="DropDownList1" runat="server" >  
            
            <asp:ListItem Value="1">Gucian </asp:ListItem>  
                <asp:ListItem Value="2">NonGucian </asp:ListItem> 
        </asp:DropDownList> 
            <br />
            <br />       
            <asp:Button ID="reg" runat="server" Text="Register" OnClick="register" />
           
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
