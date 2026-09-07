using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet0709002
{
    public class LigneCommande
    {
        #region Attributs

        private int quantite;
        private Commande commande;
        private Produit produit;

        #endregion

        #region Constructeurs

        public LigneCommande(
            int quantite,
            Commande commande,
            Produit produit)
        {
            this.quantite = quantite;
            this.commande = commande;
            this.produit = produit;

            commande.LesLignesCommande.Add(this);
            produit.LesLignesCommande.Add(this);
        }

        #endregion

        #region Getter / Setter

        public int Quantite
        {
            get { return quantite; }
            set { quantite = value; }
        }

        public Commande Commande
        {
            get { return commande; }
            set { commande = value; }
        }

        public Produit Produit
        {
            get { return produit; }
            set { produit = value; }
        }

        #endregion

        #region Méthodes

        #endregion
    }
}
