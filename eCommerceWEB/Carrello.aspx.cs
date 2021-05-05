using eCommerce;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace eCommerceWEB
{
    public partial class Carrello : System.Web.UI.Page
    {
        public Utente Utente { get; set; }
        public List<Prodotto> Prodotti { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            Utente = Session["Utente"] as Utente;
            Prodotti = FileManager.GetProdotti();
            RefreshDdls();
            RefreshLbx();
        }
        protected void btn_add_Click(object sender, EventArgs e)
        {
            var prodCar = GetProdotto();

            bool verifica = prodCar == null;
            if (verifica)
                prodCar = new ProdottoNelCarrello(Prodotti[ddl_prodotti.SelectedIndex]);

            prodCar.Aggiungi(int.Parse(ddl_quantita.SelectedValue));

            if (verifica)
                Utente.Carrello.AggiungiProdotto(prodCar);
            RefreshLbx();

            FileManager.SaveUser(Utente);
        }
        protected void btn_remove_Click(object sender, EventArgs e)
        {
            var prodCar = GetProdotto();
            int quantita = int.Parse(ddl_quantita.SelectedValue);

            if (quantita < prodCar.Quantita)
                prodCar.Rimuovi(quantita);
            else
                Utente.Carrello.RimuoviProdotto(prodCar);

            RefreshLbx();
            FileManager.SaveUser(Utente);
        }
        protected void btn_empty_Click(object sender, EventArgs e)
        {
            Utente.AnnullaCarrello();
            RefreshLbx();
            FileManager.SaveUser(Utente);
        }
        protected void lbtn_logout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            FileManager.SaveUser(Utente);
            Response.Redirect("/Login.aspx");
        }
        public ProdottoNelCarrello GetProdotto()
        {
            var prodottoScelto = Prodotti[ddl_prodotti.SelectedIndex];
            return Utente.Carrello.Prodotti.Find(x => x.Codice == prodottoScelto.Codice);
        }
        private void RefreshDdls()
        {
            ddl_prodotti.Items.Clear();
            foreach (var prodotto in Prodotti)
            {
                ddl_prodotti.Items.Add(prodotto.ToString());
            }

            ddl_quantita.Items.Clear();
            for (int i = 0; i < 11; i++)
            {
                ddl_quantita.Items.Add($"{i}");
            }
        }
        public void RefreshLbx()
        {
            lbx_carrello.Items.Clear();
            foreach (var prodotto in Utente.Carrello.Prodotti)
            {
                lbx_carrello.Items.Add(prodotto.ToString());
            }
        }
    }
}