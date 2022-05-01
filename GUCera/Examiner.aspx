<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Examiner.aspx.cs" Inherits="GUCera.Examiner" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

    <body style="background-image:url('background.jpg')">
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="Label1" runat="server" Text="Edit my personal information "></asp:Label>
            

            <br />
            <asp:Label ID="Label2" runat="server" Text="Name:"></asp:Label>
            <asp:TextBox ID="name" runat="server" Width="1010px"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Field of work:"></asp:Label>
            <asp:TextBox ID="fieldOfWork" runat="server" Width="912px"></asp:TextBox>
            <br />
            <asp:Button ID="EditButton" runat="server" OnClick="Edit" Text="Edit" />
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="List attended:"></asp:Label>
            &nbsp;<asp:Button ID="listbutton" runat="server" OnClick="list" Text="List" />
            <br />
            <asp:GridView ID="listGridView" runat="server" EmptyDataText="Did not attend any defense yet!" ShowHeaderWhenEmpty="True">
            </asp:GridView>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Add a comment?"></asp:Label>
            <br />
            <asp:Label ID="Label6" runat="server" Text="When? (Please enter Defense Date:in format=>YYYY-MM-DD):"></asp:Label>
            <asp:TextBox ID="DefenseDate" runat="server" Width="636px" TextMode="DateTime"></asp:TextBox>
            <br />
            <asp:Label ID="Label7" runat="server" Text="Which? (Please enter Thesis' Serial Number): "></asp:Label>
            <asp:TextBox ID="ThesisSerialNumber" runat="server" Width="514px"></asp:TextBox>
            <br />
            <asp:Label ID="Label8" runat="server" Text="Your Comment:"></asp:Label>
            <asp:TextBox ID="comment" runat="server" Width="892px"></asp:TextBox>
            <br />
            <asp:Button ID="addcommentbutton" runat="server" OnClick="addcomment" Text="Add a Comment" />
            <br />
            <br />
            <asp:Label ID="Label9" runat="server" Text="Add a grade?"></asp:Label>
            <br />
            <asp:Label ID="Label10" runat="server" Text="When? (Please enter Defense Date: in format=>YYYY-MM-DD):"></asp:Label>
            <asp:TextBox ID="DefenseDategrade" runat="server" Width="658px" TextMode="DateTime"></asp:TextBox>
            <br />
            <asp:Label ID="Label11" runat="server" Text="Which? (Please enter Thesis' Serial Number): "></asp:Label>
            <asp:TextBox ID="ThesisSerialNumbergrade" runat="server" Width="534px"></asp:TextBox>
            <br />
            <asp:Label ID="Label12" runat="server" Text="The Grade(kindly enter 0-99 and only 2 decimal places):"></asp:Label>
            <asp:TextBox ID="grade" runat="server" Width="970px"></asp:TextBox>
            <br />
            <asp:Button ID="addgradebutton" runat="server" OnClick="addgrade" Text="Add a Grade" />
            <br />
            <br />
            <asp:Label ID="Label13" runat="server" Text="Search for thesis?"></asp:Label>
            <br />
            <asp:Label ID="Label14" runat="server" Text="Search:"></asp:Label>
            <asp:TextBox ID="TxtSearch" runat="server" Width="818px" TextMode="Search"></asp:TextBox>
            &nbsp;
            <asp:Button ID="searchbutton" runat="server" OnClick="search" Text="Search" BackColor="#3399FF" ForeColor="White" />
            
            <br />
            
            <asp:GridView ID="searchGridView" runat="server" EmptyDataText="No Records Found!" ShowHeaderWhenEmpty="True">
            </asp:GridView>
            <br />
            

        </div>
    </form>
</body>
</html>