<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrazione.aspx.cs" Inherits="eCommerceWEB.Registrazione" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <style type="text/css">
        .formStyle {
            width: 342px;
            margin: auto;
            padding: 400px;
        }
    </style>
    <form id="form1" runat="server">
        <div class="formStyle">
            <table>
                <tr>
                    <td>
                        <asp:Label ID="lbl_username" runat="server" Text="Username"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="tbx_username" runat="server"  Height="17px" Width="128px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lbl_password" runat="server" Text="Password"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="tbx_password" runat="server"  Height="17px" Width="128px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lbl_confPassword" runat="server" Text="Conferma password"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="tbx_confPassword" runat="server"  Height="17px" Width="128px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lbl_nome" runat="server" Text="Nome"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="tbx_nome" runat="server"  Height="17px" Width="128px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lbl_cognome" runat="server" Text="Cognome"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="tbx_cognome" runat="server"  Height="17px" Width="128px"></asp:TextBox></td>
                </tr>

            </table>
            <asp:Button ID="btn_register" runat="server" Text="Registrati" OnClick="btn_register_Click" Style="margin-left: 102px" />
        </div>
    </form>
</body>
</html>
