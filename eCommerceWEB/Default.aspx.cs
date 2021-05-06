using eCommerce;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eCommerceWEB
{
    public partial class Login : System.Web.UI.Page
    {
        public Utente Utente { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            var utenti = FileManager.GetUtenti();
            Utente = utenti?.Find(x => x.Username == tbx_username.Text && x.Password == tbx_password.Text);
            
            if (Utente != null)
            {
                Session["Utente"] = Utente;

                Response.Redirect("/Carrello.aspx");
            }
            else
            {
                Response.Write("<script>alert('Dati errati, ritenta')</script>");
                ClearTbx();
            }
        }
        protected void btn_register_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Registrazione.aspx");
        }
        public void ClearTbx()
        {
            tbx_username.Text = "";
            tbx_password.Text = "";
        }
    }
}