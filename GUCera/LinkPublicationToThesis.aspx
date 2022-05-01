<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LinkPublicationToThesis.aspx.cs" Inherits="GUCera.LinkPublicationToThesis" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image:url('background.jpg')">
    <form id="form1" runat="server">
            Link Publication to Thesis<br />
        <br />
        <br />
         <div>

        <asp:GridView ID="Publications" runat="server" AutoGenerateColumns="false" AllowPaging="true" BackColor="LightGray" >
           <Columns>
               <asp:BoundField DataField="id" HeaderText="Publication Id" />
               <asp:BoundField DataField="title" HeaderText="Title" />
                <asp:BoundField DataField="dateOfPublication" HeaderText="Date of Publication" />
               <asp:BoundField DataField="place" HeaderText="Place" />
                <asp:BoundField DataField="accepted" HeaderText="Accepted" />
                <asp:BoundField DataField="host" HeaderText="Host" />
           </Columns>
        </asp:GridView>
              </div>
         <div>
             <br />
              <br />
        <asp:GridView ID="allstudentthesis1" runat="server" AutoGenerateColumns="false" AllowPaging="true" BackColor="LightGray">
           <Columns>
               <asp:BoundField DataField="serialNumber" HeaderText="serialNumber" />
               <asp:BoundField DataField="field" HeaderText="field" />
                <asp:BoundField DataField="type" HeaderText="type" />
               <asp:BoundField DataField="title" HeaderText="title" />
                <asp:BoundField DataField="startDate" HeaderText="startDate" />
                <asp:BoundField DataField="endDate" HeaderText="endDate" />
                <asp:BoundField DataField="defenseDate" HeaderText="defenseDate" />
                <asp:BoundField DataField="years" HeaderText="years" />
                <asp:BoundField DataField="grade" HeaderText="grade" />
                <asp:BoundField DataField="payment_id" HeaderText="payment_id" />
                <asp:BoundField DataField="noOfExtensions" HeaderText="noOfExtensions" />
             
           </Columns>
        </asp:GridView>
</div>
        <div>
           
            <br />
            Publication Id:
            <br />
<asp:TextBox ID="pubid" runat="server"></asp:TextBox>
        <br />
       Serial Number:<br />
        <asp:TextBox ID="serialno" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="submitlinkpub"/>
        </div>
    </form>
</body>
</html>
