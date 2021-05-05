<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="eCommerceWEB.Carrello" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton ID="lbtn_logout" runat="server" OnClick="lbtn_logout_Click">Logout</asp:LinkButton>
        </div>
        <div style="margin-top: 56px">
            <asp:Label ID="lbl_prodotti" runat="server" Text="Prodotti"></asp:Label>
            <asp:DropDownList ID="ddl_prodotti" runat="server" style="margin-left: 18px" Height="19px" Width="146px"></asp:DropDownList>
            <asp:DropDownList ID="ddl_quantita" runat="server" style="margin-left: 12px" Height="16px" Width="39px"></asp:DropDownList>
            <asp:Button ID="btn_add" runat="server" Text="Aggiungi" style="margin-left: 46px" OnClick="btn_add_Click" />
            <asp:Button ID="btn_remove" runat="server" Text="Rimuovi" Width="67px" OnClick="btn_remove_Click" />
            <asp:Button ID="btn_empty" runat="server" Text="Svuota carrello" style="margin-left: 173px" OnClick="btn_empty_Click" />
        </div>
        <div>
            <asp:ListBox ID="lbx_carrello" runat="server" Height="162px" style="margin-left: 69px" Width="682px"></asp:ListBox>
        </div>
    </form>
</body>
</html>
