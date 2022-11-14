using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOTNET_INTRO;

namespace DOTNET_INTRO
{
    internal class Client
    {
        private double langueur;
        private double largeur;
        private PlancherExpert pe;

        public Client(double langueur, double largeur, PlancherExpert pe)
        {
            this.langueur = langueur;
            this.largeur = largeur;
            this.pe = pe;
        }

        public double Langueur { 
            get { return langueur; } 
            set { langueur = value; }
        }

        public double Largeur
        {
            get { return largeur; }
            set { largeur = value; }
        }

        public PlancherExpert Pe
        {
            get { return pe; }
            set { pe = value; }
        }

        public double CalculSuperficie()
        {
            return this.langueur * this.largeur;
        }
        
        public double CalculHTMateriaux()
        {
            return this.pe.Materiaux * this.CalculSuperficie();
        }

        public double CalculHTMainOeuvre()
        {
            return this.pe.MainOeuvre * this.CalculSuperficie();
        }

        public double CalculTaxeMateriaux()
        {
            return this.CalculHTMateriaux() * 0.15;
        }

        public double CalculTaxeMainOeuvre()
        {
            return this.CalculHTMainOeuvre() * 0.15;
        }

        public double CalculTotalHT()
        {
            return this.CalculHTMateriaux() + this.CalculHTMainOeuvre();
        }

        public double CalculTotalTTC()
        {
            return this.CalculTotalHT() + this.CalculTaxeMainOeuvre() + this.CalculTaxeMateriaux();
        }

        public string AfficherDetails()
        {
            string details="";

            details+="* Langueur= " + this.Langueur + "pi Largeur= " + this.Largeur + "pi superficie= " + this.CalculSuperficie() + "pi² \n";
            details += this.pe.AfficherDetails();
            details += "*\n";
            details += "* Facture : \n";
            details += "*\n";
            details += "* Coût des matériaux:\t" + this.pe.Materiaux + "$\n";
            details += "* Coût de la main d'ouevre: \t" + this.pe.MainOeuvre + "$\n";
            details += "* Le total Hors taxe:\t" + this.CalculTotalHT() + "$\n";
            details += "* Taxe sur coût des matériaux:\t" + this.CalculTaxeMateriaux() + "$\n";
            details += "* Taxe sur coût de la main d'ouevre:\t" + this.CalculTaxeMainOeuvre() + "$\n";
            details += "*\n";
            details += "* Le total taxes inclus:\t" + this.CalculTotalTTC() + "$\n";
            details += "*\n";
            return details;
        }
    }
}
