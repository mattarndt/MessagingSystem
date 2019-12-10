<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ArndtProject3.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server"> 
    <title>Login</title>
    <link rel="stylesheet" type="text/css" href="main.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Hello, welcome to FMail</h1>
            <asp:Label runat="server" ID="lblWelcome" Text="<h4>If you have an account, you may login here.</h4>"></asp:Label>
            
            <asp:Label runat="server" ID="lblUsrname">Enter your email (username + @fmail.com)</asp:Label>
            <asp:TextBox runat="server" ID="txtUsrname"></asp:TextBox>
            <br />
            <br />
            <asp:Label runat="server" ID="lblPssword">Enter your password</asp:Label>
            <asp:TextBox runat="server" ID="txtPssword"></asp:TextBox>
            <br />
            <asp:Button runat="server" ID="btnLogin" OnClick="Login_Click" Text="Login"></asp:Button>
        </div>
        <div>
            <h3>If you do not have an account, you can make one here.</h3>
            <asp:Label runat="server" Text="<h5>Account successfully created. Log in to continue (you may have to refresh the application to log into the account you just created)</h5>" ID="lblAccountSuccessful" CssClass="green" Visible="false"></asp:Label>
            <asp:Button runat="server" ID="btnCreateNew" OnClick="CreateNewAccount_Click" Text="Create new account"></asp:Button>
            <asp:Button runat="server" ID="btnBackToLogin" OnClick="BackToLogin_Click" Text="Login to already existing account" Visible="false"></asp:Button>
            <br />
            <br />
            <asp:Label runat="server" Text="Select account type:" Visible="false" ID="lblSelectAccount"></asp:Label>
            <asp:RadioButtonList ID="rblist1" runat="server" Visible="false">
                <asp:ListItem Text="Regular Account" Selected="true" Value="regular" />
                <asp:ListItem Text="Admin Account" Value="admin" />
            </asp:RadioButtonList>
            <br />
            <asp:Label runat="server" ID="lblUserId" Text="Enter in your account username (this will be what appears in your in your @fmail.com)" Visible="false"></asp:Label>
            <asp:TextBox runat="server" ID="txtUserId" Visible="false"></asp:TextBox>
            <br />
            <asp:Label runat="server" ID="lblPassword" Text="Enter in the new password for your account" Visible="false"></asp:Label>
            <asp:TextBox runat="server" ID="txtPassword" Visible="false"></asp:TextBox>
            <br />
            <asp:Label runat="server" ID="lblName" Text="Enter in your name" Visible="false"></asp:Label>
            <asp:TextBox runat="server" ID="txtName" Visible="false"></asp:TextBox>
            <br />
            <asp:Label runat="server" ID="lblPhone" Text="Enter in your phone number" Visible="false"></asp:Label>
            <asp:TextBox runat="server" ID="txtPhone" Visible="false"></asp:TextBox>
            <br />
            <asp:Label runat="server" ID="lblStreet" Text="Enter in your street address" Visible="false"></asp:Label>
            <asp:TextBox runat="server" ID="txtStreet" Visible="false"></asp:TextBox>
            <br />
            <asp:Label runat="server" ID="lblCity" Text="Enter in your City" Visible="false"></asp:Label>
            <asp:TextBox runat="server" ID="txtCity" Visible="false"></asp:TextBox>
            <br />
            <asp:Label runat="server" ID="lblZip" Text="Enter in your Zip Code" Visible="false"></asp:Label>
            <asp:TextBox runat="server" ID="txtZip" Visible="false"></asp:TextBox>
            <br />
            <asp:Label runat="server" ID="lblState" Text="Enter in your State" Visible="false"></asp:Label>
            <asp:TextBox runat="server" ID="txtState" Visible="false"></asp:TextBox>
            <br />
            <asp:Label runat="server" ID="lblSecondary" Text="Enter in a secondary email of yours" Visible="false"></asp:Label>
            <asp:TextBox runat="server" ID="txtSecondary" Visible="false"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label runat="server" ID="lblAvatar" Text="Select an Avatar" Visible="false"></asp:Label>
            <asp:Panel runat="server" id="pnlAvatar" Visible="false">
                <label>pic1</label>
                <asp:Image CssClass="image" runat="server" ImageUrl="avatars/pic1.png" ID="pic1"/>
                <label style="margin-left:60px;">pic2</label>
                <asp:Image CssClass="image" runat="server" ImageUrl="avatars/pic2.png" ID="pic2"/>
                <label style="margin-left:60px;">pic3</label>
                <asp:Image CssClass="image" runat="server" ImageUrl="avatars/pic3.png" ID="pic3"/>
                <label style="margin-left:60px;">pic4</label>
                <asp:Image CssClass="image" runat="server" ImageUrl="avatars/pic4.png" ID="pic4"/>
                <label style="margin-left:60px;">pic5</label>
                <asp:Image CssClass="image" runat="server" ImageUrl="avatars/pic5.png" ID="pic5"/>
                <label style="margin-left:60px;">pic6</label>
                <asp:Image CssClass="image" runat="server" ImageUrl="avatars/pic6.png" ID="pic6"/>
                <label style="margin-left:60px;">pic7</label>
                <asp:Image CssClass="image" runat="server" ImageUrl="avatars/pic7.png" ID="pic7"/>
                <label style="margin-left:60px;">pic8</label>
                <asp:Image CssClass="image" runat="server" ImageUrl="avatars/pic8.png" ID="pic8"/>
                <label style="margin-left:60px;">pic9</label>
                <asp:Image CssClass="image" runat="server" ImageUrl="avatars/pic9.png" ID="pic9"/>
                <label style="margin-left:60px;">pic10</label>
                <asp:Image CssClass="image" runat="server" ImageUrl="avatars/pic10.png" ID="pic10"/>
            </asp:Panel>

            <asp:DropDownList runat="server" ID="ddlAvatar" AppendDataBoundItems="true" AutoPostBack="true" Visible="false">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button runat="server" ID="btnCreateAccount" OnClick="CreateAccount_Click" Text="Create Account" Visible="false"/>
            
        </div>
    </form>
</body>
</html>
