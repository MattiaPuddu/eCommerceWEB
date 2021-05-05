using eCommerce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eCommerceWEB
{
    public partial class Registrazione : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_register_Click(object sender, EventArgs e)
        {
            if (tbx_password.Text == tbx_confPassword.Text && CheckTbx()){
                FileManager.RegisterUser(new Utente(tbx_username.Text, tbx_password.Text, tbx_nome.Text, tbx_cognome.Text));
                Response.Write("<script>alert('Ti sei registrato con successo, ora effettua il login')</script>");
                Response.Redirect("/Login.aspx");
            }
            else
                Response.Write("<script>alert('Le password non combaciano')</script>");
        }
        private bool CheckTbx()
        {
            return tbx_username.Text != "" && tbx_username.Text != null && tbx_password.Text != "" && tbx_password.Text != null && tbx_confPassword.Text != "" && tbx_confPassword.Text != null && tbx_nome.Text != "" && tbx_nome.Text != null && tbx_cognome.Text != "" && tbx_cognome.Text != null;
        }
    }
}