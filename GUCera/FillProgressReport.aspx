<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FillProgressReport.aspx.cs" Inherits="GUCera.FillProgressReport" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

   <body style="background-image:url('background.jpg')">
    <form id="form1" runat="server">
        <div>

        <asp:GridView ID="filltable" runat="server" AutoGenerateColumns="false" AllowPaging="true">
           <Columns>
               <asp:BoundField DataField="sid" HeaderText="Student Id" />
               <asp:BoundField DataField="no" HeaderText="Progress Report Number" />
                <asp:BoundField DataField="date" HeaderText="Date" />
               <asp:BoundField DataField="eval" HeaderText="Eval" />
                <asp:BoundField DataField="state" HeaderText="State" />
                <asp:BoundField DataField="description" HeaderText="Description" />
               <asp:BoundField DataField="thesisSerialNumber" HeaderText="Thesis Serial Number" />
               <asp:BoundField DataField="supid" HeaderText="Supervisor ID" />
           </Columns>
        </asp:GridView>
              </div>
        <div>

            Fill Progress Report<br />
            <br />
            Serial Number:
            <br />
            <asp:TextBox ID="serialno" runat="server"></asp:TextBox>
        <br />
            <%--Student Id:
            <br />
            <asp:TextBox ID="id" runat="server"></asp:TextBox>
        <br />--%>
       State:<br />
      <%--  <input ID="progdate" runat="server" type="date"></input>--%>
        <asp:TextBox ID="state" runat="server"></asp:TextBox>
           <br />
        Progress Report Number:<br />
        <asp:TextBox ID="reportno" runat="server"></asp:TextBox>
        <br />
        Description:<br />
        <asp:TextBox ID="description" runat="server" TextMode="MultiLine"></asp:TextBox>
        
        <br />
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="submitfillprog"/>
      <%-- <asp:Button runat="server" Text="Back"  />--%>
       </div>
    </form>
</body>

</html>
