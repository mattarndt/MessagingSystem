<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FMail.aspx.cs" Inherits="ArndtProject3.main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Matthew Arndt - Project III</title>
    <link rel="stylesheet" type="text/css" href="main.css" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label runat="server" ID="lblBanned" Visible="false" Text="<h1>You cannot access this application, you have been banned.</h1>"></asp:Label>
        <asp:Panel runat="server" ID="pnlEmail">
            
            <h2>Welcome,
            <asp:Label runat="server" ID="lblName"></asp:Label>
                <asp:Image runat="server" />
            </h2>
            <br />
            <asp:Button runat="server" ID="btnCompose" Text="Compose new email" OnClick="btnCompose_Click" />
            <br />
            <asp:Panel runat="server" ID="pnlCompose" Visible="false">
                <asp:Label runat="server" ID="lblMessageSent" Text="Your message was sent<br />" Visible="false"></asp:Label>
                <asp:Label runat="server" Text="Send to:"></asp:Label>
                <asp:TextBox runat="server" ID="txtSendTo"></asp:TextBox>
                <br />
                <asp:Label runat="server" Text="Subject:"></asp:Label>
                <asp:TextBox runat="server" ID="txtSubject"></asp:TextBox>
                <br />
                <asp:Label runat="server" Text="Message:"></asp:Label>
                <asp:TextBox runat="server" ID="txtMessage"></asp:TextBox>
                <br />
                <asp:Button runat="server" ID="btnCancel" Text="Cancel" OnClick="btnCancel_Click" />
                <asp:Button runat="server" ID="btnSend" Text="Send" OnClick="btnSend_Click" />
            </asp:Panel>

            <br />
            <br />
            <asp:DropDownList runat="server" ID="ddlView">
                <asp:ListItem Text="Inbox" Value="inbox" Selected="true"></asp:ListItem>
                <asp:ListItem Text="Sent" Value="sent"></asp:ListItem>
                <asp:ListItem Text="Trash" Value="trash"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:GridView ID="gvEmails" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:CheckBox runat="server" ID="chk_box" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="emailid" HeaderText="EmailID" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Image runat="server" CssClass="smallimg" ID="imgSenderAvatar" ImageUrl="avatars/pic1.png" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="usersender" HeaderText="From" />
                    <asp:BoundField DataField="subject" HeaderText="Subject" />
                    <asp:BoundField DataField="message" HeaderText="Message" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnFlag" runat="server" Text="Flag"
                                OnClick="Flag_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <asp:Label runat="server" Text="Move selected emails to:"></asp:Label>
            <asp:DropDownList ID="ddlFolders" runat="server">
            </asp:DropDownList>
            <asp:Button runat="server" ID="btnMove" Text="Move" />
        </asp:Panel>
    </form>
</body>
</html>
