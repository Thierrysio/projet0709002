using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet0709002
{
    public class Produit
    {
        #region Attributs

        private int id;
        private string nom;
        private decimal prix;
        private List<LigneCommande> lesLignesCommande;

        #endregion

        #region Constructeurs

        public Produit(int id, string nom, decimal prix)
        {
            this.id = id;
            this.nom = nom;
            this.prix = prix;

            this.lesLignesCommande = new List<LigneCommande>();
        }

        #endregion

        #region Getter / Setter

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public decimal Prix
        {
            get { return prix; }
            set { prix = value; }
        }

        public List<LigneCommande> LesLignesCommande
        {
            get { return lesLignesCommande; }
        }

        #endregion

        #region Méthodes

        public void AfficherCommandes()
        {
            foreach (LigneCommande ligne in lesLignesCommande)
            {
                Console.WriteLine("Commande " + ligne.Commande.Id);
            }
        }

        #endregion
    }
}
