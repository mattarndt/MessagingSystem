<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="ArndtProject3.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Welcome,
            <asp:Label runat="server" ID="lblName"></asp:Label>
            <asp:Image runat="server" />
        </h2>
        <asp:Button runat="server" ID="btnViewAccounts" Text="View all accounts" OnClick="btnViewAccounts_Click"/>
        <asp:Button runat="server" ID="btnCloseAccounts" Text="Close all accounts" OnClick="btnCloseAccounts_Click"/>
        <asp:GridView ID="gvAccounts" runat="server" AutoGenerateColumns="False" Visible="false">
            <Columns>
                <asp:BoundField DataField="userID" HeaderText="User ID"/>
                <asp:BoundField DataField="usertype" HeaderText="User Type"/>
                <asp:BoundField DataField="name" HeaderText="Name"/>
                <asp:BoundField DataField="phonenumber" HeaderText="Phone Number" />
                <asp:BoundField DataField="street" HeaderText="Street"/>
                <asp:BoundField DataField="city" HeaderText="City"/>
                <asp:BoundField DataField="zipcode" HeaderText="Zip Code"/>
                <asp:BoundField DataField="state" HeaderText="State" />
                <asp:BoundField DataField="secondaryemail" HeaderText="Secondary Email"/>
                <asp:BoundField DataField="avatar" HeaderText="Avatar"/>
            </Columns>
        </asp:GridView>
        <br />
        <br />
        <asp:Button runat="server" ID="btn" Text="View all flagged emails" OnClick="btnViewFlaggedEmails_Click"/>
        <asp:Button runat="server" ID="Button2" Text="Close all flagged emails" OnClick="btnCloseFlaggedEmails_Click"/>
        <asp:GridView ID="gvFlaggedEmails" runat="server" AutoGenerateColumns="False" Visible="false">
            <Columns>
                <asp:BoundField DataField="emailid" HeaderText="Email ID"/>
                <asp:BoundField DataField="usersender" HeaderText="Sender"/>
                <asp:BoundField DataField="userreciever" HeaderText="Reciever"/>
                <asp:BoundField DataField="subject" HeaderText="Subject" />
                <asp:BoundField DataField="message" HeaderText="Message"/>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="btnBan" runat="server" Text="Ban Sender"
                            OnClick="Ban_Click" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <br />
        <br />
        <asp:Button runat="server" ID="btnViewBanned" Text="View all banned accounts" OnClick="btnViewBannedAccounts_Click"/>
        <asp:Button runat="server" ID="btnCloseBanned" Text="Close all banned accounts" OnClick="btnCloseBannedAccounts_Click"/>
        <asp:GridView ID="gvBannedAccounts" runat="server" AutoGenerateColumns="False" Visible="false">
            <Columns>
                <asp:BoundField DataField="userID" HeaderText="User ID"/>
                <asp:BoundField DataField="usertype" HeaderText="User Type"/>
                <asp:BoundField DataField="name" HeaderText="Name"/>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="btnUnban" runat="server" Text="Unban User"
                            OnClick="Unban_Click" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
