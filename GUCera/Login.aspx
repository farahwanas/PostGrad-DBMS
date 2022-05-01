<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GUCera.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>GUCera Login</title>
    <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <%--<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">--%>
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
  <style>
      body {
  margin: 0;
 
}

ul {
  list-style-type: none;
  margin: 0;
  padding: 0;
  overflow: hidden;
  background-color: #333;
   top: 0;

}

li {
  float: left;
}

li a {
  display: block;
  color: white;
  text-align: center;
  padding: 14px 16px;
  text-decoration: none;
}

li a:hover:not(.active) {
  background-color: #5d5959;
}


</style>
</head>
  
<body style="background-image:url('background.jpg')">
    <form id="form1" runat="server">
  
    <%--<div class="navbar-header">
      <a class="navbar-brand" href="#">Gucera
      </a>
    </div>--%>
   <%-- <ul class="nav navbar-nav" >
      <li class="active"><a href="Login.aspx">Home</a></li>
     <li><a href="Registration.aspx">Student Registration</a></li>
      <li><a href="SupervisorRegistration.aspx">Supervisor Registration</a></li>
        <li><a href="#">Examiner Registration</a></li>

     
    </ul>--%>
      <ul>
  <li><a href="Login.aspx">Home</a></li>
   <li><a href="Registration.aspx">Student Registration</a></li>
      <li><a href="SupervisorRegistration.aspx">Supervisor Registration</a></li>
        <li><a href="#">Examiner Registration</a></li>
  
</ul>
<br />
      <br />
  </div>
</nav>
  <div style=" text-align: center ">
            Username:<br />
            <asp:TextBox ID="username" runat="server"></asp:TextBox>
            <br />
            Password:<br />
         <asp:TextBox ID="password" runat="server"  TextMode="Password" ></asp:TextBox>
            <br />
        <br />
            <asp:Button ID="log" runat="server" Text="Login" OnClick="login" />
            <br />
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
