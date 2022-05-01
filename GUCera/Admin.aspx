<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="GUCera.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>


            <br />
            <asp:Button ID="Button1" runat="server" Text="List all supervisors" OnClick="Button1_Click" />
            <br />


        </div>
      
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="List all Theses" OnClick="Button2_Click" />
      
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Issue a thesis payment:"></asp:Label>
        </p>
        
            Thesis Number:
            <asp:TextBox ID="ThesisNumber" runat="server"></asp:TextBox>
        <p>
            Amount:
            <asp:TextBox ID="Amount" runat="server"></asp:TextBox>
        </p>
        <p>
            Number of Installments:&nbsp;
            <asp:TextBox ID="noOfInstallments" runat="server"></asp:TextBox>
        </p>
        <p>
            Fund Percentage:&nbsp;
            <asp:TextBox ID="FundPercentage" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button3" runat="server" Text="Issue Thesis Payment" OnClick="Button3_Click" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Issue installments:"></asp:Label>
        </p>
       
            Payment ID:
            <asp:TextBox ID="paymentID" runat="server"></asp:TextBox>
        </p>
        <p>
            Installment date:<asp:TextBox ID="InstallStartDate" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button4" runat="server" Text="Issue installments" OnClick="Button4_Click" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Update the number of thesis extension by 1:  "></asp:Label>
        </p>
        
        <p>
            Thesis Number:<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Update" />
        </p>
        <p>
            &nbsp;</p>
      
    </form>
    <p>
        &nbsp;</p>
</body>
</html>