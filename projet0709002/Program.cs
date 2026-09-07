using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet0709002
{
    class Program
    {
        static void Main(string[] args)
        {
            // Création des produits

            Produit produit1 =
                new Produit(1, "Clavier", 50);

            Produit produit2 =
                new Produit(2, "Souris", 25);

            Produit produit3 =
                new Produit(3, "Écran", 200);


            // Création des commandes

            Commande commande1 =
                new Commande(1);

            Commande commande2 =
                new Commande(2);

            Commande commande3 =
                new Commande(3);


            // Création des lignes de commande

            LigneCommande ligne1 =
                new LigneCommande(2, commande1, produit1);

            LigneCommande ligne2 =
                new LigneCommande(3, commande1, produit2);

            LigneCommande ligne3 =
                new LigneCommande(1, commande2, produit2);

            LigneCommande ligne4 =
                new LigneCommande(2, commande2, produit3);

            LigneCommande ligne5 =
                new LigneCommande(1, commande3, produit1);


            // TEST 1
            // Afficher les produits de la commande 1

            Console.WriteLine("Produits de la commande 1 :");

            commande1.AfficherProduits();


            // TEST 1.1
            // Afficher le montant total de la commande 1

            Console.WriteLine();

            Console.WriteLine(
                "Montant total : "
                + commande1.CalculerMontantTotal()
                + " €"
            );


            // TEST 2
            // Afficher les commandes contenant le produit 2

            Console.WriteLine();

            Console.WriteLine(
                "Commandes contenant le produit 2 :"
            );

            produit2.AfficherCommandes();
        }
    }
}
