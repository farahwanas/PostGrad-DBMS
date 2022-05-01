<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddProgressReport.aspx.cs" Inherits="GUCera.AddProgressReport" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            Add Progress Report<br />
            <br />
            Serial Number:</div>
       <%--<input ID="serialno" runat="server" type="number"></input>--%>
<asp:TextBox ID="serialno" runat="server"></asp:TextBox>
        <br />
        Progress Report Date:<br />
      <%--  <input ID="progdate" runat="server" type="date"></input>--%>
        <asp:TextBox ID="progdate" runat="server"></asp:TextBox>
        <br />
       <%-- Student Id:<br />
        <asp:TextBox ID="id" runat="server"></asp:TextBox>
        <br />--%>
        Progress Report Number:<br />
        <asp:TextBox ID="reportno" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="submitaddprog"/>
      <%-- <asp:Button runat="server" Text="Back"  />--%>
       
    </form>
</body>
</html>

