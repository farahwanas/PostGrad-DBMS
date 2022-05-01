<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddPublication.aspx.cs" Inherits="GUCera.AddPublication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

           Add Publication<br />
            <br />
            Title:
            <br />
            <asp:TextBox ID="title" runat="server"></asp:TextBox>
        <br />
            Publication Date:
            <br />
            <asp:TextBox ID="pubdate" runat="server"></asp:TextBox>
        <br />
             Host:<br />
        <asp:TextBox ID="host" runat="server"></asp:TextBox>
           <br />
       Place:<br />
        <asp:TextBox ID="place" runat="server"></asp:TextBox>
        <br />
        Accepted:<br />
        <asp:TextBox ID="accepted" runat="server"  TextMode="Number"></asp:TextBox>
        <br />
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="submitaddpub"/>
      <%-- <asp:Button runat="server" Text="Back"  />--%>
       </div>
    </form>
</body>
</html>
