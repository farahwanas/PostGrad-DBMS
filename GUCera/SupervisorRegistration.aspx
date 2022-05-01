<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SupervisorRegistration.aspx.cs" Inherits="GUCera.SupervisorRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image:url('background.jpg')">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label4" runat="server" Text="Registration Form"></asp:Label>
            <br />
            <asp:Label ID="Label3" runat="server" Text="First Name"></asp:Label><br />
            <asp:TextBox ID="fname" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Last Name"></asp:Label><br />
            <asp:TextBox ID="lname" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Password"></asp:Label>
            <br />
            <asp:TextBox ID="password" type="password" runat="server"></asp:TextBox>
            <br />
             Faculty:<br />
            <asp:TextBox ID="faculty" runat="server" ></asp:TextBox>
            <br />
             Email:<br />
            <asp:TextBox ID="email" runat="server" Width="225px"></asp:TextBox>
            <br />
            <asp:Button ID="reg" runat="server" Text="Register" OnClick="register" />
           
        </div>
    </form>
</body>
</html>
