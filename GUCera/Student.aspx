<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="GUCera.Student" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body style="background-image:url('background.jpg')">
    <form id="form1" runat="server">
               <div > 



        <asp:Button ID="Button1" runat="server" Text="View all my information" OnClick="studentreg" Width="255px" />
        <p>
            <asp:Button ID="Button2" runat="server" Text="List all my theses in the system" OnClick="studentlist" Width="255px"/>
        </p>
        
         <p>
        <asp:Button ID="Button3" runat="server" Text="View my Courses" OnClick="nonguc_courses" Width="255px" />
             
         </p>
   
              <asp:Button ID="Button6" runat="server" Text="Add Progress Report" OnClick="addprogressreport" Width="255px"  />
          <p>
          <asp:Button ID="Button5" runat="server" Text="Fill Progress Report" OnClick="fillprogressreport" Width="255px"  />
              </p>
         <p>
            <asp:Label ID="Label1" runat="server" Text="Add your Phone numbers "></asp:Label>
        <br />
         
        <asp:TextBox ID="phonenumbers" runat="server" style="margin-top: 0px" Width="255px"></asp:TextBox>
            <br/>
        
        <asp:Button ID="addphone" runat="server" Text="Add" OnClick="Button1_Click" Width="50px" />
             </p>
        <asp:Button ID="addpub" runat="server" Text="Add Publication" OnClick="addpublication"  Width="255px" />

        <br/>
                   <p>
                     <asp:Button  ID="linkpub" runat="server" Text="Link Publication to Thesis" OnClick="linkpublication"  Width="255px" />
        </p>
 </div>
              <asp:GridView ID="GucStudentinfo" runat="server" AutoGenerateColumns="false" AllowPaging="true" BackColor="LightGray">
           <Columns>
               <asp:BoundField DataField="id" HeaderText="Id" />
               <asp:BoundField DataField="firstName" HeaderText="FirstName" />
                <asp:BoundField DataField="lastName" HeaderText="LastName" />
               <asp:BoundField DataField="type" HeaderText="Type" />
                <asp:BoundField DataField="faculty" HeaderText="Faculty" />
                <asp:BoundField DataField="address" HeaderText="Address" />
                <asp:BoundField DataField="GPA" HeaderText="GPA" />
                <asp:BoundField DataField="undergradID" HeaderText="undergrad Id" />
           </Columns>
        </asp:GridView>
        <br />
         <br />
        
              <asp:GridView ID="NonGucStudentinfo" runat="server" AutoGenerateColumns="false" AllowPaging="true" BackColor="LightGray">
           <Columns>
               <asp:BoundField DataField="id" HeaderText="Id" />
               <asp:BoundField DataField="firstName" HeaderText="FirstName" />
                <asp:BoundField DataField="lastName" HeaderText="LastName" />
               <asp:BoundField DataField="type" HeaderText="Type" />
                <asp:BoundField DataField="faculty" HeaderText="Faculty" />
                <asp:BoundField DataField="address" HeaderText="Address" />
                <asp:BoundField DataField="GPA" HeaderText="GPA" />
             
           </Columns>
        </asp:GridView>
        <br />
         <br />
        <div>
          <asp:GridView ID="allstudentthesis" runat="server" AutoGenerateColumns="false" AllowPaging="true" BackColor="LightGray">
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
        <br />
         <br />
            <div >
          <asp:GridView ID="coursegradestable" runat="server" AutoGenerateColumns="false" AllowPaging="true" BackColor="LightGray">
           <Columns>
               <asp:BoundField DataField="code" HeaderText="Course Code" />
               <asp:BoundField DataField="grade" HeaderText="Grade" />
              
             
           </Columns>
        </asp:GridView>
</div>
 </form>
</body>
</html>
