<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="eCommerceWEB.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            width: 160px;
            height: 166px;
            margin: auto;
            padding: 400px;
        }
    </style>
</head>
<body>
    <style>
    </style>
    <form id="form1" runat="server">
        <div class="formDati">
        </div>
            <div style="margin-left: 5px; margin-top: 0px">
                <asp:Label ID="lbl_username" runat="server" Text="Username"></asp:Label>
                <asp:TextBox ID="tbx_username" runat="server" style="margin-left: 13px"></asp:TextBox>
            
                <asp:Label ID="lbl_password" runat="server" Text="Password"></asp:Label>
                <asp:TextBox ID="tbx_password" runat="server" TextMode="Password" style="margin-left: 13px" ></asp:TextBox>
            
                <asp:Button ID="btn_login" runat="server" Text="Login" OnClick="btn_login_Click" style="margin-left: 3px; margin-top: 24px" Width="53px" />
                <asp:Button ID="btn_register" runat="server" Text="Registrati" style="margin-left: 9px" OnClick="btn_register_Click" />
            </div>
    
    </form>
</body>
</html>
