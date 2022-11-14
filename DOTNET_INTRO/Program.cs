using System;
using DOTNET_INTRO;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double largeur, langueur; //Declaration des variables utilisées
            int typeCouvrePlancher;
            int i=0; //compteur
            
            List<PlancherExpert> plancherExpertsList = new List<PlancherExpert>(); //Initialisation des objets des planchare Expert
            plancherExpertsList.Add(new PlancherExpert("Tapis commercial", 1.29, 2));
            plancherExpertsList.Add(new PlancherExpert("Tapis de qualité", 3.99, 2.25)) ;
            plancherExpertsList.Add(new PlancherExpert("Plancher de bois franc", 3.49, 3.25));
            plancherExpertsList.Add(new PlancherExpert("Plancher flottant", 1.99, 2.25));
            plancherExpertsList.Add(new PlancherExpert("Céramique", 1.49, 3.25));

            //Demande des données de l'utilisateur
            System.Console.WriteLine("\nPour calculer les coûts reliés à l’installation de couvre-planchers qu vous voulez");
            System.Console.WriteLine("Veuiller saisir les données ci-dessous: \n");
            Console.Write("La langueur en pieds: ");
            langueur = Convert.ToDouble(System.Console.ReadLine());
            Console.Write("La largeur en pieds: ");
            largeur = Convert.ToDouble(System.Console.ReadLine());

            
            System.Console.WriteLine("\n*Le type de couvre-planchers:***********");
            foreach(PlancherExpert expert in plancherExpertsList)
            {
                System.Console.WriteLine("*      "+(i+1)+" - "+expert.Name);
                i++;
            }
            System.Console.WriteLine("****************************************");
            Console.Write("Saisir le numéro assoscié au type de couvre-planchers que vous installer: ");
            typeCouvrePlancher = Convert.ToInt32(System.Console.ReadLine());

            while (typeCouvrePlancher < 1 || typeCouvrePlancher > plancherExpertsList.Count()) //verification du type plancher
            {
                Console.Write("Erreur de saisie. Veuillez choisir un type de couvre planchers valide: ");
                typeCouvrePlancher = Convert.ToInt32(System.Console.ReadLine());
            }

            //creation d'un objet client
            Client client = new Client(langueur, largeur, plancherExpertsList[typeCouvrePlancher - 1]);

            //affichage des données
            System.Console.WriteLine("\n********** Informations de votre demande: **************");
            System.Console.WriteLine(client.AfficherDetails());
            System.Console.WriteLine("********************************************************");
        }
    }
}


