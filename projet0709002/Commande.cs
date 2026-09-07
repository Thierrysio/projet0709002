using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet0709002
{
    public class Commande
    {
        #region Attributs

        private int id;
        private List<LigneCommande> lesLignesCommande;

        #endregion

        #region Constructeurs

        public Commande(int id)
        {
            this.id = id;
            this.lesLignesCommande = new List<LigneCommande>();
        }

        #endregion

        #region Getter / Setter

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public List<LigneCommande> LesLignesCommande
        {
            get { return lesLignesCommande; }
        }

        #endregion

        #region Méthodes

        public void AfficherProduits()
        {
            foreach (LigneCommande ligne in lesLignesCommande)
            {
                Console.WriteLine(
                    ligne.Produit.Nom +
                    " - Quantité : " +
                    ligne.Quantite
                );
            }
        }

        public decimal CalculerMontantTotal()
        {
            decimal total = 0;

            foreach (LigneCommande ligne in lesLignesCommande)
            {
                total = total + ligne.Produit.Prix * ligne.Quantite;
            }

            return total;
        }

        #endregion
    }
}
